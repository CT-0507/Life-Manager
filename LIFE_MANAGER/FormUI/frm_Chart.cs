using MongoDB.Driver;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;
using System.Xml;
using System.Xml.Serialization;

namespace LIFE_MANAGER.FormUI
{
    public partial class frm_Chart : Form
    {
        private IMongoCollection<Models.Diary> Diaries = frm_Login.db.GetCollection<Models.Diary>("Diaries");
        private IMongoCollection<Models.Plan> Plans = frm_Login.db.GetCollection<Models.Plan>("Plans");
        private int HappyDays = 0;
        private int NeutralDays = 0;
        private int SadDays = 0;
        private int NotSet = 0;
        private DateTime Today = DateTime.Now;
        private Models.Plan plan;
        private readonly string filePath = "data.xml";
        private PlanData job;
        bool first = false;
        public PlanData Job
        {
            get { return job; }
            set { job = value; }
        }
        public frm_Chart()
        {
            InitializeComponent();
            dtpk_Time.Value = Today;
            GetPlan();
            GetMoodChartValue(Today);
            PieChart_Mood.Titles.Add("Mood Chart");
            //PieChart_Mood.Series["Series1"].IsValueShownAsLabel = true;
            if (HappyDays != 0) PieChart_Mood.Series["Series1"].Points.AddXY("Happy", HappyDays);

            if (NeutralDays != 0) PieChart_Mood.Series["Series1"].Points.AddXY("Neutral", NeutralDays);
            if (SadDays != 0) PieChart_Mood.Series["Series1"].Points.AddXY("Sad", SadDays);
            if (NotSet != 0) PieChart_Mood.Series["Series1"].Points.AddXY("Not Set", NotSet);
            setStaticsLabel();
            GetToDoChartValue(Today);
            ColumnChart_Tasks.Titles.Add("Task Chart");
            ColumnChart_Tasks.Series["Series1"].IsValueShownAsLabel = true;
            ColumnChart_Tasks.Series["Series1"].Points.AddXY("DONE", DONETask);
            ColumnChart_Tasks.Series["Series1"].Points.AddXY("DOING", DOINGTask);
            ColumnChart_Tasks.Series["Series1"].Points.AddXY("COMING", COMINGTask);
            ColumnChart_Tasks.Series["Series1"].Points.AddXY("MISSED", MISSEDTask);
            setTaskChartLabel();
            first = true;
        }
        private void GetPlan()
        {
            try
            {
                var query = Plans.Find(planD => planD.UserId == frm_Login.User._id);
                plan = query.First();
            }
            catch
            {
                plan = new Models.Plan()
                {
                    Data = "",
                    UserId = frm_Login.User._id,
                };
                var settingoptions = new CreateIndexOptions { Unique = true };
#pragma warning disable CS0618 // Type or member is obsolete
                Plans.Indexes.CreateOne("{ UserId : 1 }", settingoptions);
#pragma warning restore CS0618 // Type or member is obsolete
                Plans.InsertOne(plan);
                var query = Plans.Find(planD => planD.UserId == frm_Login.User._id);
                plan = query.First();
            }
            try
            {
                XmlDocument doc = new XmlDocument();
                doc.LoadXml(plan.Data);
                doc.Save(filePath);
                Job = DeserializeFromXML(filePath) as PlanData;
            }
            catch
            {
                SetDefaultJob();
            }
        }
        void SetDefaultJob()
        {
            Job = new PlanData();
            Job.Job = new List<PlanItem>();
            Job.Job.Add(new PlanItem()
            {
                Date = Today,
                FromTime = new Point(4, 0),
                ToTime = new Point(5, 0),
                Job = "Thử nghiệm thôi",
                Status = PlanItem.ListStatus[(int)EPlanItem.COMING]
            });
        }
        private void btn_Close_Click(object sender, EventArgs e)
        {
            this.Close();

        }

        private void dtpk_Time_ValueChanged(object sender, EventArgs e)
        {
            
            if (first)
            {
                GetMoodChartValue(dtpk_Time.Value);
                PieChart_Mood.Series["Series1"].Points.Clear();
                if (HappyDays != 0) PieChart_Mood.Series["Series1"].Points.AddXY("Happy", HappyDays);

                if (NeutralDays != 0) PieChart_Mood.Series["Series1"].Points.AddXY("Neutral", NeutralDays);
                if (SadDays != 0) PieChart_Mood.Series["Series1"].Points.AddXY("Sad", SadDays);
                if (NotSet != 0) PieChart_Mood.Series["Series1"].Points.AddXY("Not Set", NotSet);
                setStaticsLabel();
                GetToDoChartValue(dtpk_Time.Value);
                ColumnChart_Tasks.Series["Series1"].Points.Clear();
                ColumnChart_Tasks.Series["Series1"].Points.AddXY("DONE", DONETask);
                ColumnChart_Tasks.Series["Series1"].Points.AddXY("DOING", DOINGTask);
                ColumnChart_Tasks.Series["Series1"].Points.AddXY("COMING", COMINGTask);
                ColumnChart_Tasks.Series["Series1"].Points.AddXY("MISSED", MISSEDTask);
                setTaskChartLabel();
            }
            

        }
        private List<PlanItem> JobOfThisMonth;
        private int DONETask;
        private int DOINGTask;
        private int COMINGTask;
        private int MISSEDTask;
        private void GetToDoChartValue(DateTime date)
        {
            DONETask = 0;
            DOINGTask = 0;
            COMINGTask = 0;
            MISSEDTask = 0;
            JobOfThisMonth = new List<PlanItem>();
            for (int i = 0; i < Job.Job.Count; i++)
            {
                if (Job.Job[i].Date.Month == date.Month)
                {
                    JobOfThisMonth.Add(Job.Job[i]);
                }
            }
            for (int x = 0; x < JobOfThisMonth.Count; x++)
            {
                switch(JobOfThisMonth[x].Status)
                {
                    case "DONE":
                        DONETask++;
                        break;
                    case "DOING":
                        DOINGTask++;
                        break;
                    case "COMING":
                        COMINGTask++;
                        break;
                    default:
                        MISSEDTask++;
                        break;
                }
            }
        }
        private void GetMoodChartValue(DateTime date)
        {
            HappyDays = 0;
            NeutralDays = 0;
            NotSet = 0;
            SadDays = 0;
            var DateMDY = date.ToString("M/d/yyyy");
            var DateSplited = DateMDY.Split(new char[] { '/' }, StringSplitOptions.RemoveEmptyEntries);
            try
            {
                var MoodQuery = Diaries.Find(dateD => dateD.DateSplit[0] == DateSplited[2] && dateD.DateSplit[1] == DateSplited[0] && dateD.UserId == frm_Login.User._id).ToList();
                for (int i = 0; i < MoodQuery.Count; i++)
                {
                    switch(MoodQuery[i].Mood)
                    {
                        case "Happy":
                            HappyDays++;
                            break;
                        case "Neutral":
                            NeutralDays++;
                            break;
                        case "Sad":
                            SadDays++;
                            break;
                        default:
                            NotSet++;
                            break;
                    }
                }
                NotSet = DayOfMonth(Today) - MoodQuery.Count;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        int DayOfMonth(DateTime date)
        {
            switch (date.Month)
            {
                case 1:
                case 3:
                case 5:
                case 7:
                case 8:
                case 10:
                case 12:
                    return 31;
                case 2:
                    if ((date.Year % 4 == 0 && date.Year % 100 != 0) || date.Year % 400 == 0)
                        return 29;
                    else
                        return 28;
                default:
                    return 30; ;
            }
        }
        private void setStaticsLabel()
        {
            lb_HappyDays.Text = "Happy days: " + HappyDays;
            lb_NeutralDays.Text = "Neutral days: " + NeutralDays;
            lb_SadDays.Text = "Sad days: " + SadDays;
            lb_NotSet.Text = "Not set days: " + NotSet;
        }
        private void setTaskChartLabel()
        {
            lb_DONE.Text = "Done task: " + DONETask;
            lb_DOING.Text = "DOING task: " + DOINGTask;
            lb_COMING.Text = "COMING task: " + COMINGTask;
            lb_MISSED.Text = "MISSED task: " + MISSEDTask;

        }
        private void SerializeToXML(object data, string filePath)
        {
            FileStream fs = new FileStream(filePath, FileMode.OpenOrCreate, FileAccess.Write);
            XmlSerializer sr = new XmlSerializer(typeof(PlanData));

            sr.Serialize(fs, data);
            fs.Close();
            StreamReader streamReader = new StreamReader(filePath);
            string xml = streamReader.ReadToEnd();
            streamReader.Close();
            var update = Builders<Models.Plan>.Update
                        .Set("Data", xml);

            try
            {
                var updateDataQuery = Plans.UpdateOne(planD => planD._id == plan._id, update);
                plan.Data = xml;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private object DeserializeFromXML(string filePath)
        {
            FileStream fs = new FileStream(filePath, FileMode.Open, FileAccess.Read);
            try
            {
                XmlSerializer sr = new XmlSerializer(typeof(PlanData));
                object result = sr.Deserialize(fs);
                fs.Close();
                return result;
            }
            catch
            {
                fs.Close();
                throw new NotImplementedException();
            }
        }
    }
}

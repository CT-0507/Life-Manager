using MongoDB.Bson.IO;
using MongoDB.Driver;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Windows.Forms;
using System.Xml;
using System.Xml.Serialization;

namespace LIFE_MANAGER.FormUI
{
    public partial class frm_Diary : Form
    {
        #region Peoperties
        private readonly string filePath = "data.xml";

        private List<List<Button>> matrix;

        public List<List<Button>> Matrix
        {
            get { return matrix; }
            set { matrix = value; }
        }

        private PlanData job;

        public PlanData Job
        {
            get { return job; }
            set { job = value; }
        }

        private List<string> dateOfWeek = new List<string>() { "Monday", "Tuesday", "Wednesday", "Thursday", "Friday", "Saturday", "Sunday" };
        private IMongoCollection<Models.Plan> Plans = frm_Login.db.GetCollection<Models.Plan>("Plans");
        private IMongoCollection<Models.Diary> Diaries = frm_Login.db.GetCollection<Models.Diary>("Diaries");
        private Models.Plan plan;
        private DateTime Today = DateTime.Now;
        #endregion
        public frm_Diary()
        {
            InitializeComponent();

            LoadMatrix();
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
                //string data = Models.AesOperation.DecryptString("Key", plan.Data);
                doc.LoadXml(plan.Data);
                doc.Save(filePath);
                Job = DeserializeFromXML(filePath) as PlanData;
                File.Delete(filePath);
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

        void LoadMatrix()
        {
            Matrix = new List<List<Button>>();

            Button oldBtn = new Button() { Width = 0, Height = 0, Location = new Point(-Cons.margin, 0) };
            for (int i = 0; i < Cons.DayOfColumn; i++)
            {
                Matrix.Add(new List<Button>());
                for (int j = 0; j < Cons.DayOfWeek; j++)
                {
                    Button btn = new Button() { Width = Cons.dateButtonWidth, Height = Cons.dateButtonHeight };
                    btn.Location = new Point(oldBtn.Location.X + oldBtn.Width + Cons.margin, oldBtn.Location.Y);
                    btn.Click += btn_Click;

                    pnlMatrix.Controls.Add(btn);
                    Matrix[i].Add(btn);

                    oldBtn = btn;

                }
                oldBtn = new Button() { Width = 0, Height = 0, Location = new Point(-Cons.margin, oldBtn.Location.Y + Cons.dateButtonHeight) };
            }

            SetDefaultDate();
        }

        void btn_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty((sender as Button).Text))
                return;
            frm_Todo daily = new frm_Todo(new DateTime(dtpkDate.Value.Year, dtpkDate.Value.Month, Convert.ToInt32((sender as Button).Text)), Job);
            daily.ShowDialog();
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

        public void AddNumberIntoMatrixByDate(DateTime date)
        {
            ClearMatrix();
            DateTime useDate = new DateTime(date.Year, date.Month, 1);
            try
            {
                var DateMDY = date.ToString("M/d/yyyy");
                var DateSplited = DateMDY.Split(new char[] { '/' }, StringSplitOptions.RemoveEmptyEntries);
                var MoodQuery = Diaries.Find(dateD => dateD.DateSplit[0] == DateSplited[2] && dateD.DateSplit[1] == DateSplited[0] && dateD.UserId == frm_Login.User._id).ToList();
                int line = 0;
                for (int i = 1; i <= DayOfMonth(date); i++)
                {
                    int column = dateOfWeek.IndexOf(useDate.DayOfWeek.ToString());
                    Button btn = Matrix[line][column];
                    btn.Text = i.ToString();

                    if (isEqualDate(useDate, DateTime.Now))
                    {
                        btn.BackColor = Color.Purple;
                    }

                    //if (isEqualDate(useDate, date))
                    //{
                    //    btn.BackColor = Color.Aqua;
                    //}
                    for (int z = 0; z < MoodQuery.Count; z++)
                    {
                        
                        var result = Int32.TryParse(MoodQuery[z].DateSplit[0], out var Year);
                        result = Int32.TryParse(MoodQuery[z].DateSplit[1], out var Month);
                        if (btn.Text == MoodQuery[z].DateSplit[2] && date.Year == Year && date.Month == Month)
                        {
                            if(MoodQuery[z].Mood == "Happy")
                            {
                                btn.BackColor = Color.Aqua;
                            }
                            if(MoodQuery[z].Mood == "Neutral")
                            {
                                btn.BackColor = Color.Yellow;
                            }
                            if(MoodQuery[z].Mood == "Sad")
                            {
                                btn.BackColor= Color.Red;
                            }
                        }
                    }
                    if (column >= 6)
                        line++;

                    useDate = useDate.AddDays(1);
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return;
            }
            
        }

        bool isEqualDate(DateTime dateA, DateTime dateB)
        {
            return dateA.Year == dateB.Year && dateA.Month == dateB.Month && dateA.Day == dateB.Day;
        }

        void ClearMatrix()
        {
            for (int i = 0; i < Matrix.Count; i++)
            {
                for (int j = 0; j < Matrix[i].Count; j++)
                {
                    Button btn = Matrix[i][j];
                    btn.Text = "";
                    btn.BackColor = Color.WhiteSmoke;
                }
            }
        }

        void SetDefaultDate()
        {
            dtpkDate.Value = DateTime.Now;
        }

        private void dtpkDate_ValueChanged(object sender, EventArgs e)
        {
            AddNumberIntoMatrixByDate((sender as DateTimePicker).Value);
        }

        private void btnNext_Click(object sender, EventArgs e)
        {
            dtpkDate.Value = dtpkDate.Value.AddMonths(1);
        }

        private void btnPreviours_Click(object sender, EventArgs e)
        {
            dtpkDate.Value = dtpkDate.Value.AddMonths(-1);
        }

        private void btnToDay_Click(object sender, EventArgs e)
        {
            SetDefaultDate();
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
            //string encryptXml = Models.AesOperation.EncryptString("Key", xml);
            File.Delete(filePath);
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

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            SerializeToXML(Job, filePath);
            
        }
       
        private void frm_Diary_Load(object sender, EventArgs e)
        {
            panel1.BackgroundImage = this.BackgroundImage;
            panel2.BackgroundImage = this.BackgroundImage;

        }

        private void nmNotify_ValueChanged(object sender, EventArgs e)
        {

        }

        private void ckbNotify_CheckedChanged(object sender, EventArgs e)
        {

        }
    }
}

using MongoDB.Driver;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

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
        public frm_Chart()
        {
            InitializeComponent();
            dtpk_Time.Value = Today;
            GetMoodChartValue(Today);
            PieChart_Mood.Titles.Add("Mood Chart");
            PieChart_Mood.Series["Series1"].Points.AddXY("Happy", HappyDays);
            PieChart_Mood.Series["Series1"].Points.AddXY("Neutral", NeutralDays);
            PieChart_Mood.Series["Series1"].Points.AddXY("Sad", SadDays);
            PieChart_Mood.Series["Series1"].Points.AddXY("Not Set", NotSet);
            setStaticsLabel();
        }

        private void btn_Close_Click(object sender, EventArgs e)
        {
            this.Close();

        }

        private void dtpk_Time_ValueChanged(object sender, EventArgs e)
        {
            GetMoodChartValue(dtpk_Time.Value);
            PieChart_Mood.Series["Series1"].Points.Clear();
            PieChart_Mood.Series["Series1"].Points.AddXY("Happy", HappyDays);
            PieChart_Mood.Series["Series1"].Points.AddXY("Neutral", NeutralDays);
            PieChart_Mood.Series["Series1"].Points.AddXY("Sad", SadDays);
            PieChart_Mood.Series["Series1"].Points.AddXY("Not Set", NotSet);
            setStaticsLabel();
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
    }
}

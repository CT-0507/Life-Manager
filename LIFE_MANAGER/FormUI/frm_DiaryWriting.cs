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
    public partial class frm_DiaryWriting : Form
    {
        private IMongoCollection<Models.Diary> Diaries = frm_Login.db.GetCollection<Models.Diary>("Diaries");
        private Models.Diary diary;
        public frm_DiaryWriting(DateTime Date)
        {
            InitializeComponent();        
            try
            {
                var query = Diaries.Find(x => x.Date == Date.ToString("yyyyMMdd") && x.UserId == frm_Login.User._id);
                diary = query.First();
            }
            catch (Exception ex)
            {
                diary = new Models.Diary()
                {
                    Date = Date.ToString("yyyyMMdd"),
                    DiaryNote = "",
                    DrawingImage = "",
                    Images = null,
                    UserId = frm_Login.User._id,
                };
                var settingoptions = new CreateIndexOptions { Unique = true };
#pragma warning disable CS0618 // Type or member is obsolete
                Diaries.Indexes.CreateOne("{ Date : 1 }", settingoptions);
#pragma warning restore CS0618 // Type or member is obsolete
                Diaries.InsertOne(diary);
                var diaryquery = Diaries.Find(date => date.Date == Date.ToString("yyyyMMdd"));
                diary = diaryquery.First();
            }           
            lb_Date.Text = diary.Date;
        }
    }
}

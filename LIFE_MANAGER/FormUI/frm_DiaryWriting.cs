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

namespace LIFE_MANAGER.FormUI
{
    public partial class frm_DiaryWriting : Form
    {
        private IMongoCollection<Models.Diary> Diaries = frm_Login.db.GetCollection<Models.Diary>("Diaries");
        private Models.Diary diary;
        private DateTime thisDay;
        public frm_DiaryWriting(DateTime Date)
        {
            InitializeComponent();
            thisDay = Date;
            List<string> moods = new List<string>
            {
                "Happy",
                "Neutral",
                "Sad"
            };
            cb_Mood.DataSource = moods;
            cb_Mood.SelectedIndex = 0;
            var DateMDY = Date.ToString("M/d/yyyy");
            var DateSplited = DateMDY.Split(new char[] {'/'}, StringSplitOptions.RemoveEmptyEntries);
            try
            {
                
                var query = Diaries.Find(x => x.Date == Date.ToString("yyyyMMdd") && x.UserId == frm_Login.User._id);
                diary = query.First();
            }
            catch
            {
                diary = new Models.Diary()
                {
                    Date = Date.ToString("yyyyMMdd"),
                    DateSplit = new List<string>(3) 
                    {
                        DateSplited[2],
                        DateSplited[0],
                        DateSplited[1],
                    },
                    DiaryNote = "",
                    DrawingImage = "",
                    Images = new List<string>(),
                    Mood = "Happy",
                    UserId = frm_Login.User._id,
                };
                Diaries.InsertOne(diary);
                var diaryquery = Diaries.Find(date => date.Date == Date.ToString("yyyyMMdd") && date.UserId == frm_Login.User._id);
                diary = diaryquery.First();
            }           
            
            lb_Date.Text = $"Date: {diary.DateSplit[2]}/{diary.DateSplit[1]}/{diary.DateSplit[0]}";
            rtb_Diary.Text = diary.DiaryNote;
            cb_Mood.Text = diary.Mood;
            if (diary.Images.Count != 0)
            {
                for (int i = 0; i < diary.Images.Count; i++)
                {
                    var img = Image.FromStream(new MemoryStream(Convert.FromBase64String(diary.Images[i])));
                    PictureBox pictureBox = new PictureBox()
                    {
                        Size = new Size(pnl_Images.Width - 10, pnl_Images.Height - 10),
                        SizeMode = PictureBoxSizeMode.StretchImage,
                        Image = img,
                        Dock = DockStyle.Left,
                        Name = img.ToString(),
                    };
                    pnl_Images.Controls.Add(pictureBox);
                }
                
            }
        }

        private void btn_SaveChanges_Click(object sender, EventArgs e)
        {
            diary.DiaryNote = rtb_Diary.Text;
            if (imagePaths.Count == 0)
            {
                diary.Images.Clear();
            }
            else
            {
                for (int i = 0; i < imagePaths.Count; i++)
                {
                    byte[] imageArray = System.IO.File.ReadAllBytes(imagePaths[i]);
                    string base64ImageRepresentation = Convert.ToBase64String(imageArray);
                    diary.Images.Add(base64ImageRepresentation);
                }
            }
            diary.Mood = cb_Mood.Text;
            try
            {
                var update = Builders<Models.Diary>.Update
                    .Set("DiaryNote", diary.DiaryNote)
                    .Set("Images", diary.Images)
                    .Set("Mood", diary.Mood);
                var updateQuery = Diaries.UpdateOne(diaryD => diaryD._id == diary._id, update);
                frm_Diary frm = Application.OpenForms.OfType<frm_Diary>().FirstOrDefault();
                //frm.Form_Lo;
                frm.AddNumberIntoMatrixByDate(thisDay);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            
        }
        private OpenFileDialog ofd;
        private List<string> imagePaths = new List<string>();
        private void btn_UploadImage_Click(object sender, EventArgs e)
        {
            if (imagePaths.Count < 5)
            {
                ofd = new OpenFileDialog();
                ofd.Filter = "Image File (*.jpg;*.png)|*.jpg;*.png";
                ofd.Multiselect = true;
                if (ofd.ShowDialog() == DialogResult.OK)
                {
                    foreach (var item in ofd.FileNames)
                    {
                        imagePaths.Add(item);
                        PictureBox pictureBox = new PictureBox()
                        {
                            Size = new Size(pnl_Images.Width - 10, pnl_Images.Height - 10),
                            SizeMode = PictureBoxSizeMode.StretchImage,
                            Image = Image.FromFile(item),
                            Dock = DockStyle.Left,
                            Name = item
                        };
                        pnl_Images.Controls.Add(pictureBox);
                    }
                }
            }
            else
            {
                MessageBox.Show("Cannot upload too many images");
            }
        }

        private void btn_Clear_Click(object sender, EventArgs e)
        {
            pnl_Images.Controls.Clear();
            imagePaths.Clear();
        }

        private void btn_Close_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}

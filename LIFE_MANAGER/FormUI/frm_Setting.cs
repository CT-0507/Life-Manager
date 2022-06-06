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
    public partial class frm_Setting : Form
    {
        private int ViewBtnWidth;
        private bool OriginalStateNotification = frm_Login.Setting.isNotification;
        private bool OriginalStateStartWithWindows = frm_Login.Setting.StartWithWindows;
        private bool OriginalStateVolume = frm_Login.Setting.isBackgroundMusicVolume;
        public frm_Setting()
        {
            InitializeComponent();
            tgb_Notification.Checked = OriginalStateNotification;
            tgb_StartWithWindows.Checked = OriginalStateStartWithWindows;
            tgb_Volume.Checked = OriginalStateVolume;
            ViewBtnWidth = btn_ViewBackground.Width;
            this.BackgroundImageLayout = ImageLayout.Stretch;
            if(frm_Login.Setting.BackgroundImage != null)
            {
                var img = Image.FromStream(new MemoryStream(Convert.FromBase64String(frm_Login.User.Avatar)));
                this.BackgroundImage = img;
            }
        }

        private void btn_Close_Click(object sender, EventArgs e)
        {
            this.Close();

        }
        private string backgroundImagePath = null;
        private void btn_BackgroundUpload_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Filter = "Image File (*.jpg;*.png)|*.jpg;*.png";
            if (ofd.ShowDialog() == DialogResult.OK)
            {
                backgroundImagePath = ofd.FileName;
                this.BackgroundImage = Image.FromFile(backgroundImagePath);
            }
        }
        private bool isView = false;
        private void btn_ViewBackground_Click(object sender, EventArgs e)
        {
            isView = !isView;
            
            if(isView)
            {
                tgb_Volume.Visible = false;
                tgb_Notification.Visible = false;
                tgb_StartWithWindows.Visible = false;
                lb_Notification.Visible = false;
                lb_StartWithWindows.Visible = false;
                lb_Volume.Visible = false;
                btn_BackgroundUpload.Visible = false;
                btn_ViewBackground.Text = "Close";
                btn_ViewBackground.Width = 100;
            }
            else
            {
                tgb_Volume.Visible = true;
                tgb_Notification.Visible = true;
                tgb_StartWithWindows.Visible = true;
                lb_Notification.Visible = true;
                lb_StartWithWindows.Visible = true;
                lb_Volume.Visible = true;
                btn_BackgroundUpload.Visible = true;
                btn_ViewBackground.Text = "View Background";
                btn_ViewBackground.Width = ViewBtnWidth;
            }
            
        }

        private void tgb_Notification_CheckedChanged(object sender, EventArgs e)
        {
            if (tgb_Notification.Checked != OriginalStateNotification)
            {
                OriginalStateNotification = tgb_Notification.Checked;
                
                try
                {
                    var update = Builders<Models.Setting>.Update
                            .Set("isNotification", OriginalStateNotification);
                    var query = frm_Login.Settings.UpdateOne(setting => setting._id == frm_Login.Setting._id, update);
                    frm_Login.Setting.isNotification = OriginalStateNotification;
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }

        private void tgb_StartWithWindows_CheckedChanged(object sender, EventArgs e)
        {
            if (tgb_StartWithWindows.Checked != OriginalStateStartWithWindows)
            {
                OriginalStateStartWithWindows = tgb_StartWithWindows.Checked;
                try
                {
                    var update = Builders<Models.Setting>.Update
                            .Set("StartWithWindows", OriginalStateStartWithWindows);
                    var query = frm_Login.Settings.UpdateOne(setting => setting._id == frm_Login.Setting._id, update);
                    frm_Login.Setting.StartWithWindows = OriginalStateStartWithWindows;
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }

        private void tgb_Volume_CheckedChanged(object sender, EventArgs e)
        {
            if (tgb_Volume.Checked != OriginalStateVolume)
            {
                OriginalStateVolume = tgb_Volume.Checked;
                try
                {
                    var update = Builders<Models.Setting>.Update
                            .Set("isBackgroundMusicVolume", OriginalStateStartWithWindows);
                    var query = frm_Login.Settings.UpdateOne(setting => setting._id == frm_Login.Setting._id, update);
                    frm_Login.Setting.isBackgroundMusicVolume = OriginalStateStartWithWindows;
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }
    }
}

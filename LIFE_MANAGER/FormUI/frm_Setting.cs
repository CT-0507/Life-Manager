using Microsoft.Win32;
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
            if(frm_Login.Setting.BackgroundImage != "")
            {
                var img = Image.FromStream(new MemoryStream(Convert.FromBase64String(frm_Login.Setting.BackgroundImage)));
                this.BackgroundImage = img;
            }
            else
            {
                this.BackgroundImage = null;
            }
        }

        private void btn_Close_Click(object sender, EventArgs e)
        {
            this.Close();

        }
        public static Image a;
        private string backgroundImagePath = "";
        private void btn_BackgroundUpload_Click(object sender, EventArgs e)
        {
            System.Windows.Forms.OpenFileDialog ofd = new System.Windows.Forms.OpenFileDialog();
            ofd.Filter = "Image File (*.jpg;*.png)|*.jpg;*.png";
            if (ofd.ShowDialog() == DialogResult.OK)
            {
                backgroundImagePath = ofd.FileName;
                a= Image.FromFile(backgroundImagePath);
                this.BackgroundImage = a;    
                byte[] imageArray = System.IO.File.ReadAllBytes(backgroundImagePath);
                string base64ImageRepresentation = Convert.ToBase64String(imageArray);
                var update = Builders<Models.Setting>.Update
                            .Set("BackgroundImage", base64ImageRepresentation);
                var query = frm_Login.Settings.UpdateOne(setting => setting._id == frm_Login.Setting._id, update);
                frm_Login.Setting.BackgroundImage = base64ImageRepresentation;
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
                btn_RemoveBackgroundImage.Visible = false;
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
                btn_RemoveBackgroundImage.Visible = true;

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
        RegistryKey regstart = Registry.CurrentUser.CreateSubKey("SOFTWARE\\Microsoft\\Windows\\CurrentVersion\\Run");


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


            //hàm khỏi động cùng windows
            if (tgb_StartWithWindows.Checked==true)
            {
                RegistryKey regkey = Registry.CurrentUser.CreateSubKey("Software\\LIFE_MANAGER");
                //mo registry khoi dong cung win
                string keyvalue = "1";

                try
                {
                    //chen gia tri key
                    regkey.SetValue("Index", keyvalue);
                    regstart.SetValue("LIFE_MANAGER", Application.StartupPath + "\\LIFE_MANAGER.exe");
                    regkey.Close();

                }
                catch (System.Exception ex)
                {
                }
            }
            else
            {
                regstart.DeleteValue("LIFE_MANAGER");

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
                    frm_Login.Setting.isBackgroundMusicVolume = OriginalStateVolume;
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }

        private void btn_RemoveBackgroundImage_Click(object sender, EventArgs e)
        {
            this.BackgroundImage = null;
            var update = Builders<Models.Setting>.Update
                            .Set("BackgroundImage", String.Empty);
            var query = frm_Login.Settings.UpdateOne(setting => setting._id == frm_Login.Setting._id, update);
            frm_Login.Setting.BackgroundImage = "";
        }

        private void tgb_DarkMode_CheckedChanged(object sender, EventArgs e)
        {

        }
    }
}

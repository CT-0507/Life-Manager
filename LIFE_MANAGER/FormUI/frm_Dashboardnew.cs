using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.IO;
using System.Linq;
using System.Media;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using FontAwesome.Sharp;

namespace LIFE_MANAGER.FormUI
{
    public partial class frm_Dashboardnew : Form
    {
        public static WMPLib.WindowsMediaPlayer Player;
        private IconButton currentBtn;
        private Panel leftBorderBtn;
        private Form currentChildForm;
        public static int a;
        //Constructor
        public frm_Dashboardnew()
        {
            InitializeComponent();
            leftBorderBtn = new Panel();
            // Media Player 

            
            
            leftBorderBtn.Size = new Size(7, 60);
            panelMenu.Controls.Add(leftBorderBtn);
            //Form
            this.Text = string.Empty;
            this.ControlBox = false;
            this.DoubleBuffered = true;
            this.MaximizedBounds = Screen.FromHandle(this.Handle).WorkingArea;
            if (frm_Login.User.Avatar != null)
            {
                var img = Image.FromStream(new MemoryStream(Convert.FromBase64String(frm_Login.User.Avatar)));
                Image resizeimage = resizeImage(img, new Size(50, 50));
                this.btn_User.Image = OvalImage(resizeimage);
                this.btn_User.ImageAlign = ContentAlignment.MiddleLeft;

            }
            this.btn_User.Text = frm_Login.User.Name;
            this.btn_User.TextAlign = ContentAlignment.MiddleRight;
            if (a==1)
            {
                setbackclor(BackColor);
            }
            else
            {
                setbackclor1(Color.LightGreen);
            }

        }
        //Structs
        
        public void setbackclor (Color clor)
        {
            panelDeskTop.BackColor = clor;
            panelLogo.BackColor = clor;
            panelMenu.BackColor = clor;
            panelTitleBar.BackColor = clor;
            btnHome.BackColor = clor;
            btn_chart.BackColor = clor;
            btn_Diary.BackColor = clor;
            btn_profile.BackColor = clor;
            btn_setting.BackColor = clor;
            btnHome.ForeColor = Color.White;
            btn_chart.ForeColor = Color.White;
            btn_Diary.ForeColor = Color.White;
            btn_profile.ForeColor = Color.White;
            btn_setting.ForeColor = Color.White;

            btn_chart.IconColor = Color.White;
            btn_Diary.IconColor = Color.White;
            btn_profile.IconColor = Color.White;
            btn_setting.IconColor = Color.White;
        }
        public void setbackclor1(Color clor)
        {


            panelDeskTop.BackColor = clor;
            panelLogo.BackColor = clor;
            panelMenu.BackColor = clor;
            panelTitleBar.BackColor = clor;
            btn_chart.BackColor = clor;
            btn_Diary.BackColor = clor;
            btn_profile.BackColor = clor;
            btn_setting.BackColor = clor;

            btn_chart.ForeColor = Color.Black;
            btn_Diary.ForeColor = Color.Black;
            btn_profile.ForeColor = Color.Black;
            btn_setting.ForeColor = Color.Black;

            btn_chart.IconColor = Color.Black;
            btn_Diary.IconColor = Color.Black;
            btn_profile.IconColor = Color.Black;
            btn_setting.IconColor = Color.Black;

        }
        private struct RGBColors
        {
            public static Color color1 = Color.FromArgb(172, 126, 241);
            public static Color color2 = Color.FromArgb(249, 118, 176);
            public static Color color3 = Color.FromArgb(253, 138, 114);
            public static Color color4 = Color.FromArgb(95, 77, 221);
            public static Color color5 = Color.FromArgb(249, 88, 155);
            public static Color color6 = Color.FromArgb(24, 161, 251);
        }
        //Methods
        private void ActivateButton(object senderBtn, Color color)
        {
            if (senderBtn != null)
            {
                DisableButton();
                //Button
                currentBtn = (IconButton)senderBtn;
            
                    //currentBtn.BackColor = Color.FromArgb(37, 36, 81);
                    //leftBorderBtn.BackColor = color;

                //currentBtn.ForeColor = color;
                currentBtn.TextAlign = ContentAlignment.MiddleCenter;
               //currentBtn.IconColor = color;
                currentBtn.TextImageRelation = TextImageRelation.TextBeforeImage;
                currentBtn.ImageAlign = ContentAlignment.MiddleRight;
                //Left border button;
                leftBorderBtn.Location = new Point(0, currentBtn.Location.Y);
                leftBorderBtn.Visible = true;
                leftBorderBtn.BringToFront();
                //Current Child Form Icon;
                iconcurrentchildform.IconChar = currentBtn.IconChar;
                iconcurrentchildform.IconColor = color;
            }

        }
        private void DisableButton()
        {
            if (currentBtn != null)
            {
                //currentBtn.BackColor = Color.FromArgb(31, 30, 68);
                //currentBtn.ForeColor = Color.Gainsboro;
                currentBtn.TextAlign = ContentAlignment.MiddleLeft;
                //currentBtn.IconColor = Color.Gainsboro;
                currentBtn.TextImageRelation = TextImageRelation.ImageBeforeText;
                currentBtn.ImageAlign = ContentAlignment.MiddleLeft;
            }
        }
        private void OpenChildForm(Form childForm)
        {
            timer1.Stop();
            try
            {
                if (frm_Setting.a != null)
                {
                    childForm.BackgroundImage = frm_Setting.a;

                }
            }
            catch (Exception)
            {

                throw;
            }
          
            
            childForm.TopLevel = false;
            //open only form
            if (currentChildForm != null)
            {
                currentChildForm.Close();
            }
            currentChildForm = childForm;
            //End
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            panelDeskTop.Controls.Add(childForm);
            panelDeskTop.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();
            lblTitleChildForm.Text = childForm.Text;
            
           
        }
        private void Reset()
        {
            DisableButton();
            leftBorderBtn.Visible = false;
            iconcurrentchildform.IconChar = IconChar.Home;
            iconcurrentchildform.IconColor = Color.MediumPurple;
            lblTitleChildForm.Text = "Home";
        }
        //Events
        //Reset
     
        //Menu Button_Clicks
        private void btnHome_Click_1(object sender, EventArgs e)
        {
            if (currentChildForm != null)
            {
                currentChildForm.Close();
            }
            Reset();
        }
        private void btn_profile_Click(object sender, EventArgs e)
        {
            ActivateButton(sender, RGBColors.color6);
            OpenChildForm(new frm_Profile());
        }

        private void btn_Diary_Click(object sender, EventArgs e)
        {
            ActivateButton(sender, RGBColors.color6);
            OpenChildForm(new frm_Diary());

        }

        private void btn_chart_Click(object sender, EventArgs e)
        {
            ActivateButton(sender, RGBColors.color6);
            OpenChildForm(new frm_Chart());

        }

        private void btn_setting_Click(object sender, EventArgs e)
        {
            ActivateButton(sender, RGBColors.color6);
            OpenChildForm(new frm_Setting());

        }

        private void btn_logout_Click(object sender, EventArgs e)
        {

            if (currentChildForm != null)
            {
                currentChildForm.Close();
            }
            ActivateButton(sender, RGBColors.color6);
            DialogResult dialogResult = MessageBox.Show("Are you sure you want to logout", "Logout ?", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                frm_Login.User = null;
                Thread a = new Thread(() => new frm_Login().ShowDialog());
                a.SetApartmentState(ApartmentState.STA);
                a.IsBackground = true;
                a.Start();
                this.Close();
            }
        }
        //Drag Form
        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hWnd, int wMsg, int wParam, int lParam);
     
        //Close-Maximize-Minimize
     
     
        //Remove transparent border in maximized state
        private void FormMainMenu_Resize(object sender, EventArgs e)
        {
            if (WindowState == FormWindowState.Maximized)
                FormBorderStyle = FormBorderStyle.None;
            else
                FormBorderStyle = FormBorderStyle.Sizable;
        }

        private void panelTitleBar_MouseDown_1(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void btn_Quit_Click(object sender, EventArgs e)
        {
            if (currentChildForm != null)
            {
                currentChildForm.Close();
            }
            DialogResult dialogResult = MessageBox.Show("Are you sure you want to quit", "Quit ?", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                timer1.Enabled = false;
                this.Close();
            }
            
        }

        private void btn_Maximize_Click(object sender, EventArgs e)
        {
            if (WindowState == FormWindowState.Normal)
                this.WindowState = FormWindowState.Maximized;
            else
                this.WindowState = FormWindowState.Normal;
        }

        private void bnt_Minimize_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;

        }

        private void panelDeskTop_Paint(object sender, PaintEventArgs e)
        {

        }
        public void ChangeUserAvatar()
        {
            var img = Image.FromStream(new MemoryStream(Convert.FromBase64String(frm_Login.User.Avatar)));
            Image resizeimage = resizeImage(img, new Size(64, 64));
            this.btn_User.Image = OvalImage(resizeimage);
            this.btn_User.ImageAlign = ContentAlignment.MiddleLeft;
            this.btn_User.Text = frm_Login.User.Name;
            this.btn_User.TextAlign = ContentAlignment.MiddleRight;
            btn_User.Invalidate();
        }
        public Image resizeImage(Image imgToResize, Size size)
        {
            return (Image)(new Bitmap(imgToResize, size));
        }
        public static Image OvalImage(Image img)
        {
            Bitmap bmp = new Bitmap(img.Width, img.Height);
            using (GraphicsPath gp = new GraphicsPath())
            {
                gp.AddEllipse(0, 0, img.Width, img.Height);
                using (Graphics gr = Graphics.FromImage(bmp))
                {
                    gr.SetClip(gp);
                    gr.DrawImage(img, Point.Empty);
                }
            }
            return bmp;
        }

        private void frm_Dashboardnew_Load(object sender, EventArgs e)
        {
            this.Activated += AfterLoading;
            
        }
        private void AfterLoading(object sender, EventArgs e)
        {
            this.Activated -= AfterLoading;
            Player = new WMPLib.WindowsMediaPlayer();
            Player.uiMode = "invisible";
            Player.controls.pause();
            Player.URL = Path.Combine(Path.GetDirectoryName(Application.ExecutablePath), "Resource\\backgroundmusic\\BackgroundMusic.mp3");
            if (frm_Login.Setting.isBackgroundMusicVolume == false)
            {
                Player.controls.pause();

            }
            else
            {
                Player.controls.play();
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (count == 3)
            {
                timer1.Stop();
                timer1.Enabled = false;
            }
            else
            {
                timer1.Start();
                if (frm_Login.Setting.isBackgroundMusicVolume == false)
                {
                    Player.controls.pause();

                }
                count++;
            }
            
            
        }

        private void btn_Quit_MouseHover(object sender, EventArgs e)
        {
            this.BackColor = Color.Red;
        }

        private void btn_Maximize_MouseHover(object sender, EventArgs e)
        {
            this.BackColor= Color.Yellow;
        }
        private int count = 0;
        private void frm_Dashboardnew_FormClosing(object sender, FormClosingEventArgs e)
        {
            
            timer1.Stop();
            timer1.Enabled = false;
        }
    }
}

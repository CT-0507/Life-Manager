using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using MongoDB.Driver;
namespace LIFE_MANAGER.FormUI
{
    public partial class frm_Login : Form
    {

        public static MongoClient mongoClient = new MongoClient("mongodb+srv://tranquocc123:Quoccuong1@maincluster.fmpjzgz.mongodb.net/?retryWrites=true&w=majority");
        public static IMongoDatabase db = mongoClient.GetDatabase("DiaryApp");
        public static IMongoCollection<Models.User> Users = db.GetCollection<Models.User>("Users");
        public static IMongoCollection<Models.Setting> Settings = db.GetCollection<Models.Setting>("Settings");
        public static Models.User User;
        public static Models.Setting Setting;

        public frm_Login()
        {
            InitializeComponent();
        }
        private void btn_Login_Click(object sender, EventArgs e)
        {
            string strUsername = tb_User.Text;
            string strPassword = tb_Pass.Text;
            if (!string.IsNullOrEmpty(strUsername) || !string.IsNullOrEmpty(strPassword))
            {
                var query = Users.Find(x => x.Username == strUsername);
                try
                {
                    String saved = query.First().Password;
                    byte[] hashBytes = Convert.FromBase64String(saved);
                    byte[] salt = new byte[16];
                    Array.Copy(hashBytes, 0, salt, 0, 16);
                    var pbkdf2 = new Rfc2898DeriveBytes(strPassword, salt, 100000);
                    byte[] hash = pbkdf2.GetBytes(20);
                    bool ok = true;
                    for (int i = 0; i < 20; i++)
                        if (hashBytes[i + 16] != hash[i])
                        {
                            ok = false;
                            break;
                        }
                    if (ok)
                    {
                        User = (Models.User)query.First();
                        lb_WrongUser.Visible = false;
                        try
                        {
                            var UserSetting = Settings.Find(setting => setting.UserId == User._id);
                            Setting = UserSetting.First();
                        }
                        catch (Exception ex)
                        {
                            //MessageBox.Show(ex.Message);
                            Models.Setting setting = new Models.Setting()
                            {
                                isBackgroundMusicVolume = true,
                                isNotification = true,
                                BackgroundImage = "",
                                StartWithWindows = true,
                                isDarkMode = false,
                                UserId = User._id,
                            };
                            var settingoptions = new CreateIndexOptions { Unique = true };
#pragma warning disable CS0618 // Type or member is obsolete
                            frm_Login.Settings.Indexes.CreateOne("{ UserId : 1 }", settingoptions);
#pragma warning restore CS0618 // Type or member is obsolete
                            frm_Login.Settings.InsertOne(setting);
                            var UserSetting = Settings.Find(settingD => setting.UserId == User._id);
                            Setting = UserSetting.First();
                        }
                        Thread abc = new Thread(() => new frm_Dashboardnew().ShowDialog());
                        frm_Loading frm = new frm_Loading();
                        frm.ShowDialog();
                        abc.SetApartmentState(ApartmentState.STA);
                        //abc.IsBackground = true;
                        abc.Start();
                        this.Close();
                    }
                    else
                    {
                        tb_Pass.Clear();
                        lb_WrongUser.Visible = true;
                    }
                }
                catch
                {
                    MessageBox.Show("No user found");
                }
            }

        }
        private void lb_OpenRegister_Click(object sender, EventArgs e)
        {
            Thread a = new Thread(() => new frm_Register().ShowDialog());
            a.SetApartmentState(ApartmentState.STA);
            //a.IsBackground = true;
            a.Start();
            this.Close();

        }

        private void tb_Pass_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                btn_Login.PerformClick();
                tb_Pass.Clear();
            }
        }
        private void btn_Close_Click(object sender, EventArgs e)
        {
            this.Close();

        }

        private void tb_User_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                if (tb_Pass.Text != "" && tb_User.Text != "")
                {
                    btn_Login.PerformClick();
                    tb_User.Clear();
                    tb_Pass.Clear();
                }
        }
    } 
  }

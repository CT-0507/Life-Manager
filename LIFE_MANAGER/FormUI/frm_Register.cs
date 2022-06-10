using MongoDB.Driver;
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

namespace LIFE_MANAGER.FormUI
{
    public partial class frm_Register : Form
    {
        public frm_Register()
        {
            InitializeComponent();
        }
        private string imagePath;
        private void btn_Register_Click(object sender, EventArgs e)
        {
            string strName = tb_Name.Text;
            string strUsername = tb_Username.Text;
            string strPassword = tb_Password.Text;
            string strBiography = rtb_Biography.Text;
            string strDate = tb_Date.Text;
            string strConfirm = tb_Confirm.Text;
            string savedPasswordHash = HashPassword(strPassword);
            if (strUsername != "" && strPassword != "" && strName != "")
            {
                if (strConfirm == strPassword)
                {
                    try
                    {
                        Models.User user = new Models.User()
                        {
                            Name = strName,
                            Username = strUsername,
                            Password = savedPasswordHash,
                            Biography = strBiography,
                            Date = strDate,
                        };
                        if (imagePath != null)
                        {
                            byte[] imageArray = System.IO.File.ReadAllBytes(imagePath);
                            string base64ImageRepresentation = Convert.ToBase64String(imageArray);
                            user.Avatar = base64ImageRepresentation;
                        }
                        else
                        {
                            user.Avatar = null;
                        }
                        
                        var options = new CreateIndexOptions { Unique = true };
#pragma warning disable CS0618 // Type or member is obsolete
                        frm_Login.Users.Indexes.CreateOne("{ Username : 1 }", options);
#pragma warning restore CS0618 // Type or member is obsolete
                        frm_Login.Users.InsertOne(user);
                        try
                        {
                            var query = frm_Login.Users.Find(x => x.Username == strUsername);
                            Models.User user1 = (Models.User)query.First();
                            Models.Setting setting = new Models.Setting()
                            {
                                isBackgroundMusicVolume = false,
                                isNotification = true,
                                BackgroundImage = "",
                                StartWithWindows = true,
                                UserId = user1._id,
                            };
                            var settingoptions = new CreateIndexOptions { Unique = true };
#pragma warning disable CS0618 // Type or member is obsolete
                            frm_Login.Settings.Indexes.CreateOne("{ UserId : 1 }", settingoptions);
#pragma warning restore CS0618 // Type or member is obsolete
                            frm_Login.Settings.InsertOne(setting);
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show(ex.Message);
                        }
                        Thread a = new Thread(() => new frm_Login().ShowDialog());
                        a.SetApartmentState(ApartmentState.STA);
                        //a.IsBackground = true;
                        a.Start();
                        this.Close();
                    }
                    catch
                    {
                        MessageBox.Show("Username is already exist");
                    }
                }
                else
                {
                    MessageBox.Show("Confirm password is not match");
                }
            }
            else
            {
                MessageBox.Show("Please enter Username, Password and Name");
            }
        }
        private string HashPassword(string password)
        {
            byte[] salt;
            new RNGCryptoServiceProvider().GetBytes(salt = new byte[16]);
            var pbkdf2 = new Rfc2898DeriveBytes(password, salt, 100000);
            byte[] hash = pbkdf2.GetBytes(20);
            byte[] hashBytes = new byte[36];
            Array.Copy(salt, 0, hashBytes, 0, 16);
            Array.Copy(hash, 0, hashBytes, 16, 20);
            string savedPasswordHash = Convert.ToBase64String(hashBytes);
            return savedPasswordHash;
        }

        private void btn_Close_Click(object sender, EventArgs e)
        {
            this.Close();

        }

        private void btn_AvatarUpload_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Filter = "Image File (*.jpg;*.png)|*.jpg;*.png";
            if (ofd.ShowDialog() == DialogResult.OK)
            {
                pb_Avatar.Image = null;
                pb_Avatar.Image = Image.FromFile(ofd.FileName);
                pb_Avatar.SizeMode = PictureBoxSizeMode.StretchImage;
                imagePath = ofd.FileName;
            }
        }

        private void pb_Avatar_Click(object sender, EventArgs e)
        {

        }
    }
}

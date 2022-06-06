using MongoDB.Driver;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LIFE_MANAGER.FormUI
{
    public partial class frm_Profile : Form
    {
        private string OriginalName;
        private string OriginalDate;
        private string OriginalBiography;
        private string OriginalAvatar;
        public frm_Profile()
        {
            InitializeComponent();
            FormLoad();
            pb_Avatar.SizeMode = PictureBoxSizeMode.StretchImage;
        }

        private void btn_SaveChanges_Click(object sender, EventArgs e)
        {
            if (tb_Name.Text != "")
            {
                if (tb_Name.Text != OriginalName || tb_Date.Text != OriginalDate
                    || rtb_Bio.Text != OriginalBiography || imagePath != null)
                {
                    Models.User UserChanges = new Models.User()
                    {
                        //_id = frm_Login.User._id,
                        Name = tb_Name.Text,
                        Date = tb_Date.Text,
                        Biography = rtb_Bio.Text,
                        updatedAt = DateTime.Now,
                    };
                    if (imagePath != null)
                    {
                        byte[] imageArray = System.IO.File.ReadAllBytes(imagePath);
                        string base64ImageRepresentation = Convert.ToBase64String(imageArray);
                        UserChanges.Avatar = base64ImageRepresentation;
                    }
                    else
                    {
                        UserChanges.Avatar = frm_Login.User.Avatar;
                    }
                    try
                    {
                        var update = Builders<Models.User>.Update
                            .Set("Name", tb_Name.Text)
                            .Set("Date", tb_Date.Text)
                            .Set("Biography", rtb_Bio.Text)
                            .Set("Avatar", UserChanges.Avatar);
                        var query = frm_Login.Users.UpdateOne(user => user._id == frm_Login.User._id, update);
                        MessageBox.Show("Your changes is successfully saved");
                        frm_Login.User = UserChanges;
                        FormLoad();
                        frm_Dashboard frm = Application.OpenForms.OfType<frm_Dashboard>().FirstOrDefault();
                        frm.ChangeUserAvatar();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message);
                    }
                    
                }
                else
                {
                    MessageBox.Show("No changes made");
                }
            }
            else
            {
                MessageBox.Show("Name cannot be null");
            }
        }

        private void btn_DeleteUser_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Are you sure you want to Delete this account", "Delete Account ?", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                
                try
                {
                    frm_Login.Users.DeleteOne(user => user._id == frm_Login.User._id);
                    frm_Login.User = null;
                    Thread a = new Thread(() => new frm_Login().ShowDialog());
                    a.SetApartmentState(ApartmentState.STA);
                    a.Start();
                    this.ParentForm.Close();
                }
                catch(Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
            
        }
        private void FormLoad() {
            OriginalName = frm_Login.User.Name;
            OriginalDate = frm_Login.User.Date;
            OriginalBiography = frm_Login.User.Biography; 
            OriginalAvatar = frm_Login.User.Avatar;
            if (frm_Login.User.Avatar != null)
            {
                var img = Image.FromStream(new MemoryStream(Convert.FromBase64String(frm_Login.User.Avatar)));
                pb_Avatar.Image = null;
                pb_Avatar.Image = img;
            }
        }
        private void frm_Profile_Load(object sender, EventArgs e)
        {
            tb_Name.Text = OriginalName;
            tb_Date.Text = OriginalDate;
            rtb_Bio.Text = OriginalBiography;
        }

        private void btn_Close_Click(object sender, EventArgs e)
        {
            this.Close();

        }
        private string imagePath = null;
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
    }
}

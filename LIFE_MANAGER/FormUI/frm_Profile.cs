using MongoDB.Driver;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
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
        public frm_Profile()
        {
            InitializeComponent();
            FormLoad();
        }

        private void btn_SaveChanges_Click(object sender, EventArgs e)
        {
            if (tb_Name.Text != "")
            {
                if (tb_Name.Text != OriginalName || tb_Date.Text != OriginalDate
                    || rtb_Bio.Text != OriginalBiography)
                {
                    Models.User UserChanges = new Models.User()
                    {
                        //_id = frm_Login.User._id,
                        Name = tb_Name.Text,
                        Date = tb_Date.Text,
                        Biography = rtb_Bio.Text,
                        updatedAt = DateTime.Now,
                    };
                    try
                    {
                        var update = Builders<Models.User>.Update
                            .Set("Name", tb_Name.Text)
                            .Set("Date", tb_Date.Text)
                            .Set("Biography", rtb_Bio.Text);
                        var query = frm_Login.Users.UpdateOne(user => user._id == frm_Login.User._id, update);
                        MessageBox.Show("Your changes is successfully saved");
                        frm_Login.User = UserChanges;
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
        }
        private void frm_Profile_Load(object sender, EventArgs e)
        {
            tb_Name.Text = OriginalName;
            tb_Date.Text = OriginalDate;
            rtb_Bio.Text = OriginalBiography;
        }
    }
}

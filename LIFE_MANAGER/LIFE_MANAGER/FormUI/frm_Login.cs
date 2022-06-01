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
using MongoDB.Driver;
namespace LIFE_MANAGER.FormUI
{
    public partial class frm_Login : Form
    {
        static readonly String connectionString = "mongodb+srv://tranquocc123:Quoccuong1@maincluster.fmpjzgz.mongodb.net/?retryWrites=true&w=majority";
        static MongoClient mongoClient = new MongoClient(connectionString);
        static IMongoDatabase db = mongoClient.GetDatabase("DiaryApp");
        static IMongoCollection<Models.User> Users = db.GetCollection<Models.User>("Users");
        public frm_Login()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Models.User user = new Models.User()
            {
                Username = tb_User.Text,
                Password = tb_Pass.Text,
            };

            OpenNewForm();
        }
        private void OpenNewForm()
        {
            Thread a = new Thread(() => new frm_Dashboard().ShowDialog());
            a.SetApartmentState(ApartmentState.STA);
            a.Start();
            this.Close();
        }
        private void CreateNewUser(Models.User user)
        {
            user.hashPassword();
            try
            {
                var options = new CreateIndexOptions { Unique = true };
#pragma warning disable CS0618 // Type or member is obsolete
                Users.Indexes.CreateOne("{ Username : 1 }", options);
#pragma warning restore CS0618 // Type or member is obsolete

                Users.InsertOne(user);
                MessageBox.Show("New user added");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btn_SignUp_Click(object sender, EventArgs e)
        {
            if (tb_User.Text == "" && tb_Pass.Text == "")
            {
                MessageBox.Show("Please Enter your username and password");
                return;
            }
            Models.User user = new Models.User()
            {
                Username = tb_User.Text,
                Password = tb_Pass.Text,
            };
            CreateNewUser(user);
        }
    }
}

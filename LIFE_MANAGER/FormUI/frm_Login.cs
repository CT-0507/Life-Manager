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
    public partial class frm_Login : Form
    {
        public frm_Login()
        {
            InitializeComponent();
        }

     
      

        private void roundedButton1_Click(object sender, EventArgs e)
        {
            Thread a = new Thread(() => new frm_Dashboard().ShowDialog());
            a.SetApartmentState(ApartmentState.STA);
            a.Start();
            this.Close();
        }

        private void label1_Click(object sender, EventArgs e)
        {
            Thread a = new Thread(() => new frm_Register().ShowDialog());
            a.SetApartmentState(ApartmentState.STA);
            a.Start();
            this.Close();
        }
    }
}

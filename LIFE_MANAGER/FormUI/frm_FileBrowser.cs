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
    public partial class frm_FileBrowser : Form
    {
        List<string> listFiles = new List<string>();

        public frm_FileBrowser(string path)
        {
            InitializeComponent();
            string[] fileEntries = Directory.GetFiles(path);
            string[] files = new string[fileEntries.Length];
            for (int i = 0; i < fileEntries.Length; i++)
            {
                string[] separatingStrings = {"..\\"};
                files[i] = fileEntries[i].Split(separatingStrings, StringSplitOptions.RemoveEmptyEntries)[0];
            }
            //string[] fileName = Directory.GetFiles(path).;
            listFiles.Clear();
            foreach (string file in files)
            {
                lv_Files.Items.Add(file);
            }
            
        }

        private void btn_Open_Click(object sender, EventArgs e)
        {
            frm_Dashboardnew.Player.controls.pause();
            //frm_Dashboardnew.Player = null;
            //frm_Dashboardnew.Player = new WMPLib.WindowsMediaPlayer();
            string url = lv_Files.SelectedItems[0].Text;
            frm_Dashboardnew.Player.URL = Path.Combine(Path.GetDirectoryName(Application.ExecutablePath), url);
            if (frm_Login.Setting.isBackgroundMusicVolume)
            {
                frm_Dashboardnew.Player.controls.play();
            }
            else
            {
                frm_Dashboardnew.Player.controls.pause();
            }
            this.Close();
            
        }
    }
}

﻿
namespace LIFE_MANAGER.FormUI
{
    partial class frm_Dashboardnew
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm_Dashboardnew));
            this.panelMenu = new System.Windows.Forms.Panel();
            this.btn_logout = new FontAwesome.Sharp.IconButton();
            this.btn_setting = new FontAwesome.Sharp.IconButton();
            this.btn_chart = new FontAwesome.Sharp.IconButton();
            this.btn_Diary = new FontAwesome.Sharp.IconButton();
            this.btn_profile = new FontAwesome.Sharp.IconButton();
            this.panelLogo = new System.Windows.Forms.Panel();
            this.btnHome = new System.Windows.Forms.PictureBox();
            this.panelTitleBar = new System.Windows.Forms.Panel();
            this.btn_Quit = new System.Windows.Forms.Button();
            this.btn_Maximize = new System.Windows.Forms.Button();
            this.bnt_Minimize = new System.Windows.Forms.Button();
            this.lblTitleChildForm = new System.Windows.Forms.Label();
            this.iconcurrentchildform = new FontAwesome.Sharp.IconPictureBox();
            this.panelsadown = new System.Windows.Forms.Panel();
            this.panelDeskTop = new System.Windows.Forms.Panel();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.panelMenu.SuspendLayout();
            this.panelLogo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnHome)).BeginInit();
            this.panelTitleBar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.iconcurrentchildform)).BeginInit();
            this.panelDeskTop.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panelMenu
            // 
            this.panelMenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(64)))));
            this.panelMenu.Controls.Add(this.btn_logout);
            this.panelMenu.Controls.Add(this.btn_setting);
            this.panelMenu.Controls.Add(this.btn_chart);
            this.panelMenu.Controls.Add(this.btn_Diary);
            this.panelMenu.Controls.Add(this.btn_profile);
            this.panelMenu.Controls.Add(this.panelLogo);
            this.panelMenu.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelMenu.Location = new System.Drawing.Point(0, 0);
            this.panelMenu.Name = "panelMenu";
            this.panelMenu.Size = new System.Drawing.Size(220, 705);
            this.panelMenu.TabIndex = 0;
            // 
            // btn_logout
            // 
            this.btn_logout.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.btn_logout.FlatAppearance.BorderSize = 0;
            this.btn_logout.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_logout.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_logout.ForeColor = System.Drawing.Color.Gainsboro;
            this.btn_logout.IconChar = FontAwesome.Sharp.IconChar.SignOutAlt;
            this.btn_logout.IconColor = System.Drawing.Color.Gainsboro;
            this.btn_logout.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btn_logout.IconSize = 40;
            this.btn_logout.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_logout.Location = new System.Drawing.Point(0, 635);
            this.btn_logout.Name = "btn_logout";
            this.btn_logout.Padding = new System.Windows.Forms.Padding(15, 0, 15, 0);
            this.btn_logout.Size = new System.Drawing.Size(220, 70);
            this.btn_logout.TabIndex = 4;
            this.btn_logout.Text = "Logout";
            this.btn_logout.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_logout.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btn_logout.UseVisualStyleBackColor = true;
            this.btn_logout.Click += new System.EventHandler(this.btn_logout_Click);
            // 
            // btn_setting
            // 
            this.btn_setting.Dock = System.Windows.Forms.DockStyle.Top;
            this.btn_setting.FlatAppearance.BorderSize = 0;
            this.btn_setting.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_setting.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_setting.ForeColor = System.Drawing.Color.Gainsboro;
            this.btn_setting.IconChar = FontAwesome.Sharp.IconChar.Wrench;
            this.btn_setting.IconColor = System.Drawing.Color.Gainsboro;
            this.btn_setting.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btn_setting.IconSize = 40;
            this.btn_setting.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_setting.Location = new System.Drawing.Point(0, 350);
            this.btn_setting.Name = "btn_setting";
            this.btn_setting.Padding = new System.Windows.Forms.Padding(15, 0, 15, 0);
            this.btn_setting.Size = new System.Drawing.Size(220, 70);
            this.btn_setting.TabIndex = 3;
            this.btn_setting.Text = "Setting";
            this.btn_setting.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_setting.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btn_setting.UseVisualStyleBackColor = true;
            this.btn_setting.Click += new System.EventHandler(this.btn_setting_Click);
            // 
            // btn_chart
            // 
            this.btn_chart.Dock = System.Windows.Forms.DockStyle.Top;
            this.btn_chart.FlatAppearance.BorderSize = 0;
            this.btn_chart.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_chart.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_chart.ForeColor = System.Drawing.Color.Gainsboro;
            this.btn_chart.IconChar = FontAwesome.Sharp.IconChar.ChartLine;
            this.btn_chart.IconColor = System.Drawing.Color.Gainsboro;
            this.btn_chart.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btn_chart.IconSize = 40;
            this.btn_chart.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_chart.Location = new System.Drawing.Point(0, 280);
            this.btn_chart.Name = "btn_chart";
            this.btn_chart.Padding = new System.Windows.Forms.Padding(15, 0, 15, 0);
            this.btn_chart.Size = new System.Drawing.Size(220, 70);
            this.btn_chart.TabIndex = 2;
            this.btn_chart.Text = "Chart";
            this.btn_chart.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_chart.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btn_chart.UseVisualStyleBackColor = true;
            this.btn_chart.Click += new System.EventHandler(this.btn_chart_Click);
            // 
            // btn_Diary
            // 
            this.btn_Diary.Dock = System.Windows.Forms.DockStyle.Top;
            this.btn_Diary.FlatAppearance.BorderSize = 0;
            this.btn_Diary.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Diary.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Diary.ForeColor = System.Drawing.Color.Gainsboro;
            this.btn_Diary.IconChar = FontAwesome.Sharp.IconChar.Book;
            this.btn_Diary.IconColor = System.Drawing.Color.Gainsboro;
            this.btn_Diary.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btn_Diary.IconSize = 40;
            this.btn_Diary.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_Diary.Location = new System.Drawing.Point(0, 210);
            this.btn_Diary.Name = "btn_Diary";
            this.btn_Diary.Padding = new System.Windows.Forms.Padding(15, 0, 15, 0);
            this.btn_Diary.Size = new System.Drawing.Size(220, 70);
            this.btn_Diary.TabIndex = 1;
            this.btn_Diary.Text = "Diary";
            this.btn_Diary.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_Diary.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btn_Diary.UseVisualStyleBackColor = true;
            this.btn_Diary.Click += new System.EventHandler(this.btn_Diary_Click);
            // 
            // btn_profile
            // 
            this.btn_profile.Dock = System.Windows.Forms.DockStyle.Top;
            this.btn_profile.FlatAppearance.BorderSize = 0;
            this.btn_profile.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_profile.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_profile.ForeColor = System.Drawing.Color.Gainsboro;
            this.btn_profile.IconChar = FontAwesome.Sharp.IconChar.IdCard;
            this.btn_profile.IconColor = System.Drawing.Color.Gainsboro;
            this.btn_profile.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btn_profile.IconSize = 40;
            this.btn_profile.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_profile.Location = new System.Drawing.Point(0, 140);
            this.btn_profile.Name = "btn_profile";
            this.btn_profile.Padding = new System.Windows.Forms.Padding(15, 0, 15, 0);
            this.btn_profile.Size = new System.Drawing.Size(220, 70);
            this.btn_profile.TabIndex = 0;
            this.btn_profile.Text = "Profile";
            this.btn_profile.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_profile.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btn_profile.UseVisualStyleBackColor = true;
            this.btn_profile.Click += new System.EventHandler(this.btn_profile_Click);
            // 
            // panelLogo
            // 
            this.panelLogo.Controls.Add(this.btnHome);
            this.panelLogo.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelLogo.Location = new System.Drawing.Point(0, 0);
            this.panelLogo.Name = "panelLogo";
            this.panelLogo.Size = new System.Drawing.Size(220, 140);
            this.panelLogo.TabIndex = 0;
            // 
            // btnHome
            // 
            this.btnHome.Image = global::LIFE_MANAGER.Properties.Resources.Logo;
            this.btnHome.Location = new System.Drawing.Point(12, 12);
            this.btnHome.Name = "btnHome";
            this.btnHome.Size = new System.Drawing.Size(194, 113);
            this.btnHome.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.btnHome.TabIndex = 5;
            this.btnHome.TabStop = false;
            this.btnHome.Click += new System.EventHandler(this.btnHome_Click_1);
            // 
            // panelTitleBar
            // 
            this.panelTitleBar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(39)))), ((int)(((byte)(58)))));
            this.panelTitleBar.Controls.Add(this.btn_Quit);
            this.panelTitleBar.Controls.Add(this.btn_Maximize);
            this.panelTitleBar.Controls.Add(this.bnt_Minimize);
            this.panelTitleBar.Controls.Add(this.lblTitleChildForm);
            this.panelTitleBar.Controls.Add(this.iconcurrentchildform);
            this.panelTitleBar.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelTitleBar.Location = new System.Drawing.Point(220, 0);
            this.panelTitleBar.Name = "panelTitleBar";
            this.panelTitleBar.Size = new System.Drawing.Size(1169, 96);
            this.panelTitleBar.TabIndex = 1;
            this.panelTitleBar.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panelTitleBar_MouseDown_1);
            // 
            // btn_Quit
            // 
            this.btn_Quit.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_Quit.AutoSize = true;
            this.btn_Quit.FlatAppearance.BorderSize = 0;
            this.btn_Quit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Quit.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Quit.Location = new System.Drawing.Point(1127, 12);
            this.btn_Quit.Name = "btn_Quit";
            this.btn_Quit.Size = new System.Drawing.Size(30, 30);
            this.btn_Quit.TabIndex = 12;
            this.btn_Quit.Text = "O";
            this.btn_Quit.UseVisualStyleBackColor = true;
            this.btn_Quit.Click += new System.EventHandler(this.btn_Quit_Click);
            // 
            // btn_Maximize
            // 
            this.btn_Maximize.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_Maximize.AutoSize = true;
            this.btn_Maximize.FlatAppearance.BorderSize = 0;
            this.btn_Maximize.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Maximize.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Maximize.Location = new System.Drawing.Point(1081, 12);
            this.btn_Maximize.Name = "btn_Maximize";
            this.btn_Maximize.Size = new System.Drawing.Size(30, 30);
            this.btn_Maximize.TabIndex = 11;
            this.btn_Maximize.Text = "O";
            this.btn_Maximize.UseVisualStyleBackColor = true;
            this.btn_Maximize.Click += new System.EventHandler(this.btn_Maximize_Click);
            // 
            // bnt_Minimize
            // 
            this.bnt_Minimize.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.bnt_Minimize.AutoSize = true;
            this.bnt_Minimize.FlatAppearance.BorderSize = 0;
            this.bnt_Minimize.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bnt_Minimize.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bnt_Minimize.Location = new System.Drawing.Point(1033, 12);
            this.bnt_Minimize.Name = "bnt_Minimize";
            this.bnt_Minimize.Size = new System.Drawing.Size(30, 30);
            this.bnt_Minimize.TabIndex = 10;
            this.bnt_Minimize.Text = "O";
            this.bnt_Minimize.UseVisualStyleBackColor = true;
            this.bnt_Minimize.Click += new System.EventHandler(this.bnt_Minimize_Click);
            // 
            // lblTitleChildForm
            // 
            this.lblTitleChildForm.AutoSize = true;
            this.lblTitleChildForm.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitleChildForm.ForeColor = System.Drawing.SystemColors.AppWorkspace;
            this.lblTitleChildForm.Location = new System.Drawing.Point(76, 57);
            this.lblTitleChildForm.Name = "lblTitleChildForm";
            this.lblTitleChildForm.Size = new System.Drawing.Size(62, 24);
            this.lblTitleChildForm.TabIndex = 3;
            this.lblTitleChildForm.Text = "Home";
            // 
            // iconcurrentchildform
            // 
            this.iconcurrentchildform.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(39)))), ((int)(((byte)(58)))));
            this.iconcurrentchildform.ForeColor = System.Drawing.Color.MediumOrchid;
            this.iconcurrentchildform.IconChar = FontAwesome.Sharp.IconChar.Home;
            this.iconcurrentchildform.IconColor = System.Drawing.Color.MediumOrchid;
            this.iconcurrentchildform.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconcurrentchildform.IconSize = 31;
            this.iconcurrentchildform.Location = new System.Drawing.Point(34, 52);
            this.iconcurrentchildform.Name = "iconcurrentchildform";
            this.iconcurrentchildform.Size = new System.Drawing.Size(38, 31);
            this.iconcurrentchildform.TabIndex = 2;
            this.iconcurrentchildform.TabStop = false;
            // 
            // panelsadown
            // 
            this.panelsadown.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(64)))));
            this.panelsadown.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelsadown.Location = new System.Drawing.Point(220, 96);
            this.panelsadown.Name = "panelsadown";
            this.panelsadown.Size = new System.Drawing.Size(1169, 10);
            this.panelsadown.TabIndex = 2;
            // 
            // panelDeskTop
            // 
            this.panelDeskTop.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panelDeskTop.AutoSize = true;
            this.panelDeskTop.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(54)))), ((int)(((byte)(72)))));
            this.panelDeskTop.Controls.Add(this.pictureBox2);
            this.panelDeskTop.Controls.Add(this.pictureBox1);
            this.panelDeskTop.Controls.Add(this.label1);
            this.panelDeskTop.Location = new System.Drawing.Point(228, 112);
            this.panelDeskTop.Name = "panelDeskTop";
            this.panelDeskTop.Size = new System.Drawing.Size(1149, 547);
            this.panelDeskTop.TabIndex = 6;
            this.panelDeskTop.Paint += new System.Windows.Forms.PaintEventHandler(this.panelDeskTop_Paint);
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(647, 106);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(379, 408);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 5;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(17, 106);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(591, 408);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 4;
            this.pictureBox1.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.label1.Location = new System.Drawing.Point(382, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(279, 38);
            this.label1.TabIndex = 3;
            this.label1.Text = "Application Diary";
            // 
            // frm_Dashboardnew
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(1389, 705);
            this.Controls.Add(this.panelDeskTop);
            this.Controls.Add(this.panelsadown);
            this.Controls.Add(this.panelTitleBar);
            this.Controls.Add(this.panelMenu);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frm_Dashboardnew";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frm_Dashboardnew";
            this.WindowState = System.Windows.Forms.FormWindowState.Minimized;
            this.panelMenu.ResumeLayout(false);
            this.panelLogo.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.btnHome)).EndInit();
            this.panelTitleBar.ResumeLayout(false);
            this.panelTitleBar.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.iconcurrentchildform)).EndInit();
            this.panelDeskTop.ResumeLayout(false);
            this.panelDeskTop.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panelMenu;
        private FontAwesome.Sharp.IconButton btn_logout;
        private FontAwesome.Sharp.IconButton btn_setting;
        private FontAwesome.Sharp.IconButton btn_chart;
        private FontAwesome.Sharp.IconButton btn_Diary;
        private FontAwesome.Sharp.IconButton btn_profile;
        private System.Windows.Forms.Panel panelLogo;
        private System.Windows.Forms.PictureBox btnHome;
        private System.Windows.Forms.Panel panelTitleBar;
        private FontAwesome.Sharp.IconPictureBox iconcurrentchildform;
        private System.Windows.Forms.Label lblTitleChildForm;
        private System.Windows.Forms.Panel panelsadown;
        private System.Windows.Forms.Panel panelDeskTop;
        private System.Windows.Forms.Button btn_Quit;
        private System.Windows.Forms.Button btn_Maximize;
        private System.Windows.Forms.Button bnt_Minimize;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
    }
}
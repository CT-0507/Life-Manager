﻿
namespace LIFE_MANAGER.FormUI
{
    partial class frm_Setting
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm_Setting));
            this.btn_Close = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.lb_Notification = new System.Windows.Forms.Label();
            this.lb_StartWithWindows = new System.Windows.Forms.Label();
            this.lb_Volume = new System.Windows.Forms.Label();
            this.tgb_Volume = new LIFE_MANAGER.Custom_Control.RJToggleButton();
            this.tgb_StartWithWindows = new LIFE_MANAGER.Custom_Control.RJToggleButton();
            this.tgb_Notification = new LIFE_MANAGER.Custom_Control.RJToggleButton();
            this.rjToggleButton1 = new LIFE_MANAGER.Custom_Control.RJToggleButton();
            this.btn_BackgroundUpload = new LIFE_MANAGER.Custom_Control.RoundedButton();
            this.btn_ViewBackground = new LIFE_MANAGER.Custom_Control.RoundedButton();
            this.SuspendLayout();
            // 
            // btn_Close
            // 
            this.btn_Close.FlatAppearance.BorderSize = 0;
            this.btn_Close.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Close.Image = ((System.Drawing.Image)(resources.GetObject("btn_Close.Image")));
            this.btn_Close.Location = new System.Drawing.Point(980, 9);
            this.btn_Close.Name = "btn_Close";
            this.btn_Close.Size = new System.Drawing.Size(75, 23);
            this.btn_Close.TabIndex = 5;
            this.btn_Close.UseVisualStyleBackColor = true;
            this.btn_Close.Click += new System.EventHandler(this.btn_Close_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(481, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(125, 38);
            this.label1.TabIndex = 7;
            this.label1.Text = "Setting";
            // 
            // lb_Notification
            // 
            this.lb_Notification.AutoSize = true;
            this.lb_Notification.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_Notification.Location = new System.Drawing.Point(278, 141);
            this.lb_Notification.Name = "lb_Notification";
            this.lb_Notification.Size = new System.Drawing.Size(150, 31);
            this.lb_Notification.TabIndex = 11;
            this.lb_Notification.Text = "Notification";
            // 
            // lb_StartWithWindows
            // 
            this.lb_StartWithWindows.AutoSize = true;
            this.lb_StartWithWindows.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_StartWithWindows.Location = new System.Drawing.Point(278, 203);
            this.lb_StartWithWindows.Name = "lb_StartWithWindows";
            this.lb_StartWithWindows.Size = new System.Drawing.Size(240, 31);
            this.lb_StartWithWindows.TabIndex = 14;
            this.lb_StartWithWindows.Text = "Start with windows";
            // 
            // lb_Volume
            // 
            this.lb_Volume.AutoSize = true;
            this.lb_Volume.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_Volume.Location = new System.Drawing.Point(278, 257);
            this.lb_Volume.Name = "lb_Volume";
            this.lb_Volume.Size = new System.Drawing.Size(105, 31);
            this.lb_Volume.TabIndex = 15;
            this.lb_Volume.Text = "Volume";
            // 
            // tgb_Volume
            // 
            this.tgb_Volume.AutoSize = true;
            this.tgb_Volume.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tgb_Volume.Location = new System.Drawing.Point(155, 253);
            this.tgb_Volume.MinimumSize = new System.Drawing.Size(90, 40);
            this.tgb_Volume.Name = "tgb_Volume";
            this.tgb_Volume.OffBackColor = System.Drawing.Color.Gray;
            this.tgb_Volume.OffToggleColor = System.Drawing.Color.Gainsboro;
            this.tgb_Volume.OnBackColor = System.Drawing.Color.MediumSlateBlue;
            this.tgb_Volume.OnToggleColor = System.Drawing.Color.WhiteSmoke;
            this.tgb_Volume.Size = new System.Drawing.Size(90, 40);
            this.tgb_Volume.TabIndex = 13;
            this.tgb_Volume.UseVisualStyleBackColor = true;
            this.tgb_Volume.CheckedChanged += new System.EventHandler(this.tgb_Volume_CheckedChanged);
            // 
            // tgb_StartWithWindows
            // 
            this.tgb_StartWithWindows.AutoSize = true;
            this.tgb_StartWithWindows.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tgb_StartWithWindows.Location = new System.Drawing.Point(155, 194);
            this.tgb_StartWithWindows.MinimumSize = new System.Drawing.Size(90, 40);
            this.tgb_StartWithWindows.Name = "tgb_StartWithWindows";
            this.tgb_StartWithWindows.OffBackColor = System.Drawing.Color.Gray;
            this.tgb_StartWithWindows.OffToggleColor = System.Drawing.Color.Gainsboro;
            this.tgb_StartWithWindows.OnBackColor = System.Drawing.Color.MediumSlateBlue;
            this.tgb_StartWithWindows.OnToggleColor = System.Drawing.Color.WhiteSmoke;
            this.tgb_StartWithWindows.Size = new System.Drawing.Size(90, 40);
            this.tgb_StartWithWindows.TabIndex = 12;
            this.tgb_StartWithWindows.UseVisualStyleBackColor = true;
            this.tgb_StartWithWindows.CheckedChanged += new System.EventHandler(this.tgb_StartWithWindows_CheckedChanged);
            // 
            // tgb_Notification
            // 
            this.tgb_Notification.AutoSize = true;
            this.tgb_Notification.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tgb_Notification.Location = new System.Drawing.Point(155, 137);
            this.tgb_Notification.MinimumSize = new System.Drawing.Size(90, 40);
            this.tgb_Notification.Name = "tgb_Notification";
            this.tgb_Notification.OffBackColor = System.Drawing.Color.Gray;
            this.tgb_Notification.OffToggleColor = System.Drawing.Color.Gainsboro;
            this.tgb_Notification.OnBackColor = System.Drawing.Color.MediumSlateBlue;
            this.tgb_Notification.OnToggleColor = System.Drawing.Color.WhiteSmoke;
            this.tgb_Notification.Size = new System.Drawing.Size(90, 40);
            this.tgb_Notification.TabIndex = 9;
            this.tgb_Notification.UseVisualStyleBackColor = true;
            this.tgb_Notification.CheckedChanged += new System.EventHandler(this.tgb_Notification_CheckedChanged);
            // 
            // rjToggleButton1
            // 
            this.rjToggleButton1.AutoSize = true;
            this.rjToggleButton1.Location = new System.Drawing.Point(-19, -19);
            this.rjToggleButton1.MinimumSize = new System.Drawing.Size(45, 22);
            this.rjToggleButton1.Name = "rjToggleButton1";
            this.rjToggleButton1.OffBackColor = System.Drawing.Color.Gray;
            this.rjToggleButton1.OffToggleColor = System.Drawing.Color.Gainsboro;
            this.rjToggleButton1.OnBackColor = System.Drawing.Color.MediumSlateBlue;
            this.rjToggleButton1.OnToggleColor = System.Drawing.Color.WhiteSmoke;
            this.rjToggleButton1.Size = new System.Drawing.Size(45, 22);
            this.rjToggleButton1.TabIndex = 8;
            this.rjToggleButton1.UseVisualStyleBackColor = true;
            // 
            // btn_BackgroundUpload
            // 
            this.btn_BackgroundUpload.BackColor = System.Drawing.Color.DimGray;
            this.btn_BackgroundUpload.BackgroundColor = System.Drawing.Color.DimGray;
            this.btn_BackgroundUpload.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.btn_BackgroundUpload.BorderRadius = 40;
            this.btn_BackgroundUpload.BorderSize = 0;
            this.btn_BackgroundUpload.FlatAppearance.BorderSize = 0;
            this.btn_BackgroundUpload.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_BackgroundUpload.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_BackgroundUpload.ForeColor = System.Drawing.Color.White;
            this.btn_BackgroundUpload.Location = new System.Drawing.Point(155, 323);
            this.btn_BackgroundUpload.Name = "btn_BackgroundUpload";
            this.btn_BackgroundUpload.Size = new System.Drawing.Size(284, 46);
            this.btn_BackgroundUpload.TabIndex = 16;
            this.btn_BackgroundUpload.Text = "Upload Background Image";
            this.btn_BackgroundUpload.TextColor = System.Drawing.Color.White;
            this.btn_BackgroundUpload.UseVisualStyleBackColor = false;
            this.btn_BackgroundUpload.Click += new System.EventHandler(this.btn_BackgroundUpload_Click);
            // 
            // btn_ViewBackground
            // 
            this.btn_ViewBackground.BackColor = System.Drawing.Color.DimGray;
            this.btn_ViewBackground.BackgroundColor = System.Drawing.Color.DimGray;
            this.btn_ViewBackground.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.btn_ViewBackground.BorderRadius = 40;
            this.btn_ViewBackground.BorderSize = 0;
            this.btn_ViewBackground.FlatAppearance.BorderSize = 0;
            this.btn_ViewBackground.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_ViewBackground.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_ViewBackground.ForeColor = System.Drawing.Color.White;
            this.btn_ViewBackground.Location = new System.Drawing.Point(755, 418);
            this.btn_ViewBackground.Name = "btn_ViewBackground";
            this.btn_ViewBackground.Size = new System.Drawing.Size(284, 46);
            this.btn_ViewBackground.TabIndex = 17;
            this.btn_ViewBackground.Text = "View Background";
            this.btn_ViewBackground.TextColor = System.Drawing.Color.White;
            this.btn_ViewBackground.UseVisualStyleBackColor = false;
            this.btn_ViewBackground.Click += new System.EventHandler(this.btn_ViewBackground_Click);
            // 
            // frm_Setting
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1067, 500);
            this.Controls.Add(this.btn_ViewBackground);
            this.Controls.Add(this.btn_BackgroundUpload);
            this.Controls.Add(this.lb_Volume);
            this.Controls.Add(this.lb_StartWithWindows);
            this.Controls.Add(this.tgb_Volume);
            this.Controls.Add(this.tgb_StartWithWindows);
            this.Controls.Add(this.lb_Notification);
            this.Controls.Add(this.tgb_Notification);
            this.Controls.Add(this.rjToggleButton1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btn_Close);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frm_Setting";
            this.Text = "Setting";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_Close;
        private System.Windows.Forms.Label label1;
        private Custom_Control.RJToggleButton rjToggleButton1;
        private Custom_Control.RJToggleButton tgb_Notification;
        private System.Windows.Forms.Label lb_Notification;
        private Custom_Control.RJToggleButton tgb_StartWithWindows;
        private Custom_Control.RJToggleButton tgb_Volume;
        private System.Windows.Forms.Label lb_StartWithWindows;
        private System.Windows.Forms.Label lb_Volume;
        private Custom_Control.RoundedButton btn_BackgroundUpload;
        private Custom_Control.RoundedButton btn_ViewBackground;
    }
}
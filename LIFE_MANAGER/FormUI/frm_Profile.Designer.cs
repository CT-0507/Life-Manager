
namespace LIFE_MANAGER.FormUI
{
    partial class frm_Profile
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm_Profile));
            this.pb_Avatar = new System.Windows.Forms.PictureBox();
            this.lb_Name = new System.Windows.Forms.Label();
            this.lb_Bio = new System.Windows.Forms.Label();
            this.lb_Date = new System.Windows.Forms.Label();
            this.lb_Id = new System.Windows.Forms.Label();
            this.tb_Name = new System.Windows.Forms.TextBox();
            this.tb_Id = new System.Windows.Forms.TextBox();
            this.tb_Date = new System.Windows.Forms.TextBox();
            this.rtb_Bio = new System.Windows.Forms.RichTextBox();
            this.btn_Close = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.btn_AvatarUpload = new LIFE_MANAGER.Custom_Control.RoundedButton();
            this.btn_DeleteUser = new LIFE_MANAGER.Custom_Control.RoundedButton();
            this.btn_SaveChanges = new LIFE_MANAGER.Custom_Control.RoundedButton();
            ((System.ComponentModel.ISupportInitialize)(this.pb_Avatar)).BeginInit();
            this.SuspendLayout();
            // 
            // pb_Avatar
            // 
            this.pb_Avatar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pb_Avatar.Image = ((System.Drawing.Image)(resources.GetObject("pb_Avatar.Image")));
            this.pb_Avatar.Location = new System.Drawing.Point(12, 82);
            this.pb_Avatar.Name = "pb_Avatar";
            this.pb_Avatar.Size = new System.Drawing.Size(322, 462);
            this.pb_Avatar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pb_Avatar.TabIndex = 0;
            this.pb_Avatar.TabStop = false;
            // 
            // lb_Name
            // 
            this.lb_Name.AutoSize = true;
            this.lb_Name.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_Name.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lb_Name.Location = new System.Drawing.Point(512, 109);
            this.lb_Name.Name = "lb_Name";
            this.lb_Name.Size = new System.Drawing.Size(85, 25);
            this.lb_Name.TabIndex = 2;
            this.lb_Name.Text = "Họ tên : ";
            // 
            // lb_Bio
            // 
            this.lb_Bio.AutoSize = true;
            this.lb_Bio.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_Bio.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lb_Bio.Location = new System.Drawing.Point(512, 252);
            this.lb_Bio.Name = "lb_Bio";
            this.lb_Bio.Size = new System.Drawing.Size(93, 25);
            this.lb_Bio.TabIndex = 3;
            this.lb_Bio.Text = "Tiểu sử : ";
            // 
            // lb_Date
            // 
            this.lb_Date.AutoSize = true;
            this.lb_Date.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_Date.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lb_Date.Location = new System.Drawing.Point(512, 202);
            this.lb_Date.Name = "lb_Date";
            this.lb_Date.Size = new System.Drawing.Size(115, 25);
            this.lb_Date.TabIndex = 4;
            this.lb_Date.Text = "Ngày sinh : ";
            // 
            // lb_Id
            // 
            this.lb_Id.AutoSize = true;
            this.lb_Id.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_Id.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lb_Id.Location = new System.Drawing.Point(512, 157);
            this.lb_Id.Name = "lb_Id";
            this.lb_Id.Size = new System.Drawing.Size(47, 25);
            this.lb_Id.TabIndex = 5;
            this.lb_Id.Text = "ID : ";
            // 
            // tb_Name
            // 
            this.tb_Name.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_Name.Location = new System.Drawing.Point(638, 109);
            this.tb_Name.Name = "tb_Name";
            this.tb_Name.Size = new System.Drawing.Size(258, 30);
            this.tb_Name.TabIndex = 6;
            // 
            // tb_Id
            // 
            this.tb_Id.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_Id.Location = new System.Drawing.Point(638, 154);
            this.tb_Id.Name = "tb_Id";
            this.tb_Id.ReadOnly = true;
            this.tb_Id.Size = new System.Drawing.Size(258, 30);
            this.tb_Id.TabIndex = 7;
            // 
            // tb_Date
            // 
            this.tb_Date.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_Date.Location = new System.Drawing.Point(638, 202);
            this.tb_Date.Name = "tb_Date";
            this.tb_Date.Size = new System.Drawing.Size(258, 30);
            this.tb_Date.TabIndex = 8;
            // 
            // rtb_Bio
            // 
            this.rtb_Bio.Location = new System.Drawing.Point(638, 252);
            this.rtb_Bio.Name = "rtb_Bio";
            this.rtb_Bio.Size = new System.Drawing.Size(258, 168);
            this.rtb_Bio.TabIndex = 9;
            this.rtb_Bio.Text = "";
            // 
            // btn_Close
            // 
            this.btn_Close.FlatAppearance.BorderSize = 0;
            this.btn_Close.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Close.Image = ((System.Drawing.Image)(resources.GetObject("btn_Close.Image")));
            this.btn_Close.Location = new System.Drawing.Point(985, 9);
            this.btn_Close.Name = "btn_Close";
            this.btn_Close.Size = new System.Drawing.Size(75, 23);
            this.btn_Close.TabIndex = 12;
            this.btn_Close.UseVisualStyleBackColor = true;
            this.btn_Close.Click += new System.EventHandler(this.btn_Close_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(476, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(116, 38);
            this.label1.TabIndex = 13;
            this.label1.Text = "Profile";
            // 
            // btn_AvatarUpload
            // 
            this.btn_AvatarUpload.BackColor = System.Drawing.Color.DimGray;
            this.btn_AvatarUpload.BackgroundColor = System.Drawing.Color.DimGray;
            this.btn_AvatarUpload.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.btn_AvatarUpload.BorderRadius = 40;
            this.btn_AvatarUpload.BorderSize = 0;
            this.btn_AvatarUpload.FlatAppearance.BorderSize = 0;
            this.btn_AvatarUpload.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_AvatarUpload.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_AvatarUpload.ForeColor = System.Drawing.Color.White;
            this.btn_AvatarUpload.Location = new System.Drawing.Point(417, 439);
            this.btn_AvatarUpload.Name = "btn_AvatarUpload";
            this.btn_AvatarUpload.Size = new System.Drawing.Size(165, 46);
            this.btn_AvatarUpload.TabIndex = 14;
            this.btn_AvatarUpload.Text = "Upload Avatar";
            this.btn_AvatarUpload.TextColor = System.Drawing.Color.White;
            this.btn_AvatarUpload.UseVisualStyleBackColor = false;
            this.btn_AvatarUpload.Click += new System.EventHandler(this.btn_AvatarUpload_Click);
            // 
            // btn_DeleteUser
            // 
            this.btn_DeleteUser.BackColor = System.Drawing.Color.DimGray;
            this.btn_DeleteUser.BackgroundColor = System.Drawing.Color.DimGray;
            this.btn_DeleteUser.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.btn_DeleteUser.BorderRadius = 40;
            this.btn_DeleteUser.BorderSize = 0;
            this.btn_DeleteUser.FlatAppearance.BorderSize = 0;
            this.btn_DeleteUser.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_DeleteUser.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_DeleteUser.ForeColor = System.Drawing.Color.White;
            this.btn_DeleteUser.Location = new System.Drawing.Point(588, 439);
            this.btn_DeleteUser.Name = "btn_DeleteUser";
            this.btn_DeleteUser.Size = new System.Drawing.Size(165, 46);
            this.btn_DeleteUser.TabIndex = 11;
            this.btn_DeleteUser.Text = "Delete User";
            this.btn_DeleteUser.TextColor = System.Drawing.Color.White;
            this.btn_DeleteUser.UseVisualStyleBackColor = false;
            this.btn_DeleteUser.Click += new System.EventHandler(this.btn_DeleteUser_Click);
            // 
            // btn_SaveChanges
            // 
            this.btn_SaveChanges.BackColor = System.Drawing.Color.DimGray;
            this.btn_SaveChanges.BackgroundColor = System.Drawing.Color.DimGray;
            this.btn_SaveChanges.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.btn_SaveChanges.BorderRadius = 40;
            this.btn_SaveChanges.BorderSize = 0;
            this.btn_SaveChanges.FlatAppearance.BorderSize = 0;
            this.btn_SaveChanges.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_SaveChanges.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_SaveChanges.ForeColor = System.Drawing.Color.White;
            this.btn_SaveChanges.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_SaveChanges.Location = new System.Drawing.Point(759, 439);
            this.btn_SaveChanges.Name = "btn_SaveChanges";
            this.btn_SaveChanges.Size = new System.Drawing.Size(137, 46);
            this.btn_SaveChanges.TabIndex = 10;
            this.btn_SaveChanges.Text = "Save";
            this.btn_SaveChanges.TextColor = System.Drawing.Color.White;
            this.btn_SaveChanges.UseVisualStyleBackColor = false;
            this.btn_SaveChanges.Click += new System.EventHandler(this.btn_SaveChanges_Click);
            // 
            // frm_Profile
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(39)))), ((int)(((byte)(58)))));
            this.ClientSize = new System.Drawing.Size(1072, 585);
            this.Controls.Add(this.btn_AvatarUpload);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btn_Close);
            this.Controls.Add(this.btn_DeleteUser);
            this.Controls.Add(this.btn_SaveChanges);
            this.Controls.Add(this.rtb_Bio);
            this.Controls.Add(this.tb_Date);
            this.Controls.Add(this.tb_Id);
            this.Controls.Add(this.tb_Name);
            this.Controls.Add(this.lb_Id);
            this.Controls.Add(this.lb_Date);
            this.Controls.Add(this.lb_Bio);
            this.Controls.Add(this.lb_Name);
            this.Controls.Add(this.pb_Avatar);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frm_Profile";
            this.Text = "Profile";
            this.Load += new System.EventHandler(this.frm_Profile_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pb_Avatar)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pb_Avatar;
        private System.Windows.Forms.Label lb_Name;
        private System.Windows.Forms.Label lb_Bio;
        private System.Windows.Forms.Label lb_Date;
        private System.Windows.Forms.Label lb_Id;
        private System.Windows.Forms.TextBox tb_Name;
        private System.Windows.Forms.TextBox tb_Id;
        private System.Windows.Forms.TextBox tb_Date;
        private System.Windows.Forms.RichTextBox rtb_Bio;
        private Custom_Control.RoundedButton btn_SaveChanges;
        private Custom_Control.RoundedButton btn_DeleteUser;
        private System.Windows.Forms.Button btn_Close;
        private System.Windows.Forms.Label label1;
        private Custom_Control.RoundedButton btn_AvatarUpload;
    }
}
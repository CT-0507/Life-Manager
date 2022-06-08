
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.btn_AvatarUpload = new LIFE_MANAGER.Custom_Control.RoundedButton();
            this.btn_DeleteUser = new LIFE_MANAGER.Custom_Control.RoundedButton();
            this.btn_SaveChanges = new LIFE_MANAGER.Custom_Control.RoundedButton();
            this.rtb_Bio = new System.Windows.Forms.RichTextBox();
            this.tb_Date = new System.Windows.Forms.TextBox();
            this.tb_Id = new System.Windows.Forms.TextBox();
            this.tb_Name = new System.Windows.Forms.TextBox();
            this.lb_Id = new System.Windows.Forms.Label();
            this.lb_Date = new System.Windows.Forms.Label();
            this.lb_Bio = new System.Windows.Forms.Label();
            this.lb_Name = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pb_Avatar)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // pb_Avatar
            // 
            this.pb_Avatar.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pb_Avatar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pb_Avatar.Image = ((System.Drawing.Image)(resources.GetObject("pb_Avatar.Image")));
            this.pb_Avatar.Location = new System.Drawing.Point(12, 82);
            this.pb_Avatar.Name = "pb_Avatar";
            this.pb_Avatar.Size = new System.Drawing.Size(614, 462);
            this.pb_Avatar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pb_Avatar.TabIndex = 0;
            this.pb_Avatar.TabStop = false;
            this.pb_Avatar.Click += new System.EventHandler(this.btn_AvatarUpload_Click);
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.AutoSize = true;
            this.panel1.Controls.Add(this.btn_AvatarUpload);
            this.panel1.Controls.Add(this.btn_DeleteUser);
            this.panel1.Controls.Add(this.btn_SaveChanges);
            this.panel1.Controls.Add(this.rtb_Bio);
            this.panel1.Controls.Add(this.tb_Date);
            this.panel1.Controls.Add(this.tb_Id);
            this.panel1.Controls.Add(this.tb_Name);
            this.panel1.Controls.Add(this.lb_Id);
            this.panel1.Controls.Add(this.lb_Date);
            this.panel1.Controls.Add(this.lb_Bio);
            this.panel1.Controls.Add(this.lb_Name);
            this.panel1.Location = new System.Drawing.Point(644, 61);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(548, 470);
            this.panel1.TabIndex = 15;
            // 
            // btn_AvatarUpload
            // 
            this.btn_AvatarUpload.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btn_AvatarUpload.BackColor = System.Drawing.Color.Blue;
            this.btn_AvatarUpload.BackgroundColor = System.Drawing.Color.Blue;
            this.btn_AvatarUpload.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.btn_AvatarUpload.BorderRadius = 40;
            this.btn_AvatarUpload.BorderSize = 0;
            this.btn_AvatarUpload.FlatAppearance.BorderSize = 0;
            this.btn_AvatarUpload.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_AvatarUpload.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_AvatarUpload.ForeColor = System.Drawing.Color.White;
            this.btn_AvatarUpload.Location = new System.Drawing.Point(110, 377);
            this.btn_AvatarUpload.Name = "btn_AvatarUpload";
            this.btn_AvatarUpload.Size = new System.Drawing.Size(121, 46);
            this.btn_AvatarUpload.TabIndex = 36;
            this.btn_AvatarUpload.Text = "Upload Avatar";
            this.btn_AvatarUpload.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btn_AvatarUpload.TextColor = System.Drawing.Color.White;
            this.btn_AvatarUpload.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btn_AvatarUpload.UseVisualStyleBackColor = false;
            this.btn_AvatarUpload.Click += new System.EventHandler(this.btn_AvatarUpload_Click);
            // 
            // btn_DeleteUser
            // 
            this.btn_DeleteUser.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btn_DeleteUser.BackColor = System.Drawing.Color.Blue;
            this.btn_DeleteUser.BackgroundColor = System.Drawing.Color.Blue;
            this.btn_DeleteUser.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.btn_DeleteUser.BorderRadius = 40;
            this.btn_DeleteUser.BorderSize = 0;
            this.btn_DeleteUser.FlatAppearance.BorderSize = 0;
            this.btn_DeleteUser.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_DeleteUser.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_DeleteUser.ForeColor = System.Drawing.Color.White;
            this.btn_DeleteUser.Location = new System.Drawing.Point(237, 377);
            this.btn_DeleteUser.Name = "btn_DeleteUser";
            this.btn_DeleteUser.Size = new System.Drawing.Size(133, 46);
            this.btn_DeleteUser.TabIndex = 35;
            this.btn_DeleteUser.Text = "Delete User";
            this.btn_DeleteUser.TextColor = System.Drawing.Color.White;
            this.btn_DeleteUser.UseVisualStyleBackColor = false;
            this.btn_DeleteUser.Click += new System.EventHandler(this.btn_DeleteUser_Click);
            // 
            // btn_SaveChanges
            // 
            this.btn_SaveChanges.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btn_SaveChanges.BackColor = System.Drawing.Color.Blue;
            this.btn_SaveChanges.BackgroundColor = System.Drawing.Color.Blue;
            this.btn_SaveChanges.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.btn_SaveChanges.BorderRadius = 40;
            this.btn_SaveChanges.BorderSize = 0;
            this.btn_SaveChanges.FlatAppearance.BorderSize = 0;
            this.btn_SaveChanges.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_SaveChanges.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_SaveChanges.ForeColor = System.Drawing.Color.White;
            this.btn_SaveChanges.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_SaveChanges.Location = new System.Drawing.Point(372, 377);
            this.btn_SaveChanges.Name = "btn_SaveChanges";
            this.btn_SaveChanges.Size = new System.Drawing.Size(105, 46);
            this.btn_SaveChanges.TabIndex = 34;
            this.btn_SaveChanges.Text = "Save";
            this.btn_SaveChanges.TextColor = System.Drawing.Color.White;
            this.btn_SaveChanges.UseVisualStyleBackColor = false;
            this.btn_SaveChanges.Click += new System.EventHandler(this.btn_SaveChanges_Click);
            // 
            // rtb_Bio
            // 
            this.rtb_Bio.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.rtb_Bio.Location = new System.Drawing.Point(197, 190);
            this.rtb_Bio.Name = "rtb_Bio";
            this.rtb_Bio.Size = new System.Drawing.Size(258, 168);
            this.rtb_Bio.TabIndex = 33;
            this.rtb_Bio.Text = "";
            // 
            // tb_Date
            // 
            this.tb_Date.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.tb_Date.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_Date.Location = new System.Drawing.Point(197, 140);
            this.tb_Date.Name = "tb_Date";
            this.tb_Date.Size = new System.Drawing.Size(258, 30);
            this.tb_Date.TabIndex = 32;
            // 
            // tb_Id
            // 
            this.tb_Id.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.tb_Id.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_Id.Location = new System.Drawing.Point(197, 92);
            this.tb_Id.Name = "tb_Id";
            this.tb_Id.ReadOnly = true;
            this.tb_Id.Size = new System.Drawing.Size(258, 30);
            this.tb_Id.TabIndex = 31;
            // 
            // tb_Name
            // 
            this.tb_Name.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.tb_Name.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_Name.Location = new System.Drawing.Point(197, 47);
            this.tb_Name.Name = "tb_Name";
            this.tb_Name.Size = new System.Drawing.Size(258, 30);
            this.tb_Name.TabIndex = 30;
            // 
            // lb_Id
            // 
            this.lb_Id.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lb_Id.AutoSize = true;
            this.lb_Id.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_Id.ForeColor = System.Drawing.Color.Gainsboro;
            this.lb_Id.Location = new System.Drawing.Point(43, 95);
            this.lb_Id.Name = "lb_Id";
            this.lb_Id.Size = new System.Drawing.Size(47, 25);
            this.lb_Id.TabIndex = 29;
            this.lb_Id.Text = "ID : ";
            // 
            // lb_Date
            // 
            this.lb_Date.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lb_Date.AutoSize = true;
            this.lb_Date.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_Date.ForeColor = System.Drawing.Color.Gainsboro;
            this.lb_Date.Location = new System.Drawing.Point(43, 140);
            this.lb_Date.Name = "lb_Date";
            this.lb_Date.Size = new System.Drawing.Size(115, 25);
            this.lb_Date.TabIndex = 28;
            this.lb_Date.Text = "Ngày sinh : ";
            // 
            // lb_Bio
            // 
            this.lb_Bio.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lb_Bio.AutoSize = true;
            this.lb_Bio.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_Bio.ForeColor = System.Drawing.Color.Gainsboro;
            this.lb_Bio.Location = new System.Drawing.Point(43, 190);
            this.lb_Bio.Name = "lb_Bio";
            this.lb_Bio.Size = new System.Drawing.Size(93, 25);
            this.lb_Bio.TabIndex = 27;
            this.lb_Bio.Text = "Tiểu sử : ";
            // 
            // lb_Name
            // 
            this.lb_Name.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lb_Name.AutoSize = true;
            this.lb_Name.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_Name.ForeColor = System.Drawing.Color.Gainsboro;
            this.lb_Name.Location = new System.Drawing.Point(43, 47);
            this.lb_Name.Name = "lb_Name";
            this.lb_Name.Size = new System.Drawing.Size(85, 25);
            this.lb_Name.TabIndex = 26;
            this.lb_Name.Text = "Họ tên : ";
            // 
            // frm_Profile
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(39)))), ((int)(((byte)(58)))));
            this.ClientSize = new System.Drawing.Size(1257, 585);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.pb_Avatar);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frm_Profile";
            this.Text = "Profile";
            this.Load += new System.EventHandler(this.frm_Profile_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pb_Avatar)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pb_Avatar;
        private System.Windows.Forms.Panel panel1;
        private Custom_Control.RoundedButton btn_AvatarUpload;
        private Custom_Control.RoundedButton btn_DeleteUser;
        private Custom_Control.RoundedButton btn_SaveChanges;
        private System.Windows.Forms.RichTextBox rtb_Bio;
        private System.Windows.Forms.TextBox tb_Date;
        private System.Windows.Forms.TextBox tb_Id;
        private System.Windows.Forms.TextBox tb_Name;
        private System.Windows.Forms.Label lb_Id;
        private System.Windows.Forms.Label lb_Date;
        private System.Windows.Forms.Label lb_Bio;
        private System.Windows.Forms.Label lb_Name;
    }
}
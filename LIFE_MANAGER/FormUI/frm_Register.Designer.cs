
namespace LIFE_MANAGER.FormUI
{
    partial class frm_Register
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm_Register));
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.pb_Avatar = new System.Windows.Forms.PictureBox();
            this.tb_Name = new System.Windows.Forms.TextBox();
            this.tb_Date = new System.Windows.Forms.TextBox();
            this.tb_Username = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.tb_Password = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.rtb_Biography = new System.Windows.Forms.RichTextBox();
            this.lb_ConfirmPass = new System.Windows.Forms.Label();
            this.tb_Confirm = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.btn_Register = new LIFE_MANAGER.Custom_Control.RoundedButton();
            this.btn_Close = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.btn_AvatarUpload = new LIFE_MANAGER.Custom_Control.RoundedButton();
            ((System.ComponentModel.ISupportInitialize)(this.pb_Avatar)).BeginInit();
            this.SuspendLayout();
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label4.Location = new System.Drawing.Point(480, 228);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(69, 25);
            this.label4.TabIndex = 13;
            this.label4.Text = "Date : ";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label3.Location = new System.Drawing.Point(480, 426);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(116, 25);
            this.label3.TabIndex = 12;
            this.label3.Text = "Biography : ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label2.Location = new System.Drawing.Point(480, 190);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(88, 25);
            this.label2.TabIndex = 11;
            this.label2.Text = "Name* : ";
            // 
            // pb_Avatar
            // 
            this.pb_Avatar.Image = ((System.Drawing.Image)(resources.GetObject("pb_Avatar.Image")));
            this.pb_Avatar.Location = new System.Drawing.Point(24, 112);
            this.pb_Avatar.Name = "pb_Avatar";
            this.pb_Avatar.Size = new System.Drawing.Size(322, 356);
            this.pb_Avatar.TabIndex = 10;
            this.pb_Avatar.TabStop = false;
            this.pb_Avatar.Click += new System.EventHandler(this.pb_Avatar_Click);
            // 
            // tb_Name
            // 
            this.tb_Name.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_Name.Location = new System.Drawing.Point(662, 190);
            this.tb_Name.Name = "tb_Name";
            this.tb_Name.Size = new System.Drawing.Size(319, 30);
            this.tb_Name.TabIndex = 1;
            // 
            // tb_Date
            // 
            this.tb_Date.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_Date.Location = new System.Drawing.Point(662, 228);
            this.tb_Date.Name = "tb_Date";
            this.tb_Date.Size = new System.Drawing.Size(319, 30);
            this.tb_Date.TabIndex = 2;
            // 
            // tb_Username
            // 
            this.tb_Username.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_Username.Location = new System.Drawing.Point(662, 268);
            this.tb_Username.Name = "tb_Username";
            this.tb_Username.Size = new System.Drawing.Size(319, 30);
            this.tb_Username.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label1.Location = new System.Drawing.Point(480, 268);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(77, 25);
            this.label1.TabIndex = 21;
            this.label1.Text = "User* : ";
            // 
            // tb_Password
            // 
            this.tb_Password.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_Password.Location = new System.Drawing.Point(662, 310);
            this.tb_Password.Name = "tb_Password";
            this.tb_Password.PasswordChar = '*';
            this.tb_Password.Size = new System.Drawing.Size(319, 30);
            this.tb_Password.TabIndex = 4;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label5.Location = new System.Drawing.Point(480, 310);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(80, 25);
            this.label5.TabIndex = 23;
            this.label5.Text = "Pass *: ";
            // 
            // rtb_Biography
            // 
            this.rtb_Biography.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rtb_Biography.Location = new System.Drawing.Point(662, 426);
            this.rtb_Biography.Name = "rtb_Biography";
            this.rtb_Biography.Size = new System.Drawing.Size(319, 132);
            this.rtb_Biography.TabIndex = 6;
            this.rtb_Biography.Text = "";
            // 
            // lb_ConfirmPass
            // 
            this.lb_ConfirmPass.AutoSize = true;
            this.lb_ConfirmPass.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_ConfirmPass.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lb_ConfirmPass.Location = new System.Drawing.Point(480, 355);
            this.lb_ConfirmPass.Name = "lb_ConfirmPass";
            this.lb_ConfirmPass.Size = new System.Drawing.Size(190, 25);
            this.lb_ConfirmPass.TabIndex = 25;
            this.lb_ConfirmPass.Text = "Confirm Password* :";
            // 
            // tb_Confirm
            // 
            this.tb_Confirm.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_Confirm.Location = new System.Drawing.Point(662, 355);
            this.tb_Confirm.Name = "tb_Confirm";
            this.tb_Confirm.PasswordChar = '*';
            this.tb_Confirm.Size = new System.Drawing.Size(319, 30);
            this.tb_Confirm.TabIndex = 5;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Red;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label6.Location = new System.Drawing.Point(480, 132);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(201, 25);
            this.label6.TabIndex = 27;
            this.label6.Text = "Field with * is required";
            // 
            // btn_Register
            // 
            this.btn_Register.BackColor = System.Drawing.Color.Blue;
            this.btn_Register.BackgroundColor = System.Drawing.Color.Blue;
            this.btn_Register.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.btn_Register.BorderRadius = 40;
            this.btn_Register.BorderSize = 0;
            this.btn_Register.FlatAppearance.BorderSize = 0;
            this.btn_Register.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Register.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Register.ForeColor = System.Drawing.Color.White;
            this.btn_Register.Location = new System.Drawing.Point(883, 564);
            this.btn_Register.Name = "btn_Register";
            this.btn_Register.Size = new System.Drawing.Size(98, 40);
            this.btn_Register.TabIndex = 7;
            this.btn_Register.Text = "Create";
            this.btn_Register.TextColor = System.Drawing.Color.White;
            this.btn_Register.UseVisualStyleBackColor = false;
            this.btn_Register.Click += new System.EventHandler(this.btn_Register_Click);
            // 
            // btn_Close
            // 
            this.btn_Close.FlatAppearance.BorderSize = 0;
            this.btn_Close.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Close.Image = ((System.Drawing.Image)(resources.GetObject("btn_Close.Image")));
            this.btn_Close.Location = new System.Drawing.Point(1010, 12);
            this.btn_Close.Name = "btn_Close";
            this.btn_Close.Size = new System.Drawing.Size(75, 23);
            this.btn_Close.TabIndex = 28;
            this.btn_Close.UseVisualStyleBackColor = true;
            this.btn_Close.Click += new System.EventHandler(this.btn_Close_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(487, 12);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(147, 38);
            this.label7.TabIndex = 29;
            this.label7.Text = "Register";
            // 
            // btn_AvatarUpload
            // 
            this.btn_AvatarUpload.BackColor = System.Drawing.Color.Blue;
            this.btn_AvatarUpload.BackgroundColor = System.Drawing.Color.Blue;
            this.btn_AvatarUpload.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.btn_AvatarUpload.BorderRadius = 40;
            this.btn_AvatarUpload.BorderSize = 0;
            this.btn_AvatarUpload.FlatAppearance.BorderSize = 0;
            this.btn_AvatarUpload.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_AvatarUpload.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_AvatarUpload.ForeColor = System.Drawing.Color.White;
            this.btn_AvatarUpload.Location = new System.Drawing.Point(165, 564);
            this.btn_AvatarUpload.Name = "btn_AvatarUpload";
            this.btn_AvatarUpload.Size = new System.Drawing.Size(181, 40);
            this.btn_AvatarUpload.TabIndex = 30;
            this.btn_AvatarUpload.Text = "Upload Avatar";
            this.btn_AvatarUpload.TextColor = System.Drawing.Color.White;
            this.btn_AvatarUpload.UseVisualStyleBackColor = false;
            this.btn_AvatarUpload.Click += new System.EventHandler(this.btn_AvatarUpload_Click);
            // 
            // frm_Register
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(39)))), ((int)(((byte)(58)))));
            this.ClientSize = new System.Drawing.Size(1097, 636);
            this.Controls.Add(this.btn_AvatarUpload);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.btn_Close);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.tb_Confirm);
            this.Controls.Add(this.lb_ConfirmPass);
            this.Controls.Add(this.rtb_Biography);
            this.Controls.Add(this.tb_Password);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.tb_Username);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btn_Register);
            this.Controls.Add(this.tb_Date);
            this.Controls.Add(this.tb_Name);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.pb_Avatar);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frm_Register";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Register";
            ((System.ComponentModel.ISupportInitialize)(this.pb_Avatar)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.PictureBox pb_Avatar;
        private System.Windows.Forms.TextBox tb_Name;
        private System.Windows.Forms.TextBox tb_Date;
        private Custom_Control.RoundedButton btn_Register;
        private System.Windows.Forms.TextBox tb_Username;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tb_Password;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.RichTextBox rtb_Biography;
        private System.Windows.Forms.Label lb_ConfirmPass;
        private System.Windows.Forms.TextBox tb_Confirm;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btn_Close;
        private System.Windows.Forms.Label label7;
        private Custom_Control.RoundedButton btn_AvatarUpload;
    }
}
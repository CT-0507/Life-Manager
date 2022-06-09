namespace LIFE_MANAGER.FormUI
{
    partial class frm_DiaryWriting
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm_DiaryWriting));
            this.rtb_Diary = new System.Windows.Forms.RichTextBox();
            this.lb_Journal = new System.Windows.Forms.Label();
            this.pnl_Images = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.cb_Mood = new System.Windows.Forms.ComboBox();
            this.lb_Date = new System.Windows.Forms.Label();
            this.btn_Close = new System.Windows.Forms.Button();
            this.btn_Clear = new LIFE_MANAGER.Custom_Control.RoundedButton();
            this.btn_UploadImage = new LIFE_MANAGER.Custom_Control.RoundedButton();
            this.btn_SaveChanges = new LIFE_MANAGER.Custom_Control.RoundedButton();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // rtb_Diary
            // 
            this.rtb_Diary.BackColor = System.Drawing.Color.MintCream;
            this.rtb_Diary.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rtb_Diary.Location = new System.Drawing.Point(33, 193);
            this.rtb_Diary.Name = "rtb_Diary";
            this.rtb_Diary.Size = new System.Drawing.Size(555, 340);
            this.rtb_Diary.TabIndex = 1;
            this.rtb_Diary.Text = "";
            // 
            // lb_Journal
            // 
            this.lb_Journal.AutoSize = true;
            this.lb_Journal.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_Journal.ForeColor = System.Drawing.Color.Gainsboro;
            this.lb_Journal.Location = new System.Drawing.Point(27, 146);
            this.lb_Journal.Name = "lb_Journal";
            this.lb_Journal.Size = new System.Drawing.Size(117, 31);
            this.lb_Journal.TabIndex = 2;
            this.lb_Journal.Text = "Content";
            // 
            // pnl_Images
            // 
            this.pnl_Images.AutoScroll = true;
            this.pnl_Images.Location = new System.Drawing.Point(637, 108);
            this.pnl_Images.Name = "pnl_Images";
            this.pnl_Images.Size = new System.Drawing.Size(754, 427);
            this.pnl_Images.TabIndex = 6;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Gainsboro;
            this.label1.Location = new System.Drawing.Point(647, 46);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(121, 31);
            this.label1.TabIndex = 8;
            this.label1.Text = "Pictures";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Gainsboro;
            this.label2.Location = new System.Drawing.Point(53, 580);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(110, 31);
            this.label2.TabIndex = 9;
            this.label2.Text = "Feeling";
            // 
            // cb_Mood
            // 
            this.cb_Mood.FormattingEnabled = true;
            this.cb_Mood.Location = new System.Drawing.Point(230, 587);
            this.cb_Mood.Name = "cb_Mood";
            this.cb_Mood.Size = new System.Drawing.Size(121, 24);
            this.cb_Mood.TabIndex = 10;
            // 
            // lb_Date
            // 
            this.lb_Date.AutoSize = true;
            this.lb_Date.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_Date.ForeColor = System.Drawing.Color.Gainsboro;
            this.lb_Date.Location = new System.Drawing.Point(311, 52);
            this.lb_Date.Name = "lb_Date";
            this.lb_Date.Size = new System.Drawing.Size(70, 25);
            this.lb_Date.TabIndex = 11;
            this.lb_Date.Text = "label3";
            // 
            // btn_Close
            // 
            this.btn_Close.BackColor = System.Drawing.Color.Cyan;
            this.btn_Close.FlatAppearance.BorderSize = 0;
            this.btn_Close.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Close.Image = ((System.Drawing.Image)(resources.GetObject("btn_Close.Image")));
            this.btn_Close.Location = new System.Drawing.Point(1361, -1);
            this.btn_Close.Name = "btn_Close";
            this.btn_Close.Size = new System.Drawing.Size(75, 23);
            this.btn_Close.TabIndex = 12;
            this.btn_Close.UseVisualStyleBackColor = false;
            this.btn_Close.Click += new System.EventHandler(this.btn_Close_Click);
            // 
            // btn_Clear
            // 
            this.btn_Clear.BackColor = System.Drawing.Color.Blue;
            this.btn_Clear.BackgroundColor = System.Drawing.Color.Blue;
            this.btn_Clear.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.btn_Clear.BorderRadius = 40;
            this.btn_Clear.BorderSize = 0;
            this.btn_Clear.FlatAppearance.BorderSize = 0;
            this.btn_Clear.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Clear.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Clear.ForeColor = System.Drawing.Color.White;
            this.btn_Clear.Location = new System.Drawing.Point(893, 579);
            this.btn_Clear.Name = "btn_Clear";
            this.btn_Clear.Size = new System.Drawing.Size(142, 40);
            this.btn_Clear.TabIndex = 7;
            this.btn_Clear.Text = "Clear Images";
            this.btn_Clear.TextColor = System.Drawing.Color.White;
            this.btn_Clear.UseVisualStyleBackColor = false;
            this.btn_Clear.Click += new System.EventHandler(this.btn_Clear_Click);
            // 
            // btn_UploadImage
            // 
            this.btn_UploadImage.BackColor = System.Drawing.Color.Blue;
            this.btn_UploadImage.BackgroundColor = System.Drawing.Color.Blue;
            this.btn_UploadImage.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.btn_UploadImage.BorderRadius = 40;
            this.btn_UploadImage.BorderSize = 0;
            this.btn_UploadImage.FlatAppearance.BorderSize = 0;
            this.btn_UploadImage.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_UploadImage.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_UploadImage.ForeColor = System.Drawing.Color.White;
            this.btn_UploadImage.Location = new System.Drawing.Point(1057, 579);
            this.btn_UploadImage.Name = "btn_UploadImage";
            this.btn_UploadImage.Size = new System.Drawing.Size(124, 40);
            this.btn_UploadImage.TabIndex = 5;
            this.btn_UploadImage.Text = "Upload";
            this.btn_UploadImage.TextColor = System.Drawing.Color.White;
            this.btn_UploadImage.UseVisualStyleBackColor = false;
            this.btn_UploadImage.Click += new System.EventHandler(this.btn_UploadImage_Click);
            // 
            // btn_SaveChanges
            // 
            this.btn_SaveChanges.BackColor = System.Drawing.Color.Blue;
            this.btn_SaveChanges.BackgroundColor = System.Drawing.Color.Blue;
            this.btn_SaveChanges.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.btn_SaveChanges.BorderRadius = 40;
            this.btn_SaveChanges.BorderSize = 0;
            this.btn_SaveChanges.FlatAppearance.BorderSize = 0;
            this.btn_SaveChanges.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_SaveChanges.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_SaveChanges.ForeColor = System.Drawing.Color.White;
            this.btn_SaveChanges.Location = new System.Drawing.Point(759, 579);
            this.btn_SaveChanges.Name = "btn_SaveChanges";
            this.btn_SaveChanges.Size = new System.Drawing.Size(103, 40);
            this.btn_SaveChanges.TabIndex = 3;
            this.btn_SaveChanges.Text = "Save";
            this.btn_SaveChanges.TextColor = System.Drawing.Color.White;
            this.btn_SaveChanges.UseVisualStyleBackColor = false;
            this.btn_SaveChanges.Click += new System.EventHandler(this.btn_SaveChanges_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Controls.Add(this.btn_Close);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1436, 25);
            this.panel1.TabIndex = 13;
            // 
            // frm_DiaryWriting
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(39)))), ((int)(((byte)(58)))));
            this.ClientSize = new System.Drawing.Size(1436, 689);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.lb_Date);
            this.Controls.Add(this.cb_Mood);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btn_Clear);
            this.Controls.Add(this.pnl_Images);
            this.Controls.Add(this.btn_UploadImage);
            this.Controls.Add(this.btn_SaveChanges);
            this.Controls.Add(this.lb_Journal);
            this.Controls.Add(this.rtb_Diary);
            this.ForeColor = System.Drawing.Color.Gainsboro;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frm_DiaryWriting";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frm_DiaryWriting";
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.RichTextBox rtb_Diary;
        private System.Windows.Forms.Label lb_Journal;
        private Custom_Control.RoundedButton btn_SaveChanges;
        private Custom_Control.RoundedButton btn_UploadImage;
        private System.Windows.Forms.Panel pnl_Images;
        private Custom_Control.RoundedButton btn_Clear;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cb_Mood;
        private System.Windows.Forms.Label lb_Date;
        private System.Windows.Forms.Button btn_Close;
        private System.Windows.Forms.Panel panel1;
    }
}
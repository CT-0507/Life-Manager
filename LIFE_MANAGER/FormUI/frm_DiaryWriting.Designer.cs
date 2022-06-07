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
            this.lb_Date = new System.Windows.Forms.Label();
            this.rtb_Diary = new System.Windows.Forms.RichTextBox();
            this.lb_Journal = new System.Windows.Forms.Label();
            this.btn_SaveChanges = new LIFE_MANAGER.Custom_Control.RoundedButton();
            this.btn_UploadImage = new LIFE_MANAGER.Custom_Control.RoundedButton();
            this.pnl_Images = new System.Windows.Forms.Panel();
            this.btn_Clear = new LIFE_MANAGER.Custom_Control.RoundedButton();
            this.SuspendLayout();
            // 
            // lb_Date
            // 
            this.lb_Date.AutoSize = true;
            this.lb_Date.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_Date.Location = new System.Drawing.Point(26, 30);
            this.lb_Date.Name = "lb_Date";
            this.lb_Date.Size = new System.Drawing.Size(92, 31);
            this.lb_Date.TabIndex = 0;
            this.lb_Date.Text = "label1";
            // 
            // rtb_Diary
            // 
            this.rtb_Diary.Location = new System.Drawing.Point(32, 127);
            this.rtb_Diary.Name = "rtb_Diary";
            this.rtb_Diary.Size = new System.Drawing.Size(555, 311);
            this.rtb_Diary.TabIndex = 1;
            this.rtb_Diary.Text = "";
            // 
            // lb_Journal
            // 
            this.lb_Journal.AutoSize = true;
            this.lb_Journal.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_Journal.Location = new System.Drawing.Point(26, 80);
            this.lb_Journal.Name = "lb_Journal";
            this.lb_Journal.Size = new System.Drawing.Size(110, 31);
            this.lb_Journal.TabIndex = 2;
            this.lb_Journal.Text = "Journal";
            // 
            // btn_SaveChanges
            // 
            this.btn_SaveChanges.BackColor = System.Drawing.Color.MediumSlateBlue;
            this.btn_SaveChanges.BackgroundColor = System.Drawing.Color.MediumSlateBlue;
            this.btn_SaveChanges.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.btn_SaveChanges.BorderRadius = 40;
            this.btn_SaveChanges.BorderSize = 0;
            this.btn_SaveChanges.FlatAppearance.BorderSize = 0;
            this.btn_SaveChanges.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_SaveChanges.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_SaveChanges.ForeColor = System.Drawing.Color.White;
            this.btn_SaveChanges.Location = new System.Drawing.Point(437, 466);
            this.btn_SaveChanges.Name = "btn_SaveChanges";
            this.btn_SaveChanges.Size = new System.Drawing.Size(150, 40);
            this.btn_SaveChanges.TabIndex = 3;
            this.btn_SaveChanges.Text = "Save";
            this.btn_SaveChanges.TextColor = System.Drawing.Color.White;
            this.btn_SaveChanges.UseVisualStyleBackColor = false;
            this.btn_SaveChanges.Click += new System.EventHandler(this.btn_SaveChanges_Click);
            // 
            // btn_UploadImage
            // 
            this.btn_UploadImage.BackColor = System.Drawing.Color.MediumSlateBlue;
            this.btn_UploadImage.BackgroundColor = System.Drawing.Color.MediumSlateBlue;
            this.btn_UploadImage.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.btn_UploadImage.BorderRadius = 40;
            this.btn_UploadImage.BorderSize = 0;
            this.btn_UploadImage.FlatAppearance.BorderSize = 0;
            this.btn_UploadImage.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_UploadImage.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_UploadImage.ForeColor = System.Drawing.Color.White;
            this.btn_UploadImage.Location = new System.Drawing.Point(788, 466);
            this.btn_UploadImage.Name = "btn_UploadImage";
            this.btn_UploadImage.Size = new System.Drawing.Size(150, 40);
            this.btn_UploadImage.TabIndex = 5;
            this.btn_UploadImage.Text = "Upload";
            this.btn_UploadImage.TextColor = System.Drawing.Color.White;
            this.btn_UploadImage.UseVisualStyleBackColor = false;
            this.btn_UploadImage.Click += new System.EventHandler(this.btn_UploadImage_Click);
            // 
            // pnl_Images
            // 
            this.pnl_Images.AutoScroll = true;
            this.pnl_Images.Location = new System.Drawing.Point(637, 80);
            this.pnl_Images.Name = "pnl_Images";
            this.pnl_Images.Size = new System.Drawing.Size(301, 360);
            this.pnl_Images.TabIndex = 6;
            // 
            // btn_Clear
            // 
            this.btn_Clear.BackColor = System.Drawing.Color.MediumSlateBlue;
            this.btn_Clear.BackgroundColor = System.Drawing.Color.MediumSlateBlue;
            this.btn_Clear.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.btn_Clear.BorderRadius = 40;
            this.btn_Clear.BorderSize = 0;
            this.btn_Clear.FlatAppearance.BorderSize = 0;
            this.btn_Clear.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Clear.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Clear.ForeColor = System.Drawing.Color.White;
            this.btn_Clear.Location = new System.Drawing.Point(593, 466);
            this.btn_Clear.Name = "btn_Clear";
            this.btn_Clear.Size = new System.Drawing.Size(189, 40);
            this.btn_Clear.TabIndex = 7;
            this.btn_Clear.Text = "Clear Images";
            this.btn_Clear.TextColor = System.Drawing.Color.White;
            this.btn_Clear.UseVisualStyleBackColor = false;
            this.btn_Clear.Click += new System.EventHandler(this.btn_Clear_Click);
            // 
            // frm_DiaryWriting
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(969, 567);
            this.Controls.Add(this.btn_Clear);
            this.Controls.Add(this.pnl_Images);
            this.Controls.Add(this.btn_UploadImage);
            this.Controls.Add(this.btn_SaveChanges);
            this.Controls.Add(this.lb_Journal);
            this.Controls.Add(this.rtb_Diary);
            this.Controls.Add(this.lb_Date);
            this.Name = "frm_DiaryWriting";
            this.Text = "frm_DiaryWriting";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lb_Date;
        private System.Windows.Forms.RichTextBox rtb_Diary;
        private System.Windows.Forms.Label lb_Journal;
        private Custom_Control.RoundedButton btn_SaveChanges;
        private Custom_Control.RoundedButton btn_UploadImage;
        private System.Windows.Forms.Panel pnl_Images;
        private Custom_Control.RoundedButton btn_Clear;
    }
}
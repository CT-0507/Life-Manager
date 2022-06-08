namespace LIFE_MANAGER.FormUI
{
    partial class frm_Diary
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel6 = new System.Windows.Forms.Panel();
            this.nmNotify = new System.Windows.Forms.NumericUpDown();
            this.ckbNotify = new System.Windows.Forms.CheckBox();
            this.btnToDay = new System.Windows.Forms.Button();
            this.dtpkDate = new System.Windows.Forms.DateTimePicker();
            this.panel2 = new System.Windows.Forms.Panel();
            this.pnlMatrix = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.iconButton2 = new FontAwesome.Sharp.IconButton();
            this.iconButton1 = new FontAwesome.Sharp.IconButton();
            this.btnSunday = new System.Windows.Forms.Button();
            this.btnSaturday = new System.Windows.Forms.Button();
            this.btnFriday = new System.Windows.Forms.Button();
            this.btnThusday = new System.Windows.Forms.Button();
            this.btnWednesday = new System.Windows.Forms.Button();
            this.btnTuesday = new System.Windows.Forms.Button();
            this.btnMonday = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel6.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nmNotify)).BeginInit();
            this.panel2.SuspendLayout();
            this.panel4.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.panel1.Controls.Add(this.panel3);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Location = new System.Drawing.Point(16, 40);
            this.panel1.Margin = new System.Windows.Forms.Padding(4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1323, 732);
            this.panel1.TabIndex = 0;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.panel6);
            this.panel3.Controls.Add(this.btnToDay);
            this.panel3.Controls.Add(this.dtpkDate);
            this.panel3.Location = new System.Drawing.Point(4, 22);
            this.panel3.Margin = new System.Windows.Forms.Padding(4);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(1285, 73);
            this.panel3.TabIndex = 1;
            // 
            // panel6
            // 
            this.panel6.Controls.Add(this.nmNotify);
            this.panel6.Controls.Add(this.ckbNotify);
            this.panel6.Location = new System.Drawing.Point(9, 11);
            this.panel6.Margin = new System.Windows.Forms.Padding(4);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(353, 54);
            this.panel6.TabIndex = 2;
            // 
            // nmNotify
            // 
            this.nmNotify.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nmNotify.Location = new System.Drawing.Point(177, 13);
            this.nmNotify.Margin = new System.Windows.Forms.Padding(4);
            this.nmNotify.Maximum = new decimal(new int[] {
            3600,
            0,
            0,
            0});
            this.nmNotify.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nmNotify.Name = "nmNotify";
            this.nmNotify.Size = new System.Drawing.Size(80, 30);
            this.nmNotify.TabIndex = 1;
            this.nmNotify.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nmNotify.ValueChanged += new System.EventHandler(this.nmNotify_ValueChanged);
            // 
            // ckbNotify
            // 
            this.ckbNotify.AutoSize = true;
            this.ckbNotify.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ckbNotify.ForeColor = System.Drawing.Color.Gainsboro;
            this.ckbNotify.Location = new System.Drawing.Point(15, 12);
            this.ckbNotify.Margin = new System.Windows.Forms.Padding(4);
            this.ckbNotify.Name = "ckbNotify";
            this.ckbNotify.Size = new System.Drawing.Size(83, 29);
            this.ckbNotify.TabIndex = 0;
            this.ckbNotify.Text = "Notify";
            this.ckbNotify.UseVisualStyleBackColor = true;
            this.ckbNotify.CheckedChanged += new System.EventHandler(this.ckbNotify_CheckedChanged);
            // 
            // btnToDay
            // 
            this.btnToDay.Location = new System.Drawing.Point(875, 22);
            this.btnToDay.Margin = new System.Windows.Forms.Padding(4);
            this.btnToDay.Name = "btnToDay";
            this.btnToDay.Size = new System.Drawing.Size(122, 49);
            this.btnToDay.TabIndex = 1;
            this.btnToDay.Text = "Today";
            this.btnToDay.UseVisualStyleBackColor = true;
            this.btnToDay.Click += new System.EventHandler(this.btnToDay_Click);
            // 
            // dtpkDate
            // 
            this.dtpkDate.CalendarForeColor = System.Drawing.Color.Gainsboro;
            this.dtpkDate.CalendarTitleBackColor = System.Drawing.Color.AntiqueWhite;
            this.dtpkDate.CalendarTrailingForeColor = System.Drawing.Color.Gainsboro;
            this.dtpkDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpkDate.Location = new System.Drawing.Point(457, 27);
            this.dtpkDate.Margin = new System.Windows.Forms.Padding(4);
            this.dtpkDate.Name = "dtpkDate";
            this.dtpkDate.Size = new System.Drawing.Size(356, 30);
            this.dtpkDate.TabIndex = 0;
            this.dtpkDate.ValueChanged += new System.EventHandler(this.dtpkDate_ValueChanged);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.pnlMatrix);
            this.panel2.Controls.Add(this.panel4);
            this.panel2.Location = new System.Drawing.Point(4, 114);
            this.panel2.Margin = new System.Windows.Forms.Padding(4);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1305, 614);
            this.panel2.TabIndex = 0;
            // 
            // pnlMatrix
            // 
            this.pnlMatrix.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pnlMatrix.Location = new System.Drawing.Point(171, 149);
            this.pnlMatrix.Margin = new System.Windows.Forms.Padding(4);
            this.pnlMatrix.Name = "pnlMatrix";
            this.pnlMatrix.Size = new System.Drawing.Size(952, 455);
            this.pnlMatrix.TabIndex = 1;
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.iconButton2);
            this.panel4.Controls.Add(this.iconButton1);
            this.panel4.Controls.Add(this.btnSunday);
            this.panel4.Controls.Add(this.btnSaturday);
            this.panel4.Controls.Add(this.btnFriday);
            this.panel4.Controls.Add(this.btnThusday);
            this.panel4.Controls.Add(this.btnWednesday);
            this.panel4.Controls.Add(this.btnTuesday);
            this.panel4.Controls.Add(this.btnMonday);
            this.panel4.Location = new System.Drawing.Point(4, 33);
            this.panel4.Margin = new System.Windows.Forms.Padding(4);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(1281, 90);
            this.panel4.TabIndex = 0;
            // 
            // iconButton2
            // 
            this.iconButton2.IconChar = FontAwesome.Sharp.IconChar.ArrowLeft;
            this.iconButton2.IconColor = System.Drawing.Color.Black;
            this.iconButton2.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconButton2.Location = new System.Drawing.Point(19, 4);
            this.iconButton2.Name = "iconButton2";
            this.iconButton2.Size = new System.Drawing.Size(129, 65);
            this.iconButton2.TabIndex = 8;
            this.iconButton2.UseVisualStyleBackColor = true;
            this.iconButton2.Click += new System.EventHandler(this.btnPreviours_Click);
            // 
            // iconButton1
            // 
            this.iconButton1.IconChar = FontAwesome.Sharp.IconChar.ArrowRight;
            this.iconButton1.IconColor = System.Drawing.Color.Black;
            this.iconButton1.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconButton1.Location = new System.Drawing.Point(1135, 4);
            this.iconButton1.Name = "iconButton1";
            this.iconButton1.Size = new System.Drawing.Size(129, 65);
            this.iconButton1.TabIndex = 7;
            this.iconButton1.UseVisualStyleBackColor = true;
            this.iconButton1.Click += new System.EventHandler(this.btnNext_Click);
            // 
            // btnSunday
            // 
            this.btnSunday.Location = new System.Drawing.Point(984, 4);
            this.btnSunday.Margin = new System.Windows.Forms.Padding(4);
            this.btnSunday.Name = "btnSunday";
            this.btnSunday.Size = new System.Drawing.Size(129, 65);
            this.btnSunday.TabIndex = 6;
            this.btnSunday.Text = "Sunday";
            this.btnSunday.UseVisualStyleBackColor = true;
            // 
            // btnSaturday
            // 
            this.btnSaturday.Location = new System.Drawing.Point(847, 4);
            this.btnSaturday.Margin = new System.Windows.Forms.Padding(4);
            this.btnSaturday.Name = "btnSaturday";
            this.btnSaturday.Size = new System.Drawing.Size(129, 65);
            this.btnSaturday.TabIndex = 5;
            this.btnSaturday.Text = "Saturday";
            this.btnSaturday.UseVisualStyleBackColor = true;
            // 
            // btnFriday
            // 
            this.btnFriday.Location = new System.Drawing.Point(710, 4);
            this.btnFriday.Margin = new System.Windows.Forms.Padding(4);
            this.btnFriday.Name = "btnFriday";
            this.btnFriday.Size = new System.Drawing.Size(129, 65);
            this.btnFriday.TabIndex = 4;
            this.btnFriday.Text = "Friday";
            this.btnFriday.UseVisualStyleBackColor = true;
            // 
            // btnThusday
            // 
            this.btnThusday.Location = new System.Drawing.Point(574, 4);
            this.btnThusday.Margin = new System.Windows.Forms.Padding(4);
            this.btnThusday.Name = "btnThusday";
            this.btnThusday.Size = new System.Drawing.Size(129, 65);
            this.btnThusday.TabIndex = 3;
            this.btnThusday.Text = "Thusday";
            this.btnThusday.UseVisualStyleBackColor = true;
            // 
            // btnWednesday
            // 
            this.btnWednesday.Location = new System.Drawing.Point(439, 4);
            this.btnWednesday.Margin = new System.Windows.Forms.Padding(4);
            this.btnWednesday.Name = "btnWednesday";
            this.btnWednesday.Size = new System.Drawing.Size(129, 65);
            this.btnWednesday.TabIndex = 2;
            this.btnWednesday.Text = "Wednesday";
            this.btnWednesday.UseVisualStyleBackColor = true;
            // 
            // btnTuesday
            // 
            this.btnTuesday.Location = new System.Drawing.Point(303, 4);
            this.btnTuesday.Margin = new System.Windows.Forms.Padding(4);
            this.btnTuesday.Name = "btnTuesday";
            this.btnTuesday.Size = new System.Drawing.Size(129, 65);
            this.btnTuesday.TabIndex = 1;
            this.btnTuesday.Text = "Tuesday";
            this.btnTuesday.UseVisualStyleBackColor = true;
            // 
            // btnMonday
            // 
            this.btnMonday.Location = new System.Drawing.Point(166, 4);
            this.btnMonday.Margin = new System.Windows.Forms.Padding(4);
            this.btnMonday.Name = "btnMonday";
            this.btnMonday.Size = new System.Drawing.Size(129, 65);
            this.btnMonday.TabIndex = 0;
            this.btnMonday.Text = "Monday";
            this.btnMonday.UseVisualStyleBackColor = true;
            // 
            // frm_Diary
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(39)))), ((int)(((byte)(58)))));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ClientSize = new System.Drawing.Size(1352, 810);
            this.Controls.Add(this.panel1);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "frm_Diary";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Diary";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.Load += new System.EventHandler(this.frm_Diary_Load);
            this.panel1.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel6.ResumeLayout(false);
            this.panel6.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nmNotify)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.NumericUpDown nmNotify;
        private System.Windows.Forms.CheckBox ckbNotify;
        private System.Windows.Forms.Button btnToDay;
        private System.Windows.Forms.DateTimePicker dtpkDate;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel pnlMatrix;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Button btnSunday;
        private System.Windows.Forms.Button btnSaturday;
        private System.Windows.Forms.Button btnFriday;
        private System.Windows.Forms.Button btnThusday;
        private System.Windows.Forms.Button btnWednesday;
        private System.Windows.Forms.Button btnTuesday;
        private System.Windows.Forms.Button btnMonday;
        private FontAwesome.Sharp.IconButton iconButton2;
        private FontAwesome.Sharp.IconButton iconButton1;
    }
}


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
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.lb_Journal = new System.Windows.Forms.Label();
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
            // richTextBox1
            // 
            this.richTextBox1.Location = new System.Drawing.Point(32, 127);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(555, 311);
            this.richTextBox1.TabIndex = 1;
            this.richTextBox1.Text = "";
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
            // frm_DiaryWriting
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(969, 567);
            this.Controls.Add(this.lb_Journal);
            this.Controls.Add(this.richTextBox1);
            this.Controls.Add(this.lb_Date);
            this.Name = "frm_DiaryWriting";
            this.Text = "frm_DiaryWriting";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lb_Date;
        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.Label lb_Journal;
    }
}
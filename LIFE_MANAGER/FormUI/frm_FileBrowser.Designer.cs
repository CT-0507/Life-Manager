namespace LIFE_MANAGER.FormUI
{
    partial class frm_FileBrowser
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
            this.lv_Files = new System.Windows.Forms.ListView();
            this.btn_Open = new LIFE_MANAGER.Custom_Control.RoundedButton();
            this.SuspendLayout();
            // 
            // lv_Files
            // 
            this.lv_Files.HideSelection = false;
            this.lv_Files.Location = new System.Drawing.Point(24, 23);
            this.lv_Files.Name = "lv_Files";
            this.lv_Files.Size = new System.Drawing.Size(713, 366);
            this.lv_Files.TabIndex = 0;
            this.lv_Files.UseCompatibleStateImageBehavior = false;
            this.lv_Files.View = System.Windows.Forms.View.List;
            // 
            // btn_Open
            // 
            this.btn_Open.BackColor = System.Drawing.Color.MediumSlateBlue;
            this.btn_Open.BackgroundColor = System.Drawing.Color.MediumSlateBlue;
            this.btn_Open.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.btn_Open.BorderRadius = 40;
            this.btn_Open.BorderSize = 0;
            this.btn_Open.FlatAppearance.BorderSize = 0;
            this.btn_Open.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Open.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Open.ForeColor = System.Drawing.Color.White;
            this.btn_Open.Location = new System.Drawing.Point(587, 398);
            this.btn_Open.Name = "btn_Open";
            this.btn_Open.Size = new System.Drawing.Size(150, 40);
            this.btn_Open.TabIndex = 1;
            this.btn_Open.Text = "Save";
            this.btn_Open.TextColor = System.Drawing.Color.White;
            this.btn_Open.UseVisualStyleBackColor = false;
            this.btn_Open.Click += new System.EventHandler(this.btn_Open_Click);
            // 
            // frm_FileBrowser
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btn_Open);
            this.Controls.Add(this.lv_Files);
            this.Name = "frm_FileBrowser";
            this.Text = "frm_FileBrowser";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListView lv_Files;
        private Custom_Control.RoundedButton btn_Open;
    }
}
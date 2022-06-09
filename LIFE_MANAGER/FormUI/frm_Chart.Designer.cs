
namespace LIFE_MANAGER.FormUI
{
    partial class frm_Chart
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm_Chart));
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea2 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend2 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series2 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.btn_Close = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.dtpk_Time = new System.Windows.Forms.DateTimePicker();
            this.lb_MoodChart = new System.Windows.Forms.Label();
            this.PieChart_Mood = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.lb_HappyDays = new System.Windows.Forms.Label();
            this.lb_NeutralDays = new System.Windows.Forms.Label();
            this.lb_SadDays = new System.Windows.Forms.Label();
            this.lb_NotSet = new System.Windows.Forms.Label();
            this.ColumnChart_Tasks = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.lb_DONE = new System.Windows.Forms.Label();
            this.lb_DOING = new System.Windows.Forms.Label();
            this.lb_COMING = new System.Windows.Forms.Label();
            this.lb_MISSED = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.PieChart_Mood)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ColumnChart_Tasks)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_Close
            // 
            this.btn_Close.FlatAppearance.BorderSize = 0;
            this.btn_Close.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Close.Image = ((System.Drawing.Image)(resources.GetObject("btn_Close.Image")));
            this.btn_Close.Location = new System.Drawing.Point(964, 12);
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
            this.label1.Location = new System.Drawing.Point(472, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(102, 38);
            this.label1.TabIndex = 7;
            this.label1.Text = "Chart";
            // 
            // dtpk_Time
            // 
            this.dtpk_Time.CustomFormat = "MM / yyyy";
            this.dtpk_Time.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpk_Time.Location = new System.Drawing.Point(406, 64);
            this.dtpk_Time.Name = "dtpk_Time";
            this.dtpk_Time.ShowUpDown = true;
            this.dtpk_Time.Size = new System.Drawing.Size(260, 22);
            this.dtpk_Time.TabIndex = 8;
            this.dtpk_Time.ValueChanged += new System.EventHandler(this.dtpk_Time_ValueChanged);
            // 
            // lb_MoodChart
            // 
            this.lb_MoodChart.AutoSize = true;
            this.lb_MoodChart.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_MoodChart.Location = new System.Drawing.Point(108, 92);
            this.lb_MoodChart.Name = "lb_MoodChart";
            this.lb_MoodChart.Size = new System.Drawing.Size(165, 31);
            this.lb_MoodChart.TabIndex = 9;
            this.lb_MoodChart.Text = "Mood Chart";
            // 
            // PieChart_Mood
            // 
            this.PieChart_Mood.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            chartArea1.Name = "ChartArea1";
            this.PieChart_Mood.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.PieChart_Mood.Legends.Add(legend1);
            this.PieChart_Mood.Location = new System.Drawing.Point(41, 126);
            this.PieChart_Mood.MaximumSize = new System.Drawing.Size(600, 400);
            this.PieChart_Mood.Name = "PieChart_Mood";
            series1.ChartArea = "ChartArea1";
            series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Pie;
            series1.Legend = "Legend1";
            series1.Name = "Series1";
            this.PieChart_Mood.Series.Add(series1);
            this.PieChart_Mood.Size = new System.Drawing.Size(400, 300);
            this.PieChart_Mood.TabIndex = 10;
            this.PieChart_Mood.Text = "chart1";
            // 
            // lb_HappyDays
            // 
            this.lb_HappyDays.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lb_HappyDays.AutoSize = true;
            this.lb_HappyDays.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_HappyDays.Location = new System.Drawing.Point(36, 445);
            this.lb_HappyDays.Name = "lb_HappyDays";
            this.lb_HappyDays.Size = new System.Drawing.Size(87, 29);
            this.lb_HappyDays.TabIndex = 11;
            this.lb_HappyDays.Text = "Happy";
            // 
            // lb_NeutralDays
            // 
            this.lb_NeutralDays.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lb_NeutralDays.AutoSize = true;
            this.lb_NeutralDays.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_NeutralDays.Location = new System.Drawing.Point(269, 445);
            this.lb_NeutralDays.Name = "lb_NeutralDays";
            this.lb_NeutralDays.Size = new System.Drawing.Size(98, 29);
            this.lb_NeutralDays.TabIndex = 12;
            this.lb_NeutralDays.Text = "Neutral";
            // 
            // lb_SadDays
            // 
            this.lb_SadDays.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lb_SadDays.AutoSize = true;
            this.lb_SadDays.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_SadDays.Location = new System.Drawing.Point(36, 498);
            this.lb_SadDays.Name = "lb_SadDays";
            this.lb_SadDays.Size = new System.Drawing.Size(59, 29);
            this.lb_SadDays.TabIndex = 13;
            this.lb_SadDays.Text = "Sad";
            // 
            // lb_NotSet
            // 
            this.lb_NotSet.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lb_NotSet.AutoSize = true;
            this.lb_NotSet.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_NotSet.Location = new System.Drawing.Point(267, 498);
            this.lb_NotSet.Name = "lb_NotSet";
            this.lb_NotSet.Size = new System.Drawing.Size(100, 29);
            this.lb_NotSet.TabIndex = 14;
            this.lb_NotSet.Text = "Not Set";
            // 
            // ColumnChart_Tasks
            // 
            this.ColumnChart_Tasks.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            chartArea2.Name = "ChartArea1";
            this.ColumnChart_Tasks.ChartAreas.Add(chartArea2);
            legend2.Name = "Legend1";
            this.ColumnChart_Tasks.Legends.Add(legend2);
            this.ColumnChart_Tasks.Location = new System.Drawing.Point(573, 126);
            this.ColumnChart_Tasks.MaximumSize = new System.Drawing.Size(600, 400);
            this.ColumnChart_Tasks.Name = "ColumnChart_Tasks";
            series2.ChartArea = "ChartArea1";
            series2.Legend = "Legend1";
            series2.Name = "Series1";
            this.ColumnChart_Tasks.Series.Add(series2);
            this.ColumnChart_Tasks.Size = new System.Drawing.Size(400, 300);
            this.ColumnChart_Tasks.TabIndex = 15;
            this.ColumnChart_Tasks.Text = "chart1";
            // 
            // lb_DONE
            // 
            this.lb_DONE.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lb_DONE.AutoSize = true;
            this.lb_DONE.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_DONE.Location = new System.Drawing.Point(995, 126);
            this.lb_DONE.Name = "lb_DONE";
            this.lb_DONE.Size = new System.Drawing.Size(87, 29);
            this.lb_DONE.TabIndex = 16;
            this.lb_DONE.Text = "DONE";
            // 
            // lb_DOING
            // 
            this.lb_DOING.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lb_DOING.AutoSize = true;
            this.lb_DOING.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_DOING.Location = new System.Drawing.Point(995, 157);
            this.lb_DOING.Name = "lb_DOING";
            this.lb_DOING.Size = new System.Drawing.Size(96, 29);
            this.lb_DOING.TabIndex = 17;
            this.lb_DOING.Text = "DOING";
            // 
            // lb_COMING
            // 
            this.lb_COMING.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lb_COMING.AutoSize = true;
            this.lb_COMING.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_COMING.Location = new System.Drawing.Point(995, 188);
            this.lb_COMING.Name = "lb_COMING";
            this.lb_COMING.Size = new System.Drawing.Size(117, 29);
            this.lb_COMING.TabIndex = 18;
            this.lb_COMING.Text = "COMING";
            // 
            // lb_MISSED
            // 
            this.lb_MISSED.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lb_MISSED.AutoSize = true;
            this.lb_MISSED.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_MISSED.Location = new System.Drawing.Point(995, 219);
            this.lb_MISSED.Name = "lb_MISSED";
            this.lb_MISSED.Size = new System.Drawing.Size(110, 29);
            this.lb_MISSED.TabIndex = 19;
            this.lb_MISSED.Text = "MISSED";
            // 
            // frm_Chart
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1333, 684);
            this.Controls.Add(this.lb_MISSED);
            this.Controls.Add(this.lb_COMING);
            this.Controls.Add(this.lb_DOING);
            this.Controls.Add(this.lb_DONE);
            this.Controls.Add(this.ColumnChart_Tasks);
            this.Controls.Add(this.lb_NotSet);
            this.Controls.Add(this.lb_SadDays);
            this.Controls.Add(this.lb_NeutralDays);
            this.Controls.Add(this.lb_HappyDays);
            this.Controls.Add(this.PieChart_Mood);
            this.Controls.Add(this.lb_MoodChart);
            this.Controls.Add(this.dtpk_Time);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btn_Close);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frm_Chart";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Chart";
            ((System.ComponentModel.ISupportInitialize)(this.PieChart_Mood)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ColumnChart_Tasks)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_Close;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DateTimePicker dtpk_Time;
        private System.Windows.Forms.Label lb_MoodChart;
        private System.Windows.Forms.DataVisualization.Charting.Chart PieChart_Mood;
        private System.Windows.Forms.Label lb_HappyDays;
        private System.Windows.Forms.Label lb_NeutralDays;
        private System.Windows.Forms.Label lb_SadDays;
        private System.Windows.Forms.Label lb_NotSet;
        private System.Windows.Forms.DataVisualization.Charting.Chart ColumnChart_Tasks;
        private System.Windows.Forms.Label lb_DONE;
        private System.Windows.Forms.Label lb_DOING;
        private System.Windows.Forms.Label lb_COMING;
        private System.Windows.Forms.Label lb_MISSED;
    }
}
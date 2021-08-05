
namespace AppUI
{
    partial class postsCounterForm
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea5 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend5 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series5 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.label9 = new System.Windows.Forms.Label();
            this.updateChartButton = new System.Windows.Forms.Button();
            this.postsChart = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.label1 = new System.Windows.Forms.Label();
            this.yearLabel = new System.Windows.Forms.Label();
            this.yearComboBox = new System.Windows.Forms.ComboBox();
            this.monthLabel = new System.Windows.Forms.Label();
            this.monthComboBox = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.postsChart)).BeginInit();
            this.SuspendLayout();
            // 
            // label9
            // 
            this.label9.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(96)))), ((int)(((byte)(98)))), ((int)(((byte)(102)))));
            this.label9.Location = new System.Drawing.Point(309, 17);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(133, 23);
            this.label9.TabIndex = 75;
            this.label9.Text = "Posts Counter";
            // 
            // updateChartButton
            // 
            this.updateChartButton.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.updateChartButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.updateChartButton.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold);
            this.updateChartButton.Location = new System.Drawing.Point(203, 338);
            this.updateChartButton.Name = "updateChartButton";
            this.updateChartButton.Size = new System.Drawing.Size(189, 43);
            this.updateChartButton.TabIndex = 74;
            this.updateChartButton.Text = "Update Chart";
            this.updateChartButton.UseVisualStyleBackColor = true;
            this.updateChartButton.Click += new System.EventHandler(this.updateChartButton_Click);
            // 
            // postsChart
            // 
            this.postsChart.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.postsChart.BackColor = System.Drawing.Color.LightGray;
            this.postsChart.BackGradientStyle = System.Windows.Forms.DataVisualization.Charting.GradientStyle.TopBottom;
            chartArea5.AxisX.Interval = 1D;
            chartArea5.AxisX.LabelAutoFitMinFontSize = 8;
            chartArea5.AxisX.LabelStyle.Interval = 1D;
            chartArea5.AxisX.MaximumAutoSize = 100F;
            chartArea5.AxisX2.LabelAutoFitMinFontSize = 8;
            chartArea5.AxisY.LabelAutoFitMinFontSize = 8;
            chartArea5.AxisY2.LabelAutoFitMinFontSize = 8;
            chartArea5.Name = "ChartArea1";
            this.postsChart.ChartAreas.Add(chartArea5);
            legend5.Name = "Legend1";
            this.postsChart.Legends.Add(legend5);
            this.postsChart.Location = new System.Drawing.Point(48, 75);
            this.postsChart.Name = "postsChart";
            series5.ChartArea = "ChartArea1";
            series5.CustomProperties = "PointWidth=0.4";
            series5.IsXValueIndexed = true;
            series5.Legend = "Legend1";
            series5.Name = "Posts";
            series5.XAxisType = System.Windows.Forms.DataVisualization.Charting.AxisType.Secondary;
            series5.YValuesPerPoint = 3;
            this.postsChart.Series.Add(series5);
            this.postsChart.Size = new System.Drawing.Size(699, 241);
            this.postsChart.TabIndex = 73;
            this.postsChart.Text = "chart1";
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(48, 57);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(344, 13);
            this.label1.TabIndex = 76;
            this.label1.Text = "*This graph shows the total number of posts that was made each month";
            // 
            // yearLabel
            // 
            this.yearLabel.AutoSize = true;
            this.yearLabel.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold);
            this.yearLabel.Location = new System.Drawing.Point(407, 338);
            this.yearLabel.Name = "yearLabel";
            this.yearLabel.Size = new System.Drawing.Size(49, 19);
            this.yearLabel.TabIndex = 78;
            this.yearLabel.Text = "Year:";
            // 
            // yearComboBox
            // 
            this.yearComboBox.FormattingEnabled = true;
            this.yearComboBox.Location = new System.Drawing.Point(471, 338);
            this.yearComboBox.Name = "yearComboBox";
            this.yearComboBox.Size = new System.Drawing.Size(121, 21);
            this.yearComboBox.TabIndex = 79;
            this.yearComboBox.SelectedIndexChanged += new System.EventHandler(this.yearComboBox_SelectedIndexChanged);
            // 
            // monthLabel
            // 
            this.monthLabel.AutoSize = true;
            this.monthLabel.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold);
            this.monthLabel.Location = new System.Drawing.Point(407, 365);
            this.monthLabel.Name = "monthLabel";
            this.monthLabel.Size = new System.Drawing.Size(61, 19);
            this.monthLabel.TabIndex = 78;
            this.monthLabel.Text = "Month:";
            // 
            // monthComboBox
            // 
            this.monthComboBox.FormattingEnabled = true;
            this.monthComboBox.Location = new System.Drawing.Point(471, 365);
            this.monthComboBox.Name = "monthComboBox";
            this.monthComboBox.Size = new System.Drawing.Size(121, 21);
            this.monthComboBox.TabIndex = 79;
            this.monthComboBox.SelectedIndexChanged += new System.EventHandler(this.monthComboBox_SelectedIndexChanged);
            // 
            // postsCounterForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(795, 408);
            this.Controls.Add(this.monthComboBox);
            this.Controls.Add(this.yearComboBox);
            this.Controls.Add(this.monthLabel);
            this.Controls.Add(this.yearLabel);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.updateChartButton);
            this.Controls.Add(this.postsChart);
            this.Name = "postsCounterForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "PostCounter";
            this.Load += new System.EventHandler(this.FormPostCounter_Load);
            ((System.ComponentModel.ISupportInitialize)(this.postsChart)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Button updateChartButton;
        private System.Windows.Forms.DataVisualization.Charting.Chart postsChart;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label yearLabel;
        private System.Windows.Forms.ComboBox yearComboBox;
        private System.Windows.Forms.Label monthLabel;
        private System.Windows.Forms.ComboBox monthComboBox;
    }
}
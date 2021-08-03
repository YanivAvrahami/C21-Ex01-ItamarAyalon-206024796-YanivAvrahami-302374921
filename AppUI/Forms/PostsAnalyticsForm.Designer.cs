
namespace AppUI.Forms
{
    partial class PostsAnalyticsForm
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea2 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend2 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series2 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.chartMostLikedPosts = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.chartHighestLiker = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btnLoadMostLikedPosts = new System.Windows.Forms.Button();
            this.btnLoadHighestLiker = new System.Windows.Forms.Button();
            this.label9 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.chartMostLikedPosts)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chartHighestLiker)).BeginInit();
            this.SuspendLayout();
            // 
            // chartMostLikedPosts
            // 
            this.chartMostLikedPosts.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.chartMostLikedPosts.BackColor = System.Drawing.Color.LightGray;
            this.chartMostLikedPosts.BackGradientStyle = System.Windows.Forms.DataVisualization.Charting.GradientStyle.TopBottom;
            chartArea1.Name = "ChartArea1";
            this.chartMostLikedPosts.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.chartMostLikedPosts.Legends.Add(legend1);
            this.chartMostLikedPosts.Location = new System.Drawing.Point(9, 106);
            this.chartMostLikedPosts.Name = "chartMostLikedPosts";
            series1.ChartArea = "ChartArea1";
            series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Point;
            series1.IsXValueIndexed = true;
            series1.Legend = "Legend1";
            series1.Name = "Likes";
            series1.YValuesPerPoint = 2;
            this.chartMostLikedPosts.Series.Add(series1);
            this.chartMostLikedPosts.Size = new System.Drawing.Size(381, 211);
            this.chartMostLikedPosts.TabIndex = 0;
            this.chartMostLikedPosts.Text = "chart1";
            this.chartMostLikedPosts.Click += new System.EventHandler(this.chart1_Click);
            // 
            // chartHighestLiker
            // 
            this.chartHighestLiker.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.chartHighestLiker.BackColor = System.Drawing.Color.LightGray;
            this.chartHighestLiker.BackGradientStyle = System.Windows.Forms.DataVisualization.Charting.GradientStyle.TopBottom;
            chartArea2.Name = "ChartArea1";
            this.chartHighestLiker.ChartAreas.Add(chartArea2);
            legend2.Name = "Legend1";
            this.chartHighestLiker.Legends.Add(legend2);
            this.chartHighestLiker.Location = new System.Drawing.Point(406, 106);
            this.chartHighestLiker.Name = "chartHighestLiker";
            series2.ChartArea = "ChartArea1";
            series2.Legend = "Legend1";
            series2.Name = "Series1";
            this.chartHighestLiker.Series.Add(series2);
            this.chartHighestLiker.Size = new System.Drawing.Size(379, 211);
            this.chartHighestLiker.TabIndex = 0;
            this.chartHighestLiker.Text = "chart1";
            this.chartHighestLiker.Click += new System.EventHandler(this.chart1_Click);
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label1.AutoSize = true;
            this.label1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 15F, System.Drawing.FontStyle.Bold);
            this.label1.Location = new System.Drawing.Point(106, 78);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(170, 25);
            this.label1.TabIndex = 1;
            this.label1.Text = "Most Liked Posts";
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label2.AutoSize = true;
            this.label2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 15F, System.Drawing.FontStyle.Bold);
            this.label2.Location = new System.Drawing.Point(524, 78);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(135, 25);
            this.label2.TabIndex = 1;
            this.label2.Text = "Highest Liker";
            // 
            // btnLoadMostLikedPosts
            // 
            this.btnLoadMostLikedPosts.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnLoadMostLikedPosts.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLoadMostLikedPosts.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold);
            this.btnLoadMostLikedPosts.Location = new System.Drawing.Point(99, 323);
            this.btnLoadMostLikedPosts.Name = "btnLoadMostLikedPosts";
            this.btnLoadMostLikedPosts.Size = new System.Drawing.Size(189, 43);
            this.btnLoadMostLikedPosts.TabIndex = 71;
            this.btnLoadMostLikedPosts.Text = "Load";
            this.btnLoadMostLikedPosts.UseVisualStyleBackColor = true;
            this.btnLoadMostLikedPosts.Click += new System.EventHandler(this.btnLoadMostLikedPosts_Click);
            // 
            // btnLoadHighestLiker
            // 
            this.btnLoadHighestLiker.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnLoadHighestLiker.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLoadHighestLiker.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold);
            this.btnLoadHighestLiker.Location = new System.Drawing.Point(501, 323);
            this.btnLoadHighestLiker.Name = "btnLoadHighestLiker";
            this.btnLoadHighestLiker.Size = new System.Drawing.Size(189, 43);
            this.btnLoadHighestLiker.TabIndex = 71;
            this.btnLoadHighestLiker.Text = "Load";
            this.btnLoadHighestLiker.UseVisualStyleBackColor = true;
            // 
            // label9
            // 
            this.label9.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(96)))), ((int)(((byte)(98)))), ((int)(((byte)(102)))));
            this.label9.Location = new System.Drawing.Point(328, 23);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(145, 23);
            this.label9.TabIndex = 72;
            this.label9.Text = "Posts Analytics";
            this.label9.Click += new System.EventHandler(this.label9_Click);
            // 
            // PostsAnalyticsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(795, 381);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.btnLoadHighestLiker);
            this.Controls.Add(this.btnLoadMostLikedPosts);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.chartHighestLiker);
            this.Controls.Add(this.chartMostLikedPosts);
            this.Name = "PostsAnalyticsForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "PostsAnalytics";
            ((System.ComponentModel.ISupportInitialize)(this.chartMostLikedPosts)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chartHighestLiker)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataVisualization.Charting.Chart chartMostLikedPosts;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartHighestLiker;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnLoadMostLikedPosts;
        private System.Windows.Forms.Button btnLoadHighestLiker;
        private System.Windows.Forms.Label label9;
    }
}
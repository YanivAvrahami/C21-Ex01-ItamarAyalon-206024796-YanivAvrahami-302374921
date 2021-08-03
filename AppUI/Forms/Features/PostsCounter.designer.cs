
namespace AppUI
{
    partial class PostsCounter
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea2 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend2 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series2 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.chartPostsCounter = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.btnLoadMostLikedPosts = new System.Windows.Forms.Button();
            this.label9 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.chartPostsCounter)).BeginInit();
            this.SuspendLayout();
            // 
            // chartPostsCounter
            // 
            this.chartPostsCounter.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.chartPostsCounter.BackColor = System.Drawing.Color.LightGray;
            this.chartPostsCounter.BackGradientStyle = System.Windows.Forms.DataVisualization.Charting.GradientStyle.TopBottom;
            chartArea2.Name = "ChartArea1";
            this.chartPostsCounter.ChartAreas.Add(chartArea2);
            legend2.Name = "Legend1";
            this.chartPostsCounter.Legends.Add(legend2);
            this.chartPostsCounter.Location = new System.Drawing.Point(67, 106);
            this.chartPostsCounter.Name = "chartPostsCounter";
            series2.ChartArea = "ChartArea1";
            series2.IsXValueIndexed = true;
            series2.Legend = "Legend1";
            series2.Name = "Posts";
            series2.YValuesPerPoint = 2;
            this.chartPostsCounter.Series.Add(series2);
            this.chartPostsCounter.Size = new System.Drawing.Size(699, 211);
            this.chartPostsCounter.TabIndex = 0;
            this.chartPostsCounter.Text = "chart1";
            this.chartPostsCounter.Click += new System.EventHandler(this.chart1_Click);
            // 
            // btnLoadMostLikedPosts
            // 
            this.btnLoadMostLikedPosts.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnLoadMostLikedPosts.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLoadMostLikedPosts.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold);
            this.btnLoadMostLikedPosts.Location = new System.Drawing.Point(312, 326);
            this.btnLoadMostLikedPosts.Name = "btnLoadMostLikedPosts";
            this.btnLoadMostLikedPosts.Size = new System.Drawing.Size(189, 43);
            this.btnLoadMostLikedPosts.TabIndex = 71;
            this.btnLoadMostLikedPosts.Text = "Load";
            this.btnLoadMostLikedPosts.UseVisualStyleBackColor = true;
            this.btnLoadMostLikedPosts.Click += new System.EventHandler(this.btnLoadMostLikedPosts_Click);
            // 
            // label9
            // 
            this.label9.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(96)))), ((int)(((byte)(98)))), ((int)(((byte)(102)))));
            this.label9.Location = new System.Drawing.Point(328, 23);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(133, 23);
            this.label9.TabIndex = 72;
            this.label9.Text = "Posts Counter";
            this.label9.Click += new System.EventHandler(this.label9_Click);
            // 
            // PostsCounter
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(795, 381);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.btnLoadMostLikedPosts);
            this.Controls.Add(this.chartPostsCounter);
            this.Name = "PostsCounter";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "PostsCounter";
            ((System.ComponentModel.ISupportInitialize)(this.chartPostsCounter)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataVisualization.Charting.Chart chartPostsCounter;
        private System.Windows.Forms.Button btnLoadMostLikedPosts;
        private System.Windows.Forms.Label label9;
    }
}
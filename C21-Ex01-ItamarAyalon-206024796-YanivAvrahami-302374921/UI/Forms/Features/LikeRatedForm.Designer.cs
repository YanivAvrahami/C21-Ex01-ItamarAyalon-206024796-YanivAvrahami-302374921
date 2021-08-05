
namespace UI
{
    partial class likeRatedForm
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
            this.btnFetchInfo = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label2 = new System.Windows.Forms.Label();
            this.labelMostLiked = new System.Windows.Forms.Label();
            this.pictureBoxMostLiked = new System.Windows.Forms.PictureBox();
            this.tableLayoutFriends = new System.Windows.Forms.TableLayoutPanel();
            this.labelTotalPhotos = new System.Windows.Forms.Label();
            this.labelAvgLikes = new System.Windows.Forms.Label();
            this.labelAvgComments = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label4 = new System.Windows.Forms.Label();
            this.labelLeastLiked = new System.Windows.Forms.Label();
            this.pictureBoxLeastLiked = new System.Windows.Forms.PictureBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.label6 = new System.Windows.Forms.Label();
            this.labelMostComments = new System.Windows.Forms.Label();
            this.pictureBoxMostComments = new System.Windows.Forms.PictureBox();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.label7 = new System.Windows.Forms.Label();
            this.labelLeastComments = new System.Windows.Forms.Label();
            this.pictureBoxLeastComments = new System.Windows.Forms.PictureBox();
            this.label8 = new System.Windows.Forms.Label();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.dateTimePickerStart = new System.Windows.Forms.DateTimePicker();
            this.dateTimePickerEnd = new System.Windows.Forms.DateTimePicker();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxMostLiked)).BeginInit();
            this.tableLayoutFriends.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxLeastLiked)).BeginInit();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxMostComments)).BeginInit();
            this.groupBox4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxLeastComments)).BeginInit();
            this.groupBox5.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnFetchInfo
            // 
            this.btnFetchInfo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnFetchInfo.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold);
            this.btnFetchInfo.Location = new System.Drawing.Point(33, 86);
            this.btnFetchInfo.Name = "btnFetchInfo";
            this.btnFetchInfo.Size = new System.Drawing.Size(162, 43);
            this.btnFetchInfo.TabIndex = 65;
            this.btnFetchInfo.Text = "Fetch";
            this.btnFetchInfo.UseVisualStyleBackColor = true;
            this.btnFetchInfo.Click += new System.EventHandler(this.btnFetchInfo_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.labelMostLiked);
            this.groupBox1.Controls.Add(this.pictureBoxMostLiked);
            this.groupBox1.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(248, 249);
            this.groupBox1.TabIndex = 78;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Most Liked Photo";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(27, 29);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(80, 19);
            this.label2.TabIndex = 80;
            this.label2.Text = "Created :";
            // 
            // labelMostLiked
            // 
            this.labelMostLiked.AutoSize = true;
            this.labelMostLiked.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold);
            this.labelMostLiked.Location = new System.Drawing.Point(113, 29);
            this.labelMostLiked.Name = "labelMostLiked";
            this.labelMostLiked.Size = new System.Drawing.Size(95, 19);
            this.labelMostLiked.TabIndex = 79;
            this.labelMostLiked.Text = "00/00/0000";
            // 
            // pictureBoxMostLiked
            // 
            this.pictureBoxMostLiked.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBoxMostLiked.Location = new System.Drawing.Point(6, 56);
            this.pictureBoxMostLiked.Name = "pictureBoxMostLiked";
            this.pictureBoxMostLiked.Size = new System.Drawing.Size(236, 187);
            this.pictureBoxMostLiked.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBoxMostLiked.TabIndex = 77;
            this.pictureBoxMostLiked.TabStop = false;
            // 
            // tableLayoutFriends
            // 
            this.tableLayoutFriends.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.tableLayoutFriends.BackColor = System.Drawing.Color.Transparent;
            this.tableLayoutFriends.CellBorderStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.Single;
            this.tableLayoutFriends.ColumnCount = 2;
            this.tableLayoutFriends.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 45.38153F));
            this.tableLayoutFriends.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 54.61847F));
            this.tableLayoutFriends.Controls.Add(this.labelTotalPhotos, 1, 0);
            this.tableLayoutFriends.Controls.Add(this.labelAvgLikes, 1, 1);
            this.tableLayoutFriends.Controls.Add(this.labelAvgComments, 1, 2);
            this.tableLayoutFriends.Controls.Add(this.label3, 0, 2);
            this.tableLayoutFriends.Controls.Add(this.label1, 0, 1);
            this.tableLayoutFriends.Controls.Add(this.label5, 0, 0);
            this.tableLayoutFriends.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tableLayoutFriends.Location = new System.Drawing.Point(520, 324);
            this.tableLayoutFriends.Name = "tableLayoutFriends";
            this.tableLayoutFriends.RowCount = 3;
            this.tableLayoutFriends.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tableLayoutFriends.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tableLayoutFriends.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tableLayoutFriends.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tableLayoutFriends.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tableLayoutFriends.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tableLayoutFriends.Size = new System.Drawing.Size(250, 192);
            this.tableLayoutFriends.TabIndex = 79;
            // 
            // labelTotalPhotos
            // 
            this.labelTotalPhotos.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.labelTotalPhotos.AutoSize = true;
            this.labelTotalPhotos.Location = new System.Drawing.Point(117, 1);
            this.labelTotalPhotos.Name = "labelTotalPhotos";
            this.labelTotalPhotos.Size = new System.Drawing.Size(129, 62);
            this.labelTotalPhotos.TabIndex = 0;
            this.labelTotalPhotos.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // labelAvgLikes
            // 
            this.labelAvgLikes.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.labelAvgLikes.AutoSize = true;
            this.labelAvgLikes.Location = new System.Drawing.Point(117, 64);
            this.labelAvgLikes.Name = "labelAvgLikes";
            this.labelAvgLikes.Size = new System.Drawing.Size(129, 62);
            this.labelAvgLikes.TabIndex = 0;
            this.labelAvgLikes.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // labelAvgComments
            // 
            this.labelAvgComments.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.labelAvgComments.AutoSize = true;
            this.labelAvgComments.Location = new System.Drawing.Point(117, 127);
            this.labelAvgComments.Name = "labelAvgComments";
            this.labelAvgComments.Size = new System.Drawing.Size(129, 64);
            this.labelAvgComments.TabIndex = 0;
            this.labelAvgComments.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(4, 127);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(106, 64);
            this.label3.TabIndex = 0;
            this.label3.Text = "Avg Comments";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(4, 64);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(106, 62);
            this.label1.TabIndex = 0;
            this.label1.Text = "Avg Likes";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label5
            // 
            this.label5.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(4, 1);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(106, 62);
            this.label5.TabIndex = 0;
            this.label5.Text = "Total Photos Loaded";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // groupBox2
            // 
            this.groupBox2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.labelLeastLiked);
            this.groupBox2.Controls.Add(this.pictureBoxLeastLiked);
            this.groupBox2.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold);
            this.groupBox2.Location = new System.Drawing.Point(266, 12);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(248, 249);
            this.groupBox2.TabIndex = 78;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Least Liked Photo";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(27, 29);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(80, 19);
            this.label4.TabIndex = 80;
            this.label4.Text = "Created :";
            // 
            // labelLeastLiked
            // 
            this.labelLeastLiked.AutoSize = true;
            this.labelLeastLiked.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold);
            this.labelLeastLiked.Location = new System.Drawing.Point(113, 29);
            this.labelLeastLiked.Name = "labelLeastLiked";
            this.labelLeastLiked.Size = new System.Drawing.Size(95, 19);
            this.labelLeastLiked.TabIndex = 79;
            this.labelLeastLiked.Text = "00/00/0000";
            // 
            // pictureBoxLeastLiked
            // 
            this.pictureBoxLeastLiked.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBoxLeastLiked.Location = new System.Drawing.Point(6, 56);
            this.pictureBoxLeastLiked.Name = "pictureBoxLeastLiked";
            this.pictureBoxLeastLiked.Size = new System.Drawing.Size(236, 187);
            this.pictureBoxLeastLiked.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBoxLeastLiked.TabIndex = 77;
            this.pictureBoxLeastLiked.TabStop = false;
            // 
            // groupBox3
            // 
            this.groupBox3.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.groupBox3.Controls.Add(this.label6);
            this.groupBox3.Controls.Add(this.labelMostComments);
            this.groupBox3.Controls.Add(this.pictureBoxMostComments);
            this.groupBox3.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold);
            this.groupBox3.Location = new System.Drawing.Point(12, 267);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(248, 249);
            this.groupBox3.TabIndex = 78;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Has Most Comments";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(27, 29);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(80, 19);
            this.label6.TabIndex = 80;
            this.label6.Text = "Created :";
            // 
            // labelMostComments
            // 
            this.labelMostComments.AutoSize = true;
            this.labelMostComments.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold);
            this.labelMostComments.Location = new System.Drawing.Point(113, 29);
            this.labelMostComments.Name = "labelMostComments";
            this.labelMostComments.Size = new System.Drawing.Size(95, 19);
            this.labelMostComments.TabIndex = 79;
            this.labelMostComments.Text = "00/00/0000";
            // 
            // pictureBoxMostComments
            // 
            this.pictureBoxMostComments.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBoxMostComments.Location = new System.Drawing.Point(6, 56);
            this.pictureBoxMostComments.Name = "pictureBoxMostComments";
            this.pictureBoxMostComments.Size = new System.Drawing.Size(236, 187);
            this.pictureBoxMostComments.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBoxMostComments.TabIndex = 77;
            this.pictureBoxMostComments.TabStop = false;
            // 
            // groupBox4
            // 
            this.groupBox4.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.groupBox4.Controls.Add(this.label7);
            this.groupBox4.Controls.Add(this.labelLeastComments);
            this.groupBox4.Controls.Add(this.pictureBoxLeastComments);
            this.groupBox4.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold);
            this.groupBox4.Location = new System.Drawing.Point(266, 267);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(248, 249);
            this.groupBox4.TabIndex = 78;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Has Least Comments";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(27, 29);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(80, 19);
            this.label7.TabIndex = 80;
            this.label7.Text = "Created :";
            // 
            // labelLeastComments
            // 
            this.labelLeastComments.AutoSize = true;
            this.labelLeastComments.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold);
            this.labelLeastComments.Location = new System.Drawing.Point(113, 29);
            this.labelLeastComments.Name = "labelLeastComments";
            this.labelLeastComments.Size = new System.Drawing.Size(95, 19);
            this.labelLeastComments.TabIndex = 79;
            this.labelLeastComments.Text = "00/00/0000";
            // 
            // pictureBoxLeastComments
            // 
            this.pictureBoxLeastComments.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBoxLeastComments.Location = new System.Drawing.Point(6, 56);
            this.pictureBoxLeastComments.Name = "pictureBoxLeastComments";
            this.pictureBoxLeastComments.Size = new System.Drawing.Size(236, 187);
            this.pictureBoxLeastComments.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBoxLeastComments.TabIndex = 77;
            this.pictureBoxLeastComments.TabStop = false;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold);
            this.label8.ForeColor = System.Drawing.Color.Red;
            this.label8.Location = new System.Drawing.Point(4, 16);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(214, 57);
            this.label8.TabIndex = 80;
            this.label8.Text = "It may take a while\r\nto process the images,\r\nand spend a lot of requests";
            this.label8.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // groupBox5
            // 
            this.groupBox5.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.groupBox5.Controls.Add(this.label8);
            this.groupBox5.Controls.Add(this.btnFetchInfo);
            this.groupBox5.Location = new System.Drawing.Point(530, 35);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(223, 138);
            this.groupBox5.TabIndex = 81;
            this.groupBox5.TabStop = false;
            // 
            // dateTimePickerStart
            // 
            this.dateTimePickerStart.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold);
            this.dateTimePickerStart.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePickerStart.Location = new System.Drawing.Point(58, 31);
            this.dateTimePickerStart.Name = "dateTimePickerStart";
            this.dateTimePickerStart.ShowCheckBox = true;
            this.dateTimePickerStart.Size = new System.Drawing.Size(162, 27);
            this.dateTimePickerStart.TabIndex = 82;
            // 
            // dateTimePickerEnd
            // 
            this.dateTimePickerEnd.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold);
            this.dateTimePickerEnd.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePickerEnd.Location = new System.Drawing.Point(58, 102);
            this.dateTimePickerEnd.Name = "dateTimePickerEnd";
            this.dateTimePickerEnd.ShowCheckBox = true;
            this.dateTimePickerEnd.Size = new System.Drawing.Size(162, 27);
            this.dateTimePickerEnd.TabIndex = 82;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold);
            this.label9.Location = new System.Drawing.Point(21, 9);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(92, 19);
            this.label9.TabIndex = 83;
            this.label9.Text = "From Date:";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold);
            this.label10.Location = new System.Drawing.Point(21, 80);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(85, 19);
            this.label10.TabIndex = 83;
            this.label10.Text = "Until Date:";
            // 
            // panel1
            // 
            this.panel1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.panel1.Controls.Add(this.label9);
            this.panel1.Controls.Add(this.label10);
            this.panel1.Controls.Add(this.dateTimePickerEnd);
            this.panel1.Controls.Add(this.dateTimePickerStart);
            this.panel1.Location = new System.Drawing.Point(520, 179);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(250, 139);
            this.panel1.TabIndex = 85;
            // 
            // likeRatedForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(780, 523);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.groupBox5);
            this.Controls.Add(this.tableLayoutFriends);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "likeRatedForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Like Rated";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxMostLiked)).EndInit();
            this.tableLayoutFriends.ResumeLayout(false);
            this.tableLayoutFriends.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxLeastLiked)).EndInit();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxMostComments)).EndInit();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxLeastComments)).EndInit();
            this.groupBox5.ResumeLayout(false);
            this.groupBox5.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnFetchInfo;
        private System.Windows.Forms.PictureBox pictureBoxMostLiked;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label labelMostLiked;
        private System.Windows.Forms.TableLayoutPanel tableLayoutFriends;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label labelTotalPhotos;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label labelAvgLikes;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label labelAvgComments;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label labelLeastLiked;
        private System.Windows.Forms.PictureBox pictureBoxLeastLiked;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Label labelMostComments;
        private System.Windows.Forms.PictureBox pictureBoxMostComments;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Label labelLeastComments;
        private System.Windows.Forms.PictureBox pictureBoxLeastComments;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.DateTimePicker dateTimePickerStart;
        private System.Windows.Forms.DateTimePicker dateTimePickerEnd;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Panel panel1;
    }
}
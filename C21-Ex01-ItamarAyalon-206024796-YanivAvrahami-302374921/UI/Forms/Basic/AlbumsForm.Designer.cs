
namespace UI
{
    partial class albumsForm
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
            this.label3 = new System.Windows.Forms.Label();
            this.pictureBoxCover = new System.Windows.Forms.PictureBox();
            this.labelCreateDate = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.labelAlbumsCounted = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btnFetchAlbums = new System.Windows.Forms.Button();
            this.labelName = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.tableLayoutFriends = new System.Windows.Forms.TableLayoutPanel();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.labelPhotos = new System.Windows.Forms.Label();
            this.labelPrivacy = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.listBoxAlbums = new System.Windows.Forms.ListBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnOpenAlbum = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxCover)).BeginInit();
            this.tableLayoutFriends.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(4, 60);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(103, 58);
            this.label3.TabIndex = 0;
            this.label3.Text = "Create Date";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // pictureBoxCover
            // 
            this.pictureBoxCover.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.pictureBoxCover.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBoxCover.Location = new System.Drawing.Point(242, 50);
            this.pictureBoxCover.Name = "pictureBoxCover";
            this.pictureBoxCover.Size = new System.Drawing.Size(326, 255);
            this.pictureBoxCover.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBoxCover.TabIndex = 76;
            this.pictureBoxCover.TabStop = false;
            // 
            // labelCreateDate
            // 
            this.labelCreateDate.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.labelCreateDate.AutoSize = true;
            this.labelCreateDate.Location = new System.Drawing.Point(114, 60);
            this.labelCreateDate.Name = "labelCreateDate";
            this.labelCreateDate.Size = new System.Drawing.Size(153, 58);
            this.labelCreateDate.TabIndex = 0;
            this.labelCreateDate.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(4, 1);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(103, 58);
            this.label1.TabIndex = 0;
            this.label1.Text = "Name";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // labelAlbumsCounted
            // 
            this.labelAlbumsCounted.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.labelAlbumsCounted.AutoSize = true;
            this.labelAlbumsCounted.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold);
            this.labelAlbumsCounted.Location = new System.Drawing.Point(127, 363);
            this.labelAlbumsCounted.Name = "labelAlbumsCounted";
            this.labelAlbumsCounted.Size = new System.Drawing.Size(18, 19);
            this.labelAlbumsCounted.TabIndex = 75;
            this.labelAlbumsCounted.Text = "0";
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold);
            this.label2.Location = new System.Drawing.Point(12, 363);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(109, 19);
            this.label2.TabIndex = 74;
            this.label2.Text = "Events found:";
            // 
            // btnFetchAlbums
            // 
            this.btnFetchAlbums.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnFetchAlbums.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnFetchAlbums.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold);
            this.btnFetchAlbums.Location = new System.Drawing.Point(57, 30);
            this.btnFetchAlbums.Name = "btnFetchAlbums";
            this.btnFetchAlbums.Size = new System.Drawing.Size(162, 43);
            this.btnFetchAlbums.TabIndex = 64;
            this.btnFetchAlbums.Text = "Fetch";
            this.btnFetchAlbums.UseVisualStyleBackColor = true;
            this.btnFetchAlbums.Click += new System.EventHandler(this.btnFetchAlbums_Click);
            // 
            // labelName
            // 
            this.labelName.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.labelName.AutoSize = true;
            this.labelName.Location = new System.Drawing.Point(114, 1);
            this.labelName.Name = "labelName";
            this.labelName.Size = new System.Drawing.Size(153, 58);
            this.labelName.TabIndex = 0;
            this.labelName.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label9
            // 
            this.label9.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(96)))), ((int)(((byte)(98)))), ((int)(((byte)(102)))));
            this.label9.Location = new System.Drawing.Point(395, 11);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(79, 23);
            this.label9.TabIndex = 72;
            this.label9.Text = "Albums";
            this.label9.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // tableLayoutFriends
            // 
            this.tableLayoutFriends.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.tableLayoutFriends.BackColor = System.Drawing.Color.Transparent;
            this.tableLayoutFriends.CellBorderStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.Single;
            this.tableLayoutFriends.ColumnCount = 2;
            this.tableLayoutFriends.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 40.74074F));
            this.tableLayoutFriends.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 59.25926F));
            this.tableLayoutFriends.Controls.Add(this.label1, 0, 0);
            this.tableLayoutFriends.Controls.Add(this.labelName, 1, 0);
            this.tableLayoutFriends.Controls.Add(this.label3, 0, 1);
            this.tableLayoutFriends.Controls.Add(this.labelCreateDate, 1, 1);
            this.tableLayoutFriends.Controls.Add(this.label4, 0, 2);
            this.tableLayoutFriends.Controls.Add(this.label5, 0, 3);
            this.tableLayoutFriends.Controls.Add(this.labelPhotos, 1, 2);
            this.tableLayoutFriends.Controls.Add(this.labelPrivacy, 1, 3);
            this.tableLayoutFriends.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tableLayoutFriends.Location = new System.Drawing.Point(582, 140);
            this.tableLayoutFriends.Name = "tableLayoutFriends";
            this.tableLayoutFriends.RowCount = 4;
            this.tableLayoutFriends.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tableLayoutFriends.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tableLayoutFriends.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tableLayoutFriends.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tableLayoutFriends.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tableLayoutFriends.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tableLayoutFriends.Size = new System.Drawing.Size(271, 238);
            this.tableLayoutFriends.TabIndex = 70;
            // 
            // label4
            // 
            this.label4.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(4, 119);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(103, 58);
            this.label4.TabIndex = 0;
            this.label4.Text = "Photos";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label5
            // 
            this.label5.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(4, 178);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(103, 59);
            this.label5.TabIndex = 0;
            this.label5.Text = "Privacy";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // labelPhotos
            // 
            this.labelPhotos.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.labelPhotos.AutoSize = true;
            this.labelPhotos.Location = new System.Drawing.Point(114, 119);
            this.labelPhotos.Name = "labelPhotos";
            this.labelPhotos.Size = new System.Drawing.Size(153, 58);
            this.labelPhotos.TabIndex = 0;
            this.labelPhotos.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // labelPrivacy
            // 
            this.labelPrivacy.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.labelPrivacy.AutoSize = true;
            this.labelPrivacy.Location = new System.Drawing.Point(114, 178);
            this.labelPrivacy.Name = "labelPrivacy";
            this.labelPrivacy.Size = new System.Drawing.Size(153, 59);
            this.labelPrivacy.TabIndex = 0;
            this.labelPrivacy.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.groupBox1.BackColor = System.Drawing.Color.Transparent;
            this.groupBox1.Controls.Add(this.btnFetchAlbums);
            this.groupBox1.Location = new System.Drawing.Point(583, 44);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(271, 90);
            this.groupBox1.TabIndex = 77;
            this.groupBox1.TabStop = false;
            // 
            // listBoxAlbums
            // 
            this.listBoxAlbums.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.listBoxAlbums.BackColor = System.Drawing.Color.White;
            this.listBoxAlbums.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listBoxAlbums.FormattingEnabled = true;
            this.listBoxAlbums.ItemHeight = 19;
            this.listBoxAlbums.Location = new System.Drawing.Point(11, 50);
            this.listBoxAlbums.Name = "listBoxAlbums";
            this.listBoxAlbums.Size = new System.Drawing.Size(218, 308);
            this.listBoxAlbums.TabIndex = 71;
            this.listBoxAlbums.SelectedIndexChanged += new System.EventHandler(this.listBoxAlbums_SelectedIndexChanged);
            // 
            // groupBox2
            // 
            this.groupBox2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.groupBox2.BackColor = System.Drawing.Color.Transparent;
            this.groupBox2.Controls.Add(this.btnOpenAlbum);
            this.groupBox2.Location = new System.Drawing.Point(242, 305);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(326, 72);
            this.groupBox2.TabIndex = 77;
            this.groupBox2.TabStop = false;
            // 
            // btnOpenAlbum
            // 
            this.btnOpenAlbum.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnOpenAlbum.Enabled = false;
            this.btnOpenAlbum.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnOpenAlbum.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold);
            this.btnOpenAlbum.Location = new System.Drawing.Point(90, 17);
            this.btnOpenAlbum.Name = "btnOpenAlbum";
            this.btnOpenAlbum.Size = new System.Drawing.Size(152, 43);
            this.btnOpenAlbum.TabIndex = 64;
            this.btnOpenAlbum.Text = "Open Album";
            this.btnOpenAlbum.UseVisualStyleBackColor = true;
            this.btnOpenAlbum.Click += new System.EventHandler(this.btnOpenAlbum_Click);
            // 
            // albumsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(864, 391);
            this.Controls.Add(this.pictureBoxCover);
            this.Controls.Add(this.labelAlbumsCounted);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.listBoxAlbums);
            this.Controls.Add(this.tableLayoutFriends);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "albumsForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Albums";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxCover)).EndInit();
            this.tableLayoutFriends.ResumeLayout(false);
            this.tableLayoutFriends.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.PictureBox pictureBoxCover;
        private System.Windows.Forms.Label labelCreateDate;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label labelAlbumsCounted;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnFetchAlbums;
        private System.Windows.Forms.Label labelName;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TableLayoutPanel tableLayoutFriends;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ListBox listBoxAlbums;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btnOpenAlbum;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label labelPhotos;
        private System.Windows.Forms.Label labelPrivacy;
    }
}

namespace AppUI
{
    partial class postsForm
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnFetchPosts = new System.Windows.Forms.Button();
            this.labelPostsCounted = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.labelPostedDate = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.labelName = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.listBoxPosts = new System.Windows.Forms.ListBox();
            this.tableLayoutFriends = new System.Windows.Forms.TableLayoutPanel();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.labelComments = new System.Windows.Forms.Label();
            this.textBoxDescption = new System.Windows.Forms.TextBox();
            this.listBoxComments = new System.Windows.Forms.ListBox();
            this.groupBox1.SuspendLayout();
            this.tableLayoutFriends.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.groupBox1.BackColor = System.Drawing.Color.Transparent;
            this.groupBox1.Controls.Add(this.btnFetchPosts);
            this.groupBox1.Location = new System.Drawing.Point(583, 46);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(271, 61);
            this.groupBox1.TabIndex = 77;
            this.groupBox1.TabStop = false;
            // 
            // btnFetchPosts
            // 
            this.btnFetchPosts.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnFetchPosts.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnFetchPosts.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold);
            this.btnFetchPosts.Location = new System.Drawing.Point(59, 11);
            this.btnFetchPosts.Name = "btnFetchPosts";
            this.btnFetchPosts.Size = new System.Drawing.Size(162, 43);
            this.btnFetchPosts.TabIndex = 64;
            this.btnFetchPosts.Text = "Fetch";
            this.btnFetchPosts.UseVisualStyleBackColor = true;
            this.btnFetchPosts.Click += new System.EventHandler(this.btnFetchPosts_Click);
            // 
            // labelPostsCounted
            // 
            this.labelPostsCounted.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.labelPostsCounted.AutoSize = true;
            this.labelPostsCounted.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold);
            this.labelPostsCounted.Location = new System.Drawing.Point(115, 363);
            this.labelPostsCounted.Name = "labelPostsCounted";
            this.labelPostsCounted.Size = new System.Drawing.Size(18, 19);
            this.labelPostsCounted.TabIndex = 75;
            this.labelPostsCounted.Text = "0";
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold);
            this.label2.Location = new System.Drawing.Point(12, 363);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(97, 19);
            this.label2.TabIndex = 74;
            this.label2.Text = "Posts found:";
            // 
            // labelPostedDate
            // 
            this.labelPostedDate.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.labelPostedDate.AutoSize = true;
            this.labelPostedDate.Location = new System.Drawing.Point(114, 36);
            this.labelPostedDate.Name = "labelPostedDate";
            this.labelPostedDate.Size = new System.Drawing.Size(153, 34);
            this.labelPostedDate.TabIndex = 0;
            this.labelPostedDate.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(4, 1);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(103, 34);
            this.label1.TabIndex = 0;
            this.label1.Text = "Name";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // labelName
            // 
            this.labelName.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.labelName.AutoSize = true;
            this.labelName.Location = new System.Drawing.Point(114, 1);
            this.labelName.Name = "labelName";
            this.labelName.Size = new System.Drawing.Size(153, 34);
            this.labelName.TabIndex = 0;
            this.labelName.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label9
            // 
            this.label9.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(96)))), ((int)(((byte)(98)))), ((int)(((byte)(102)))));
            this.label9.Location = new System.Drawing.Point(395, 13);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(55, 23);
            this.label9.TabIndex = 72;
            this.label9.Text = "Posts";
            this.label9.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // listBoxPosts
            // 
            this.listBoxPosts.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.listBoxPosts.BackColor = System.Drawing.Color.White;
            this.listBoxPosts.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listBoxPosts.FormattingEnabled = true;
            this.listBoxPosts.ItemHeight = 19;
            this.listBoxPosts.Location = new System.Drawing.Point(11, 52);
            this.listBoxPosts.Name = "listBoxPosts";
            this.listBoxPosts.Size = new System.Drawing.Size(218, 308);
            this.listBoxPosts.TabIndex = 71;
            this.listBoxPosts.SelectedIndexChanged += new System.EventHandler(this.listBoxPosts_SelectedIndexChanged);
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
            this.tableLayoutFriends.Controls.Add(this.labelPostedDate, 1, 1);
            this.tableLayoutFriends.Controls.Add(this.label4, 0, 2);
            this.tableLayoutFriends.Controls.Add(this.labelComments, 1, 2);
            this.tableLayoutFriends.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tableLayoutFriends.Location = new System.Drawing.Point(582, 113);
            this.tableLayoutFriends.Name = "tableLayoutFriends";
            this.tableLayoutFriends.RowCount = 3;
            this.tableLayoutFriends.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tableLayoutFriends.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tableLayoutFriends.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tableLayoutFriends.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tableLayoutFriends.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tableLayoutFriends.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tableLayoutFriends.Size = new System.Drawing.Size(271, 107);
            this.tableLayoutFriends.TabIndex = 70;
            // 
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(4, 36);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(103, 34);
            this.label3.TabIndex = 0;
            this.label3.Text = "Posted Date";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label4
            // 
            this.label4.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(4, 71);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(103, 35);
            this.label4.TabIndex = 0;
            this.label4.Text = "Comments";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // labelComments
            // 
            this.labelComments.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.labelComments.AutoSize = true;
            this.labelComments.Location = new System.Drawing.Point(114, 71);
            this.labelComments.Name = "labelComments";
            this.labelComments.Size = new System.Drawing.Size(153, 35);
            this.labelComments.TabIndex = 0;
            this.labelComments.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // textBoxDescption
            // 
            this.textBoxDescption.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.textBoxDescption.BackColor = System.Drawing.Color.White;
            this.textBoxDescption.Enabled = false;
            this.textBoxDescption.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxDescption.Location = new System.Drawing.Point(242, 52);
            this.textBoxDescption.Multiline = true;
            this.textBoxDescption.Name = "textBoxDescption";
            this.textBoxDescption.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.textBoxDescption.Size = new System.Drawing.Size(326, 168);
            this.textBoxDescption.TabIndex = 73;
            // 
            // listBoxComments
            // 
            this.listBoxComments.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.listBoxComments.BackColor = System.Drawing.Color.White;
            this.listBoxComments.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listBoxComments.FormattingEnabled = true;
            this.listBoxComments.ItemHeight = 19;
            this.listBoxComments.Location = new System.Drawing.Point(242, 226);
            this.listBoxComments.Name = "listBoxComments";
            this.listBoxComments.Size = new System.Drawing.Size(612, 156);
            this.listBoxComments.TabIndex = 71;
            // 
            // postsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(864, 391);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.labelPostsCounted);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.listBoxComments);
            this.Controls.Add(this.listBoxPosts);
            this.Controls.Add(this.tableLayoutFriends);
            this.Controls.Add(this.textBoxDescption);
            this.Name = "postsForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Posts";
            this.groupBox1.ResumeLayout(false);
            this.tableLayoutFriends.ResumeLayout(false);
            this.tableLayoutFriends.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnFetchPosts;
        private System.Windows.Forms.Label labelPostsCounted;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label labelPostedDate;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label labelName;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.ListBox listBoxPosts;
        private System.Windows.Forms.TableLayoutPanel tableLayoutFriends;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBoxDescption;
        private System.Windows.Forms.ListBox listBoxComments;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label labelComments;
    }
}
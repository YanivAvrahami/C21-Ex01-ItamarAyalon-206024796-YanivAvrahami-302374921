
namespace AppUI
{
    partial class PostsForm
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
            this.textBoxPosts = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.listBoxPosts = new System.Windows.Forms.ListBox();
            this.tableLayoutPanelPosts = new System.Windows.Forms.TableLayoutPanel();
            this.labelPostDate = new System.Windows.Forms.Label();
            this.labelPostCreator = new System.Windows.Forms.Label();
            this.labelPostLikes = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.tableLayoutPanelPosts.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(242)))), ((int)(((byte)(245)))));
            this.panel1.Controls.Add(this.textBoxPosts);
            this.panel1.Controls.Add(this.label9);
            this.panel1.Controls.Add(this.listBoxPosts);
            this.panel1.Controls.Add(this.tableLayoutPanelPosts);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1024, 487);
            this.panel1.TabIndex = 56;
            // 
            // textBoxPosts
            // 
            this.textBoxPosts.BackColor = System.Drawing.Color.White;
            this.textBoxPosts.Location = new System.Drawing.Point(285, 125);
            this.textBoxPosts.Multiline = true;
            this.textBoxPosts.Name = "textBoxPosts";
            this.textBoxPosts.Size = new System.Drawing.Size(375, 294);
            this.textBoxPosts.TabIndex = 59;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(96)))), ((int)(((byte)(98)))), ((int)(((byte)(102)))));
            this.label9.Location = new System.Drawing.Point(462, 26);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(55, 23);
            this.label9.TabIndex = 58;
            this.label9.Text = "Posts";
            // 
            // listBoxPosts
            // 
            this.listBoxPosts.BackColor = System.Drawing.Color.White;
            this.listBoxPosts.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listBoxPosts.FormattingEnabled = true;
            this.listBoxPosts.ItemHeight = 18;
            this.listBoxPosts.Location = new System.Drawing.Point(41, 90);
            this.listBoxPosts.Name = "listBoxPosts";
            this.listBoxPosts.Size = new System.Drawing.Size(222, 364);
            this.listBoxPosts.TabIndex = 57;
            // 
            // tableLayoutPanelPosts
            // 
            this.tableLayoutPanelPosts.CellBorderStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.Single;
            this.tableLayoutPanelPosts.ColumnCount = 2;
            this.tableLayoutPanelPosts.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanelPosts.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanelPosts.Controls.Add(this.labelPostDate, 1, 0);
            this.tableLayoutPanelPosts.Controls.Add(this.labelPostCreator, 1, 1);
            this.tableLayoutPanelPosts.Controls.Add(this.labelPostLikes, 1, 2);
            this.tableLayoutPanelPosts.Controls.Add(this.label1, 0, 0);
            this.tableLayoutPanelPosts.Controls.Add(this.label2, 0, 1);
            this.tableLayoutPanelPosts.Controls.Add(this.label3, 0, 2);
            this.tableLayoutPanelPosts.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tableLayoutPanelPosts.Location = new System.Drawing.Point(677, 194);
            this.tableLayoutPanelPosts.Name = "tableLayoutPanelPosts";
            this.tableLayoutPanelPosts.RowCount = 3;
            this.tableLayoutPanelPosts.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanelPosts.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanelPosts.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanelPosts.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanelPosts.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanelPosts.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanelPosts.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanelPosts.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanelPosts.Size = new System.Drawing.Size(306, 156);
            this.tableLayoutPanelPosts.TabIndex = 56;
            // 
            // labelPostDate
            // 
            this.labelPostDate.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.labelPostDate.AutoSize = true;
            this.labelPostDate.Location = new System.Drawing.Point(156, 33);
            this.labelPostDate.Name = "labelPostDate";
            this.labelPostDate.Size = new System.Drawing.Size(43, 18);
            this.labelPostDate.TabIndex = 0;
            this.labelPostDate.Text = "Date";
            this.labelPostDate.Click += new System.EventHandler(this.labelPostDate_Click);
            // 
            // labelPostCreator
            // 
            this.labelPostCreator.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.labelPostCreator.AutoSize = true;
            this.labelPostCreator.Location = new System.Drawing.Point(156, 84);
            this.labelPostCreator.Name = "labelPostCreator";
            this.labelPostCreator.Size = new System.Drawing.Size(64, 18);
            this.labelPostCreator.TabIndex = 0;
            this.labelPostCreator.Text = "Creator";
            // 
            // labelPostLikes
            // 
            this.labelPostLikes.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.labelPostLikes.AutoSize = true;
            this.labelPostLikes.Location = new System.Drawing.Point(156, 137);
            this.labelPostLikes.Name = "labelPostLikes";
            this.labelPostLikes.Size = new System.Drawing.Size(44, 18);
            this.labelPostLikes.TabIndex = 0;
            this.labelPostLikes.Text = "Likes";
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(4, 33);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(43, 18);
            this.label1.TabIndex = 0;
            this.label1.Text = "Date";
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(4, 84);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(64, 18);
            this.label2.TabIndex = 0;
            this.label2.Text = "Creator";
            // 
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(4, 137);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(44, 18);
            this.label3.TabIndex = 0;
            this.label3.Text = "Likes";
            // 
            // PostsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1024, 487);
            this.Controls.Add(this.panel1);
            this.Name = "PostsForm";
            this.Text = "PostsForm";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.tableLayoutPanelPosts.ResumeLayout(false);
            this.tableLayoutPanelPosts.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanelPosts;
        private System.Windows.Forms.Label labelPostDate;
        private System.Windows.Forms.Label labelPostCreator;
        private System.Windows.Forms.Label labelPostLikes;
        private System.Windows.Forms.TextBox textBoxPosts;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.ListBox listBoxPosts;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
    }
}
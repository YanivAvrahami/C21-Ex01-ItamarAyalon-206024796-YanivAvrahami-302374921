
namespace AppUI
{
    partial class FriendsForm
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
            this.label9 = new System.Windows.Forms.Label();
            this.listBoxFriends = new System.Windows.Forms.ListBox();
            this.tableLayoutFriends = new System.Windows.Forms.TableLayoutPanel();
            this.labelFriendName = new System.Windows.Forms.Label();
            this.labelFriendLocation = new System.Windows.Forms.Label();
            this.labelFriendWork = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.btnFetchFriends = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel1.SuspendLayout();
            this.tableLayoutFriends.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(242)))), ((int)(((byte)(245)))));
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Controls.Add(this.btnFetchFriends);
            this.panel1.Controls.Add(this.label9);
            this.panel1.Controls.Add(this.listBoxFriends);
            this.panel1.Controls.Add(this.tableLayoutFriends);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(867, 466);
            this.panel1.TabIndex = 57;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(96)))), ((int)(((byte)(98)))), ((int)(((byte)(102)))));
            this.label9.Location = new System.Drawing.Point(463, 23);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(74, 23);
            this.label9.TabIndex = 58;
            this.label9.Text = "Friends";
            // 
            // listBoxFriends
            // 
            this.listBoxFriends.BackColor = System.Drawing.Color.White;
            this.listBoxFriends.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listBoxFriends.FormattingEnabled = true;
            this.listBoxFriends.ItemHeight = 19;
            this.listBoxFriends.Location = new System.Drawing.Point(12, 61);
            this.listBoxFriends.Name = "listBoxFriends";
            this.listBoxFriends.Size = new System.Drawing.Size(158, 365);
            this.listBoxFriends.TabIndex = 57;
            // 
            // tableLayoutFriends
            // 
            this.tableLayoutFriends.CellBorderStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.Single;
            this.tableLayoutFriends.ColumnCount = 2;
            this.tableLayoutFriends.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutFriends.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutFriends.Controls.Add(this.labelFriendName, 1, 0);
            this.tableLayoutFriends.Controls.Add(this.labelFriendLocation, 1, 1);
            this.tableLayoutFriends.Controls.Add(this.labelFriendWork, 1, 2);
            this.tableLayoutFriends.Controls.Add(this.label1, 0, 0);
            this.tableLayoutFriends.Controls.Add(this.label10, 0, 1);
            this.tableLayoutFriends.Controls.Add(this.label3, 0, 2);
            this.tableLayoutFriends.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tableLayoutFriends.Location = new System.Drawing.Point(293, 110);
            this.tableLayoutFriends.Name = "tableLayoutFriends";
            this.tableLayoutFriends.RowCount = 3;
            this.tableLayoutFriends.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutFriends.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutFriends.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutFriends.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutFriends.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutFriends.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutFriends.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutFriends.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutFriends.Size = new System.Drawing.Size(323, 156);
            this.tableLayoutFriends.TabIndex = 56;
            // 
            // labelFriendName
            // 
            this.labelFriendName.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.labelFriendName.AutoSize = true;
            this.labelFriendName.Location = new System.Drawing.Point(165, 32);
            this.labelFriendName.Name = "labelFriendName";
            this.labelFriendName.Size = new System.Drawing.Size(58, 19);
            this.labelFriendName.TabIndex = 0;
            this.labelFriendName.Text = "Name";
            // 
            // labelFriendLocation
            // 
            this.labelFriendLocation.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.labelFriendLocation.AutoSize = true;
            this.labelFriendLocation.Location = new System.Drawing.Point(165, 83);
            this.labelFriendLocation.Name = "labelFriendLocation";
            this.labelFriendLocation.Size = new System.Drawing.Size(75, 19);
            this.labelFriendLocation.TabIndex = 0;
            this.labelFriendLocation.Text = "Location";
            // 
            // labelFriendWork
            // 
            this.labelFriendWork.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.labelFriendWork.AutoSize = true;
            this.labelFriendWork.Location = new System.Drawing.Point(165, 136);
            this.labelFriendWork.Name = "labelFriendWork";
            this.labelFriendWork.Size = new System.Drawing.Size(47, 19);
            this.labelFriendWork.TabIndex = 0;
            this.labelFriendWork.Text = "Work";
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(4, 32);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(58, 19);
            this.label1.TabIndex = 0;
            this.label1.Text = "Name";
            // 
            // label10
            // 
            this.label10.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(4, 83);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(75, 19);
            this.label10.TabIndex = 0;
            this.label10.Text = "Location";
            // 
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(4, 136);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(47, 19);
            this.label3.TabIndex = 0;
            this.label3.Text = "Work";
            // 
            // btnFetchFriends
            // 
            this.btnFetchFriends.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnFetchFriends.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnFetchFriends.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold);
            this.btnFetchFriends.Location = new System.Drawing.Point(375, 61);
            this.btnFetchFriends.Name = "btnFetchFriends";
            this.btnFetchFriends.Size = new System.Drawing.Size(162, 43);
            this.btnFetchFriends.TabIndex = 65;
            this.btnFetchFriends.Text = "Fetch";
            this.btnFetchFriends.UseVisualStyleBackColor = true;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(176, 61);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(111, 107);
            this.pictureBox1.TabIndex = 66;
            this.pictureBox1.TabStop = false;
            // 
            // FriendsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(867, 466);
            this.Controls.Add(this.panel1);
            this.Name = "FriendsForm";
            this.Text = "FriendsForm";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.tableLayoutFriends.ResumeLayout(false);
            this.tableLayoutFriends.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.ListBox listBoxFriends;
        private System.Windows.Forms.TableLayoutPanel tableLayoutFriends;
        private System.Windows.Forms.Label labelFriendName;
        private System.Windows.Forms.Label labelFriendLocation;
        private System.Windows.Forms.Label labelFriendWork;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnFetchFriends;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}
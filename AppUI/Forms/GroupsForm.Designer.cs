
namespace AppUI.Forms
{
    partial class GroupsForm
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
            this.btnFetchGroups = new System.Windows.Forms.Button();
            this.label9 = new System.Windows.Forms.Label();
            this.listBoxGroups = new System.Windows.Forms.ListBox();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.label2 = new System.Windows.Forms.Label();
            this.labelGroupDescription = new System.Windows.Forms.Label();
            this.pictureBoxGroups = new System.Windows.Forms.PictureBox();
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxGroups)).BeginInit();
            this.SuspendLayout();
            // 
            // btnFetchGroups
            // 
            this.btnFetchGroups.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnFetchGroups.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnFetchGroups.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold);
            this.btnFetchGroups.Location = new System.Drawing.Point(278, 62);
            this.btnFetchGroups.Name = "btnFetchGroups";
            this.btnFetchGroups.Size = new System.Drawing.Size(243, 43);
            this.btnFetchGroups.TabIndex = 70;
            this.btnFetchGroups.Text = "Fetch";
            this.btnFetchGroups.UseVisualStyleBackColor = true;
            this.btnFetchGroups.Click += new System.EventHandler(this.btnFetchGroups_Click);
            // 
            // label9
            // 
            this.label9.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(96)))), ((int)(((byte)(98)))), ((int)(((byte)(102)))));
            this.label9.Location = new System.Drawing.Point(235, 24);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(76, 23);
            this.label9.TabIndex = 69;
            this.label9.Text = "Groups";
            // 
            // listBoxGroups
            // 
            this.listBoxGroups.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.listBoxGroups.BackColor = System.Drawing.Color.White;
            this.listBoxGroups.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listBoxGroups.FormattingEnabled = true;
            this.listBoxGroups.ItemHeight = 19;
            this.listBoxGroups.Location = new System.Drawing.Point(278, 109);
            this.listBoxGroups.Name = "listBoxGroups";
            this.listBoxGroups.ScrollAlwaysVisible = true;
            this.listBoxGroups.Size = new System.Drawing.Size(247, 232);
            this.listBoxGroups.TabIndex = 68;
            this.listBoxGroups.SelectedIndexChanged += new System.EventHandler(this.listBoxGroups_SelectedIndexChanged);
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.tableLayoutPanel1.CellBorderStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.Single;
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Controls.Add(this.label2, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.labelGroupDescription, 1, 0);
            this.tableLayoutPanel1.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(10, 292);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 49F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(262, 50);
            this.tableLayoutPanel1.TabIndex = 71;
            this.tableLayoutPanel1.Paint += new System.Windows.Forms.PaintEventHandler(this.tableLayoutPanel1_Paint);
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold);
            this.label2.Location = new System.Drawing.Point(18, 15);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(94, 19);
            this.label2.TabIndex = 0;
            this.label2.Text = "Description";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // labelGroupDescription
            // 
            this.labelGroupDescription.AutoSize = true;
            this.labelGroupDescription.Dock = System.Windows.Forms.DockStyle.Fill;
            this.labelGroupDescription.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold);
            this.labelGroupDescription.Location = new System.Drawing.Point(134, 1);
            this.labelGroupDescription.MinimumSize = new System.Drawing.Size(10, 10);
            this.labelGroupDescription.Name = "labelGroupDescription";
            this.labelGroupDescription.Size = new System.Drawing.Size(124, 48);
            this.labelGroupDescription.TabIndex = 0;
            this.labelGroupDescription.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pictureBoxGroups
            // 
            this.pictureBoxGroups.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.pictureBoxGroups.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBoxGroups.Location = new System.Drawing.Point(10, 62);
            this.pictureBoxGroups.Name = "pictureBoxGroups";
            this.pictureBoxGroups.Size = new System.Drawing.Size(262, 224);
            this.pictureBoxGroups.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBoxGroups.TabIndex = 72;
            this.pictureBoxGroups.TabStop = false;
            // 
            // GroupsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(535, 351);
            this.Controls.Add(this.pictureBoxGroups);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Controls.Add(this.btnFetchGroups);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.listBoxGroups);
            this.MaximizeBox = false;
            this.Name = "GroupsForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "GroupsForm";
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxGroups)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnFetchGroups;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.ListBox listBoxGroups;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.PictureBox pictureBoxGroups;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label labelGroupDescription;
    }
}
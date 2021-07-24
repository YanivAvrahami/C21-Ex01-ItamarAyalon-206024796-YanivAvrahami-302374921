
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.labelGroupDescription = new System.Windows.Forms.Label();
            this.labelGroupOwner = new System.Windows.Forms.Label();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnFetchGroups
            // 
            this.btnFetchGroups.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnFetchGroups.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnFetchGroups.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold);
            this.btnFetchGroups.Location = new System.Drawing.Point(502, 90);
            this.btnFetchGroups.Name = "btnFetchGroups";
            this.btnFetchGroups.Size = new System.Drawing.Size(247, 43);
            this.btnFetchGroups.TabIndex = 70;
            this.btnFetchGroups.Text = "Fetch";
            this.btnFetchGroups.UseVisualStyleBackColor = true;
            this.btnFetchGroups.Click += new System.EventHandler(this.btnFetchGroups_Click);
            // 
            // label9
            // 
            this.label9.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(96)))), ((int)(((byte)(98)))), ((int)(((byte)(102)))));
            this.label9.Location = new System.Drawing.Point(394, 24);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(76, 23);
            this.label9.TabIndex = 69;
            this.label9.Text = "Groups";
            // 
            // listBoxGroups
            // 
            this.listBoxGroups.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.listBoxGroups.BackColor = System.Drawing.Color.White;
            this.listBoxGroups.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listBoxGroups.FormattingEnabled = true;
            this.listBoxGroups.ItemHeight = 19;
            this.listBoxGroups.Location = new System.Drawing.Point(502, 139);
            this.listBoxGroups.Name = "listBoxGroups";
            this.listBoxGroups.ScrollAlwaysVisible = true;
            this.listBoxGroups.Size = new System.Drawing.Size(247, 346);
            this.listBoxGroups.TabIndex = 68;
            this.listBoxGroups.SelectedIndexChanged += new System.EventHandler(this.listBoxGroups_SelectedIndexChanged);
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Controls.Add(this.label1, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.label2, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.labelGroupDescription, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.labelGroupOwner, 1, 0);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(234, 139);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 14.28571F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 14.28571F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 14.28571F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 14.28571F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 14.28571F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 14.28571F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 14.28571F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(262, 84);
            this.tableLayoutPanel1.TabIndex = 71;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(3, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(50, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Owner";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(3, 42);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(81, 16);
            this.label2.TabIndex = 0;
            this.label2.Text = "Description";
            // 
            // labelGroupDescription
            // 
            this.labelGroupDescription.AutoSize = true;
            this.labelGroupDescription.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelGroupDescription.Location = new System.Drawing.Point(134, 42);
            this.labelGroupDescription.MinimumSize = new System.Drawing.Size(10, 10);
            this.labelGroupDescription.Name = "labelGroupDescription";
            this.labelGroupDescription.Size = new System.Drawing.Size(10, 16);
            this.labelGroupDescription.TabIndex = 0;
            // 
            // labelGroupOwner
            // 
            this.labelGroupOwner.AutoSize = true;
            this.labelGroupOwner.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelGroupOwner.Location = new System.Drawing.Point(134, 0);
            this.labelGroupOwner.MinimumSize = new System.Drawing.Size(10, 10);
            this.labelGroupOwner.Name = "labelGroupOwner";
            this.labelGroupOwner.Size = new System.Drawing.Size(10, 16);
            this.labelGroupOwner.TabIndex = 0;
            // 
            // GroupsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(853, 504);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Controls.Add(this.btnFetchGroups);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.listBoxGroups);
            this.Name = "GroupsForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "GroupsForm";
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnFetchGroups;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.ListBox listBoxGroups;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label labelGroupDescription;
        private System.Windows.Forms.Label labelGroupOwner;
    }
}
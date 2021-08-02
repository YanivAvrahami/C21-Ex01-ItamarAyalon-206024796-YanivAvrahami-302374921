
namespace AppUI
{
    partial class EventsForm
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
            this.textBoxEventDesc = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.listBoxEvents = new System.Windows.Forms.ListBox();
            this.tableLayoutFriends = new System.Windows.Forms.TableLayoutPanel();
            this.labelEventLocation = new System.Windows.Forms.Label();
            this.labelEventStartDate = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.labelEventEndDate = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.labelEventInterested = new System.Windows.Forms.Label();
            this.labelEventPrivacy = new System.Windows.Forms.Label();
            this.labelEventName = new System.Windows.Forms.Label();
            this.btnFetchEvents = new System.Windows.Forms.Button();
            this.comboBoxEventType = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.labelEventsCounted = new System.Windows.Forms.Label();
            this.pictureBoxCover = new System.Windows.Forms.PictureBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.tableLayoutFriends.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxCover)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // textBoxEventDesc
            // 
            this.textBoxEventDesc.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.textBoxEventDesc.BackColor = System.Drawing.Color.White;
            this.textBoxEventDesc.Enabled = false;
            this.textBoxEventDesc.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxEventDesc.Location = new System.Drawing.Point(241, 261);
            this.textBoxEventDesc.Multiline = true;
            this.textBoxEventDesc.Name = "textBoxEventDesc";
            this.textBoxEventDesc.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.textBoxEventDesc.Size = new System.Drawing.Size(326, 118);
            this.textBoxEventDesc.TabIndex = 63;
            // 
            // label9
            // 
            this.label9.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(96)))), ((int)(((byte)(98)))), ((int)(((byte)(102)))));
            this.label9.Location = new System.Drawing.Point(394, 13);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(68, 23);
            this.label9.TabIndex = 62;
            this.label9.Text = "Events";
            this.label9.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // listBoxEvents
            // 
            this.listBoxEvents.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.listBoxEvents.BackColor = System.Drawing.Color.White;
            this.listBoxEvents.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listBoxEvents.FormattingEnabled = true;
            this.listBoxEvents.ItemHeight = 19;
            this.listBoxEvents.Location = new System.Drawing.Point(10, 52);
            this.listBoxEvents.Name = "listBoxEvents";
            this.listBoxEvents.Size = new System.Drawing.Size(218, 308);
            this.listBoxEvents.TabIndex = 61;
            this.listBoxEvents.SelectedIndexChanged += new System.EventHandler(this.listBoxEvents_SelectedIndexChanged);
            // 
            // tableLayoutFriends
            // 
            this.tableLayoutFriends.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.tableLayoutFriends.BackColor = System.Drawing.Color.Transparent;
            this.tableLayoutFriends.CellBorderStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.Single;
            this.tableLayoutFriends.ColumnCount = 2;
            this.tableLayoutFriends.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 40.74074F));
            this.tableLayoutFriends.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 59.25926F));
            this.tableLayoutFriends.Controls.Add(this.labelEventLocation, 1, 1);
            this.tableLayoutFriends.Controls.Add(this.labelEventStartDate, 1, 2);
            this.tableLayoutFriends.Controls.Add(this.label1, 0, 0);
            this.tableLayoutFriends.Controls.Add(this.label10, 0, 1);
            this.tableLayoutFriends.Controls.Add(this.label3, 0, 2);
            this.tableLayoutFriends.Controls.Add(this.label4, 0, 3);
            this.tableLayoutFriends.Controls.Add(this.labelEventEndDate, 1, 3);
            this.tableLayoutFriends.Controls.Add(this.label5, 0, 4);
            this.tableLayoutFriends.Controls.Add(this.label6, 0, 5);
            this.tableLayoutFriends.Controls.Add(this.labelEventInterested, 1, 4);
            this.tableLayoutFriends.Controls.Add(this.labelEventPrivacy, 1, 5);
            this.tableLayoutFriends.Controls.Add(this.labelEventName, 1, 0);
            this.tableLayoutFriends.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tableLayoutFriends.Location = new System.Drawing.Point(581, 142);
            this.tableLayoutFriends.Name = "tableLayoutFriends";
            this.tableLayoutFriends.RowCount = 6;
            this.tableLayoutFriends.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tableLayoutFriends.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tableLayoutFriends.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tableLayoutFriends.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tableLayoutFriends.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tableLayoutFriends.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tableLayoutFriends.Size = new System.Drawing.Size(271, 238);
            this.tableLayoutFriends.TabIndex = 60;
            // 
            // labelEventLocation
            // 
            this.labelEventLocation.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.labelEventLocation.AutoSize = true;
            this.labelEventLocation.Location = new System.Drawing.Point(114, 40);
            this.labelEventLocation.Name = "labelEventLocation";
            this.labelEventLocation.Size = new System.Drawing.Size(153, 38);
            this.labelEventLocation.TabIndex = 0;
            this.labelEventLocation.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // labelEventStartDate
            // 
            this.labelEventStartDate.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.labelEventStartDate.AutoSize = true;
            this.labelEventStartDate.Location = new System.Drawing.Point(114, 79);
            this.labelEventStartDate.Name = "labelEventStartDate";
            this.labelEventStartDate.Size = new System.Drawing.Size(153, 38);
            this.labelEventStartDate.TabIndex = 0;
            this.labelEventStartDate.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(4, 1);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(103, 38);
            this.label1.TabIndex = 0;
            this.label1.Text = "Name";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label10
            // 
            this.label10.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(4, 40);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(103, 38);
            this.label10.TabIndex = 0;
            this.label10.Text = "Location";
            this.label10.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(4, 79);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(103, 38);
            this.label3.TabIndex = 0;
            this.label3.Text = "Start Date";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label4
            // 
            this.label4.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(4, 118);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(103, 38);
            this.label4.TabIndex = 0;
            this.label4.Text = "End Date";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // labelEventEndDate
            // 
            this.labelEventEndDate.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.labelEventEndDate.AutoSize = true;
            this.labelEventEndDate.Location = new System.Drawing.Point(114, 118);
            this.labelEventEndDate.Name = "labelEventEndDate";
            this.labelEventEndDate.Size = new System.Drawing.Size(153, 38);
            this.labelEventEndDate.TabIndex = 0;
            this.labelEventEndDate.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label5
            // 
            this.label5.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(4, 157);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(103, 38);
            this.label5.TabIndex = 0;
            this.label5.Text = "Interested";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label6
            // 
            this.label6.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(4, 196);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(103, 41);
            this.label6.TabIndex = 0;
            this.label6.Text = "Privacy";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // labelEventInterested
            // 
            this.labelEventInterested.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.labelEventInterested.AutoSize = true;
            this.labelEventInterested.Location = new System.Drawing.Point(114, 157);
            this.labelEventInterested.Name = "labelEventInterested";
            this.labelEventInterested.Size = new System.Drawing.Size(153, 38);
            this.labelEventInterested.TabIndex = 0;
            this.labelEventInterested.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // labelEventPrivacy
            // 
            this.labelEventPrivacy.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.labelEventPrivacy.AutoSize = true;
            this.labelEventPrivacy.Location = new System.Drawing.Point(114, 196);
            this.labelEventPrivacy.Name = "labelEventPrivacy";
            this.labelEventPrivacy.Size = new System.Drawing.Size(153, 41);
            this.labelEventPrivacy.TabIndex = 0;
            this.labelEventPrivacy.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // labelEventName
            // 
            this.labelEventName.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.labelEventName.AutoSize = true;
            this.labelEventName.Location = new System.Drawing.Point(114, 1);
            this.labelEventName.Name = "labelEventName";
            this.labelEventName.Size = new System.Drawing.Size(153, 38);
            this.labelEventName.TabIndex = 0;
            this.labelEventName.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnFetchEvents
            // 
            this.btnFetchEvents.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnFetchEvents.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnFetchEvents.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold);
            this.btnFetchEvents.Location = new System.Drawing.Point(59, 11);
            this.btnFetchEvents.Name = "btnFetchEvents";
            this.btnFetchEvents.Size = new System.Drawing.Size(162, 43);
            this.btnFetchEvents.TabIndex = 64;
            this.btnFetchEvents.Text = "Fetch";
            this.btnFetchEvents.UseVisualStyleBackColor = true;
            this.btnFetchEvents.Click += new System.EventHandler(this.btnFetchEvents_Click);
            // 
            // comboBoxEventType
            // 
            this.comboBoxEventType.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.comboBoxEventType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxEventType.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.comboBoxEventType.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold);
            this.comboBoxEventType.FormattingEnabled = true;
            this.comboBoxEventType.Location = new System.Drawing.Point(59, 60);
            this.comboBoxEventType.Name = "comboBoxEventType";
            this.comboBoxEventType.Size = new System.Drawing.Size(162, 27);
            this.comboBoxEventType.TabIndex = 65;
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold);
            this.label2.Location = new System.Drawing.Point(12, 363);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(109, 19);
            this.label2.TabIndex = 66;
            this.label2.Text = "Events found:";
            // 
            // labelEventsCounted
            // 
            this.labelEventsCounted.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.labelEventsCounted.AutoSize = true;
            this.labelEventsCounted.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold);
            this.labelEventsCounted.Location = new System.Drawing.Point(127, 363);
            this.labelEventsCounted.Name = "labelEventsCounted";
            this.labelEventsCounted.Size = new System.Drawing.Size(18, 19);
            this.labelEventsCounted.TabIndex = 67;
            this.labelEventsCounted.Text = "0";
            // 
            // pictureBoxCover
            // 
            this.pictureBoxCover.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.pictureBoxCover.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBoxCover.Location = new System.Drawing.Point(241, 52);
            this.pictureBoxCover.Name = "pictureBoxCover";
            this.pictureBoxCover.Size = new System.Drawing.Size(326, 203);
            this.pictureBoxCover.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBoxCover.TabIndex = 68;
            this.pictureBoxCover.TabStop = false;
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.groupBox1.BackColor = System.Drawing.Color.Transparent;
            this.groupBox1.Controls.Add(this.btnFetchEvents);
            this.groupBox1.Controls.Add(this.comboBoxEventType);
            this.groupBox1.Location = new System.Drawing.Point(582, 46);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(271, 90);
            this.groupBox1.TabIndex = 69;
            this.groupBox1.TabStop = false;
            // 
            // EventsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(242)))), ((int)(((byte)(245)))));
            this.ClientSize = new System.Drawing.Size(864, 391);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.pictureBoxCover);
            this.Controls.Add(this.labelEventsCounted);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textBoxEventDesc);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.listBoxEvents);
            this.Controls.Add(this.tableLayoutFriends);
            this.Name = "EventsForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "EventsForm";
            this.tableLayoutFriends.ResumeLayout(false);
            this.tableLayoutFriends.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxCover)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBoxEventDesc;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.ListBox listBoxEvents;
        private System.Windows.Forms.TableLayoutPanel tableLayoutFriends;
        private System.Windows.Forms.Label labelEventName;
        private System.Windows.Forms.Label labelEventLocation;
        private System.Windows.Forms.Label labelEventStartDate;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnFetchEvents;
        private System.Windows.Forms.ComboBox comboBoxEventType;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label labelEventsCounted;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label labelEventEndDate;
        private System.Windows.Forms.PictureBox pictureBoxCover;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label labelEventInterested;
        private System.Windows.Forms.Label labelEventPrivacy;
        private System.Windows.Forms.GroupBox groupBox1;
    }
}
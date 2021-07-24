namespace AppUI
{
    partial class FormMain
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormMain));
            this.panelMenu = new System.Windows.Forms.Panel();
            this.labelUserName = new System.Windows.Forms.Label();
            this.pictureBoxProfile = new System.Windows.Forms.PictureBox();
            this.btnMinimize = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.btnPosts = new System.Windows.Forms.Button();
            this.btnNotifications = new System.Windows.Forms.Button();
            this.selectionBar = new System.Windows.Forms.Panel();
            this.btnFriends = new System.Windows.Forms.Button();
            this.btnEvents = new System.Windows.Forms.Button();
            this.btnHome = new System.Windows.Forms.Button();
            this.btnLogout = new System.Windows.Forms.Button();
            this.btnLogin = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.labelProfileUsername = new System.Windows.Forms.Label();
            this.labelProfileGender = new System.Windows.Forms.Label();
            this.labelProfileEmail = new System.Windows.Forms.Label();
            this.labelProfileLocation = new System.Windows.Forms.Label();
            this.labelProfileBirthday = new System.Windows.Forms.Label();
            this.labelProfileStatus = new System.Windows.Forms.Label();
            this.labelProfilePhone = new System.Windows.Forms.Label();
            this.labelProfileEducation = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.panelMenu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxProfile)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel1.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelMenu
            // 
            this.panelMenu.BackColor = System.Drawing.Color.White;
            this.panelMenu.Controls.Add(this.labelUserName);
            this.panelMenu.Controls.Add(this.pictureBoxProfile);
            this.panelMenu.Controls.Add(this.btnMinimize);
            this.panelMenu.Controls.Add(this.btnExit);
            this.panelMenu.Controls.Add(this.btnPosts);
            this.panelMenu.Controls.Add(this.btnNotifications);
            this.panelMenu.Controls.Add(this.selectionBar);
            this.panelMenu.Controls.Add(this.btnFriends);
            this.panelMenu.Controls.Add(this.btnEvents);
            this.panelMenu.Controls.Add(this.btnHome);
            this.panelMenu.Controls.Add(this.btnLogout);
            this.panelMenu.Controls.Add(this.btnLogin);
            this.panelMenu.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelMenu.Location = new System.Drawing.Point(0, 0);
            this.panelMenu.Name = "panelMenu";
            this.panelMenu.Size = new System.Drawing.Size(1142, 43);
            this.panelMenu.TabIndex = 53;
            this.panelMenu.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panelMenu_MouseDown);
            this.panelMenu.MouseMove += new System.Windows.Forms.MouseEventHandler(this.panelMenu_MouseMove);
            this.panelMenu.MouseUp += new System.Windows.Forms.MouseEventHandler(this.panelMenu_MouseUp);
            // 
            // labelUserName
            // 
            this.labelUserName.AutoSize = true;
            this.labelUserName.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelUserName.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(96)))), ((int)(((byte)(98)))), ((int)(((byte)(102)))));
            this.labelUserName.Location = new System.Drawing.Point(39, 14);
            this.labelUserName.Name = "labelUserName";
            this.labelUserName.Size = new System.Drawing.Size(0, 16);
            this.labelUserName.TabIndex = 59;
            // 
            // pictureBoxProfile
            // 
            this.pictureBoxProfile.Image = ((System.Drawing.Image)(resources.GetObject("pictureBoxProfile.Image")));
            this.pictureBoxProfile.Location = new System.Drawing.Point(10, 9);
            this.pictureBoxProfile.Name = "pictureBoxProfile";
            this.pictureBoxProfile.Size = new System.Drawing.Size(26, 25);
            this.pictureBoxProfile.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBoxProfile.TabIndex = 54;
            this.pictureBoxProfile.TabStop = false;
            // 
            // btnMinimize
            // 
            this.btnMinimize.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnMinimize.BackColor = System.Drawing.Color.Transparent;
            this.btnMinimize.FlatAppearance.BorderSize = 0;
            this.btnMinimize.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMinimize.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMinimize.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(96)))), ((int)(((byte)(98)))), ((int)(((byte)(102)))));
            this.btnMinimize.Location = new System.Drawing.Point(1072, 0);
            this.btnMinimize.Name = "btnMinimize";
            this.btnMinimize.Size = new System.Drawing.Size(32, 30);
            this.btnMinimize.TabIndex = 58;
            this.btnMinimize.Text = "➖";
            this.btnMinimize.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnMinimize.UseVisualStyleBackColor = false;
            this.btnMinimize.Click += new System.EventHandler(this.btnMinimize_Click);
            // 
            // btnExit
            // 
            this.btnExit.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnExit.BackColor = System.Drawing.Color.Transparent;
            this.btnExit.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnExit.FlatAppearance.BorderSize = 0;
            this.btnExit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnExit.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExit.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(96)))), ((int)(((byte)(98)))), ((int)(((byte)(102)))));
            this.btnExit.Location = new System.Drawing.Point(1110, 0);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(32, 30);
            this.btnExit.TabIndex = 57;
            this.btnExit.Text = "✖";
            this.btnExit.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnExit.UseVisualStyleBackColor = false;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // btnPosts
            // 
            this.btnPosts.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnPosts.BackColor = System.Drawing.Color.Transparent;
            this.btnPosts.FlatAppearance.BorderSize = 0;
            this.btnPosts.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPosts.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPosts.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(96)))), ((int)(((byte)(98)))), ((int)(((byte)(102)))));
            this.btnPosts.Image = ((System.Drawing.Image)(resources.GetObject("btnPosts.Image")));
            this.btnPosts.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnPosts.Location = new System.Drawing.Point(681, 0);
            this.btnPosts.Margin = new System.Windows.Forms.Padding(0);
            this.btnPosts.Name = "btnPosts";
            this.btnPosts.Size = new System.Drawing.Size(79, 43);
            this.btnPosts.TabIndex = 56;
            this.btnPosts.Text = " Posts";
            this.btnPosts.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnPosts.UseVisualStyleBackColor = false;
            this.btnPosts.Click += new System.EventHandler(this.btnPosts_Click);
            // 
            // btnNotifications
            // 
            this.btnNotifications.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnNotifications.BackColor = System.Drawing.Color.Silver;
            this.btnNotifications.Enabled = false;
            this.btnNotifications.FlatAppearance.BorderSize = 0;
            this.btnNotifications.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNotifications.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNotifications.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(96)))), ((int)(((byte)(98)))), ((int)(((byte)(102)))));
            this.btnNotifications.Image = ((System.Drawing.Image)(resources.GetObject("btnNotifications.Image")));
            this.btnNotifications.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnNotifications.Location = new System.Drawing.Point(760, 0);
            this.btnNotifications.Margin = new System.Windows.Forms.Padding(0);
            this.btnNotifications.Name = "btnNotifications";
            this.btnNotifications.Size = new System.Drawing.Size(140, 43);
            this.btnNotifications.TabIndex = 55;
            this.btnNotifications.Text = " Notifications";
            this.btnNotifications.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnNotifications.UseVisualStyleBackColor = false;
            this.btnNotifications.Click += new System.EventHandler(this.btnNotifications_Click);
            // 
            // selectionBar
            // 
            this.selectionBar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(119)))), ((int)(((byte)(242)))));
            this.selectionBar.Location = new System.Drawing.Point(-95, 0);
            this.selectionBar.Name = "selectionBar";
            this.selectionBar.Size = new System.Drawing.Size(82, 5);
            this.selectionBar.TabIndex = 54;
            // 
            // btnFriends
            // 
            this.btnFriends.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnFriends.BackColor = System.Drawing.Color.Transparent;
            this.btnFriends.FlatAppearance.BorderSize = 0;
            this.btnFriends.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnFriends.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFriends.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(96)))), ((int)(((byte)(98)))), ((int)(((byte)(102)))));
            this.btnFriends.Image = ((System.Drawing.Image)(resources.GetObject("btnFriends.Image")));
            this.btnFriends.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnFriends.Location = new System.Drawing.Point(585, 0);
            this.btnFriends.Margin = new System.Windows.Forms.Padding(0);
            this.btnFriends.Name = "btnFriends";
            this.btnFriends.Size = new System.Drawing.Size(96, 43);
            this.btnFriends.TabIndex = 4;
            this.btnFriends.Text = " Friends";
            this.btnFriends.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnFriends.UseVisualStyleBackColor = false;
            this.btnFriends.Click += new System.EventHandler(this.btnFriends_Click);
            // 
            // btnEvents
            // 
            this.btnEvents.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnEvents.BackColor = System.Drawing.Color.Transparent;
            this.btnEvents.FlatAppearance.BorderSize = 0;
            this.btnEvents.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEvents.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEvents.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(96)))), ((int)(((byte)(98)))), ((int)(((byte)(102)))));
            this.btnEvents.Image = ((System.Drawing.Image)(resources.GetObject("btnEvents.Image")));
            this.btnEvents.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnEvents.Location = new System.Drawing.Point(489, 0);
            this.btnEvents.Margin = new System.Windows.Forms.Padding(0);
            this.btnEvents.Name = "btnEvents";
            this.btnEvents.Size = new System.Drawing.Size(96, 43);
            this.btnEvents.TabIndex = 3;
            this.btnEvents.Text = " Events";
            this.btnEvents.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnEvents.UseVisualStyleBackColor = false;
            this.btnEvents.Click += new System.EventHandler(this.btnEvents_Click);
            // 
            // btnHome
            // 
            this.btnHome.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnHome.BackColor = System.Drawing.Color.Transparent;
            this.btnHome.FlatAppearance.BorderSize = 0;
            this.btnHome.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnHome.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnHome.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(96)))), ((int)(((byte)(98)))), ((int)(((byte)(102)))));
            this.btnHome.Image = ((System.Drawing.Image)(resources.GetObject("btnHome.Image")));
            this.btnHome.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnHome.Location = new System.Drawing.Point(393, 0);
            this.btnHome.Margin = new System.Windows.Forms.Padding(0);
            this.btnHome.Name = "btnHome";
            this.btnHome.Size = new System.Drawing.Size(96, 43);
            this.btnHome.TabIndex = 2;
            this.btnHome.Text = " Home";
            this.btnHome.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnHome.UseVisualStyleBackColor = false;
            this.btnHome.Click += new System.EventHandler(this.btnHome_Click);
            // 
            // btnLogout
            // 
            this.btnLogout.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnLogout.BackColor = System.Drawing.Color.Transparent;
            this.btnLogout.FlatAppearance.BorderSize = 0;
            this.btnLogout.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLogout.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLogout.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(96)))), ((int)(((byte)(98)))), ((int)(((byte)(102)))));
            this.btnLogout.Image = ((System.Drawing.Image)(resources.GetObject("btnLogout.Image")));
            this.btnLogout.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnLogout.Location = new System.Drawing.Point(297, 0);
            this.btnLogout.Margin = new System.Windows.Forms.Padding(0);
            this.btnLogout.Name = "btnLogout";
            this.btnLogout.Size = new System.Drawing.Size(96, 43);
            this.btnLogout.TabIndex = 1;
            this.btnLogout.Text = "Logout";
            this.btnLogout.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnLogout.UseVisualStyleBackColor = false;
            this.btnLogout.Click += new System.EventHandler(this.btnLogout_Click);
            // 
            // btnLogin
            // 
            this.btnLogin.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnLogin.BackColor = System.Drawing.Color.Transparent;
            this.btnLogin.FlatAppearance.BorderSize = 0;
            this.btnLogin.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLogin.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLogin.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(96)))), ((int)(((byte)(98)))), ((int)(((byte)(102)))));
            this.btnLogin.Image = ((System.Drawing.Image)(resources.GetObject("btnLogin.Image")));
            this.btnLogin.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnLogin.Location = new System.Drawing.Point(215, 0);
            this.btnLogin.Margin = new System.Windows.Forms.Padding(0);
            this.btnLogin.Name = "btnLogin";
            this.btnLogin.Size = new System.Drawing.Size(82, 43);
            this.btnLogin.TabIndex = 0;
            this.btnLogin.Text = "Login";
            this.btnLogin.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnLogin.UseVisualStyleBackColor = false;
            this.btnLogin.Click += new System.EventHandler(this.btnLogin_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.pictureBox1.Location = new System.Drawing.Point(31, 50);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(462, 401);
            this.pictureBox1.TabIndex = 54;
            this.pictureBox1.TabStop = false;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Linen;
            this.panel1.Controls.Add(this.tableLayoutPanel1);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Location = new System.Drawing.Point(74, 59);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(920, 532);
            this.panel1.TabIndex = 55;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.CellBorderStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.Single;
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Controls.Add(this.labelProfileUsername, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.labelProfileGender, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.labelProfileBirthday, 1, 6);
            this.tableLayoutPanel1.Controls.Add(this.labelProfileEmail, 1, 5);
            this.tableLayoutPanel1.Controls.Add(this.labelProfileEducation, 1, 7);
            this.tableLayoutPanel1.Controls.Add(this.labelProfileStatus, 1, 2);
            this.tableLayoutPanel1.Controls.Add(this.labelProfileLocation, 1, 3);
            this.tableLayoutPanel1.Controls.Add(this.labelProfilePhone, 1, 4);
            this.tableLayoutPanel1.Controls.Add(this.label1, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.label2, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.label3, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.label4, 0, 3);
            this.tableLayoutPanel1.Controls.Add(this.label5, 0, 4);
            this.tableLayoutPanel1.Controls.Add(this.label6, 0, 5);
            this.tableLayoutPanel1.Controls.Add(this.label7, 0, 6);
            this.tableLayoutPanel1.Controls.Add(this.label8, 0, 7);
            this.tableLayoutPanel1.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(546, 38);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 8;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 12.5F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 12.5F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 12.5F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 12.5F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 12.5F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 12.5F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 12.5F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 12.5F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(323, 433);
            this.tableLayoutPanel1.TabIndex = 56;
            // 
            // labelProfileUsername
            // 
            this.labelProfileUsername.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.labelProfileUsername.AutoSize = true;
            this.labelProfileUsername.Location = new System.Drawing.Point(165, 36);
            this.labelProfileUsername.Name = "labelProfileUsername";
            this.labelProfileUsername.Size = new System.Drawing.Size(86, 18);
            this.labelProfileUsername.TabIndex = 0;
            this.labelProfileUsername.Text = "User name";
            // 
            // labelProfileGender
            // 
            this.labelProfileGender.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.labelProfileGender.AutoSize = true;
            this.labelProfileGender.Location = new System.Drawing.Point(165, 90);
            this.labelProfileGender.Name = "labelProfileGender";
            this.labelProfileGender.Size = new System.Drawing.Size(65, 18);
            this.labelProfileGender.TabIndex = 0;
            this.labelProfileGender.Text = "Gender";
            // 
            // labelProfileEmail
            // 
            this.labelProfileEmail.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.labelProfileEmail.AutoSize = true;
            this.labelProfileEmail.Location = new System.Drawing.Point(165, 306);
            this.labelProfileEmail.Name = "labelProfileEmail";
            this.labelProfileEmail.Size = new System.Drawing.Size(48, 18);
            this.labelProfileEmail.TabIndex = 0;
            this.labelProfileEmail.Text = "Email";
            // 
            // labelProfileLocation
            // 
            this.labelProfileLocation.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.labelProfileLocation.AutoSize = true;
            this.labelProfileLocation.Location = new System.Drawing.Point(165, 198);
            this.labelProfileLocation.Name = "labelProfileLocation";
            this.labelProfileLocation.Size = new System.Drawing.Size(72, 18);
            this.labelProfileLocation.TabIndex = 0;
            this.labelProfileLocation.Text = "Location";
            // 
            // labelProfileBirthday
            // 
            this.labelProfileBirthday.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.labelProfileBirthday.AutoSize = true;
            this.labelProfileBirthday.Location = new System.Drawing.Point(165, 360);
            this.labelProfileBirthday.Name = "labelProfileBirthday";
            this.labelProfileBirthday.Size = new System.Drawing.Size(68, 18);
            this.labelProfileBirthday.TabIndex = 0;
            this.labelProfileBirthday.Text = "Birthday";
            // 
            // labelProfileStatus
            // 
            this.labelProfileStatus.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.labelProfileStatus.AutoSize = true;
            this.labelProfileStatus.Location = new System.Drawing.Point(165, 144);
            this.labelProfileStatus.Name = "labelProfileStatus";
            this.labelProfileStatus.Size = new System.Drawing.Size(49, 18);
            this.labelProfileStatus.TabIndex = 0;
            this.labelProfileStatus.Text = "Status";
            // 
            // labelProfilePhone
            // 
            this.labelProfilePhone.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.labelProfilePhone.AutoSize = true;
            this.labelProfilePhone.Location = new System.Drawing.Point(165, 252);
            this.labelProfilePhone.Name = "labelProfilePhone";
            this.labelProfilePhone.Size = new System.Drawing.Size(54, 18);
            this.labelProfilePhone.TabIndex = 0;
            this.labelProfilePhone.Text = "Phone";
            // 
            // labelProfileEducation
            // 
            this.labelProfileEducation.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.labelProfileEducation.AutoSize = true;
            this.labelProfileEducation.Location = new System.Drawing.Point(165, 414);
            this.labelProfileEducation.Name = "labelProfileEducation";
            this.labelProfileEducation.Size = new System.Drawing.Size(82, 18);
            this.labelProfileEducation.TabIndex = 0;
            this.labelProfileEducation.Text = "Education";
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(4, 36);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(86, 18);
            this.label1.TabIndex = 0;
            this.label1.Text = "User name";
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(4, 90);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(65, 18);
            this.label2.TabIndex = 0;
            this.label2.Text = "Gender";
            // 
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(4, 144);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(49, 18);
            this.label3.TabIndex = 0;
            this.label3.Text = "Status";
            // 
            // label4
            // 
            this.label4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(4, 198);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(72, 18);
            this.label4.TabIndex = 0;
            this.label4.Text = "Location";
            // 
            // label5
            // 
            this.label5.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(4, 252);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(54, 18);
            this.label5.TabIndex = 0;
            this.label5.Text = "Phone";
            // 
            // label6
            // 
            this.label6.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(4, 306);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(48, 18);
            this.label6.TabIndex = 0;
            this.label6.Text = "Email";
            // 
            // label7
            // 
            this.label7.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(4, 360);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(68, 18);
            this.label7.TabIndex = 0;
            this.label7.Text = "Birthday";
            // 
            // label8
            // 
            this.label8.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(4, 414);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(82, 18);
            this.label8.TabIndex = 0;
            this.label8.Text = "Education";
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(242)))), ((int)(((byte)(245)))));
            this.ClientSize = new System.Drawing.Size(1142, 654);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panelMenu);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.panelMenu.ResumeLayout(false);
            this.panelMenu.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxProfile)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.ResumeLayout(false);

        }

		#endregion
        private System.Windows.Forms.Panel panelMenu;
        private System.Windows.Forms.Button btnLogin;
        private System.Windows.Forms.Button btnHome;
        private System.Windows.Forms.Button btnLogout;
        private System.Windows.Forms.Button btnEvents;
        private System.Windows.Forms.Button btnFriends;
        private System.Windows.Forms.Panel selectionBar;
        private System.Windows.Forms.Button btnNotifications;
        private System.Windows.Forms.Button btnPosts;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Button btnMinimize;
        private System.Windows.Forms.PictureBox pictureBoxProfile;
        private System.Windows.Forms.Label labelUserName;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Label labelProfileUsername;
        private System.Windows.Forms.Label labelProfileGender;
        private System.Windows.Forms.Label labelProfileEmail;
        private System.Windows.Forms.Label labelProfileLocation;
        private System.Windows.Forms.Label labelProfileBirthday;
        private System.Windows.Forms.Label labelProfilePhone;
        private System.Windows.Forms.Label labelProfileStatus;
        private System.Windows.Forms.Label labelProfileEducation;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
    }
}


namespace AppUI
{
    partial class mainForm
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
            this.panelMenu = new System.Windows.Forms.Panel();
            this.checkBoxRememberMe = new System.Windows.Forms.CheckBox();
            this.labelUserName = new System.Windows.Forms.Label();
            this.pictureBoxProfile = new System.Windows.Forms.PictureBox();
            this.btnMinimize = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.btnAlbums = new System.Windows.Forms.Button();
            this.btnPostsCounter = new System.Windows.Forms.Button();
            this.btnLikeRated = new System.Windows.Forms.Button();
            this.btnGroups = new System.Windows.Forms.Button();
            this.btnPosts = new System.Windows.Forms.Button();
            this.selectionBar = new System.Windows.Forms.Panel();
            this.btnFriends = new System.Windows.Forms.Button();
            this.btnEvents = new System.Windows.Forms.Button();
            this.btnLogout = new System.Windows.Forms.Button();
            this.btnLogin = new System.Windows.Forms.Button();
            this.tableLayoutFriends = new System.Windows.Forms.TableLayoutPanel();
            this.labelProfileFirstName = new System.Windows.Forms.Label();
            this.labelProfileLastName = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.labelProfileBirthday = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.labelProfileEmail = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.labelProfileLocation = new System.Windows.Forms.Label();
            this.labelProfileGender = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.labelProfileStatus = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.pictureBoxProfilePicture = new System.Windows.Forms.PictureBox();
            this.panelMenu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxProfile)).BeginInit();
            this.tableLayoutFriends.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxProfilePicture)).BeginInit();
            this.SuspendLayout();
            // 
            // panelMenu
            // 
            this.panelMenu.BackColor = System.Drawing.Color.White;
            this.panelMenu.Controls.Add(this.checkBoxRememberMe);
            this.panelMenu.Controls.Add(this.labelUserName);
            this.panelMenu.Controls.Add(this.pictureBoxProfile);
            this.panelMenu.Controls.Add(this.btnMinimize);
            this.panelMenu.Controls.Add(this.btnExit);
            this.panelMenu.Controls.Add(this.btnAlbums);
            this.panelMenu.Controls.Add(this.btnPostsCounter);
            this.panelMenu.Controls.Add(this.btnLikeRated);
            this.panelMenu.Controls.Add(this.btnGroups);
            this.panelMenu.Controls.Add(this.btnPosts);
            this.panelMenu.Controls.Add(this.selectionBar);
            this.panelMenu.Controls.Add(this.btnFriends);
            this.panelMenu.Controls.Add(this.btnEvents);
            this.panelMenu.Controls.Add(this.btnLogout);
            this.panelMenu.Controls.Add(this.btnLogin);
            this.panelMenu.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelMenu.Location = new System.Drawing.Point(0, 0);
            this.panelMenu.Name = "panelMenu";
            this.panelMenu.Size = new System.Drawing.Size(1292, 43);
            this.panelMenu.TabIndex = 53;
            this.panelMenu.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panelMenu_MouseDown);
            this.panelMenu.MouseMove += new System.Windows.Forms.MouseEventHandler(this.panelMenu_MouseMove);
            this.panelMenu.MouseUp += new System.Windows.Forms.MouseEventHandler(this.panelMenu_MouseUp);
            // 
            // checkBoxRememberMe
            // 
            this.checkBoxRememberMe.AutoSize = true;
            this.checkBoxRememberMe.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.checkBoxRememberMe.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBoxRememberMe.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(96)))), ((int)(((byte)(98)))), ((int)(((byte)(102)))));
            this.checkBoxRememberMe.Location = new System.Drawing.Point(142, 14);
            this.checkBoxRememberMe.Name = "checkBoxRememberMe";
            this.checkBoxRememberMe.Size = new System.Drawing.Size(111, 20);
            this.checkBoxRememberMe.TabIndex = 60;
            this.checkBoxRememberMe.Text = "Remember Me";
            this.checkBoxRememberMe.UseVisualStyleBackColor = true;
            this.checkBoxRememberMe.CheckedChanged += new System.EventHandler(this.checkBoxRememberMe_CheckedChanged);
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
            this.pictureBoxProfile.Image = global::AppUI.Properties.Resources.icons8_name_25;
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
            this.btnMinimize.Location = new System.Drawing.Point(1222, 0);
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
            this.btnExit.Location = new System.Drawing.Point(1260, 0);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(32, 30);
            this.btnExit.TabIndex = 57;
            this.btnExit.Text = "✖";
            this.btnExit.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnExit.UseVisualStyleBackColor = false;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // btnAlbums
            // 
            this.btnAlbums.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnAlbums.BackColor = System.Drawing.Color.Transparent;
            this.btnAlbums.FlatAppearance.BorderSize = 0;
            this.btnAlbums.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAlbums.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAlbums.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(96)))), ((int)(((byte)(98)))), ((int)(((byte)(102)))));
            this.btnAlbums.Image = global::AppUI.Properties.Resources.icons8_cat_profile_25;
            this.btnAlbums.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAlbums.Location = new System.Drawing.Point(709, 0);
            this.btnAlbums.Margin = new System.Windows.Forms.Padding(0);
            this.btnAlbums.Name = "btnAlbums";
            this.btnAlbums.Size = new System.Drawing.Size(106, 43);
            this.btnAlbums.TabIndex = 56;
            this.btnAlbums.Text = "Albums";
            this.btnAlbums.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnAlbums.UseVisualStyleBackColor = false;
            this.btnAlbums.Click += new System.EventHandler(this.btnAlbums_Click);
            // 
            // btnPostsCounter
            // 
            this.btnPostsCounter.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnPostsCounter.BackColor = System.Drawing.Color.Transparent;
            this.btnPostsCounter.FlatAppearance.BorderSize = 0;
            this.btnPostsCounter.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPostsCounter.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPostsCounter.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(96)))), ((int)(((byte)(98)))), ((int)(((byte)(102)))));
            this.btnPostsCounter.Image = global::AppUI.Properties.Resources.icons8_star_26;
            this.btnPostsCounter.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnPostsCounter.Location = new System.Drawing.Point(1046, 0);
            this.btnPostsCounter.Margin = new System.Windows.Forms.Padding(0);
            this.btnPostsCounter.Name = "btnPostsCounter";
            this.btnPostsCounter.Size = new System.Drawing.Size(143, 43);
            this.btnPostsCounter.TabIndex = 56;
            this.btnPostsCounter.Text = "Posts Counter";
            this.btnPostsCounter.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnPostsCounter.UseVisualStyleBackColor = false;
            this.btnPostsCounter.Click += new System.EventHandler(this.btnPostsCounter_Click);
            // 
            // btnLikeRated
            // 
            this.btnLikeRated.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnLikeRated.BackColor = System.Drawing.Color.Transparent;
            this.btnLikeRated.FlatAppearance.BorderSize = 0;
            this.btnLikeRated.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLikeRated.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLikeRated.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(96)))), ((int)(((byte)(98)))), ((int)(((byte)(102)))));
            this.btnLikeRated.Image = global::AppUI.Properties.Resources.icons8_star_26;
            this.btnLikeRated.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnLikeRated.Location = new System.Drawing.Point(920, 0);
            this.btnLikeRated.Margin = new System.Windows.Forms.Padding(0);
            this.btnLikeRated.Name = "btnLikeRated";
            this.btnLikeRated.Size = new System.Drawing.Size(126, 43);
            this.btnLikeRated.TabIndex = 56;
            this.btnLikeRated.Text = "Like Rated";
            this.btnLikeRated.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnLikeRated.UseVisualStyleBackColor = false;
            this.btnLikeRated.Click += new System.EventHandler(this.btnLikeRated_Click);
            // 
            // btnGroups
            // 
            this.btnGroups.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnGroups.BackColor = System.Drawing.Color.Transparent;
            this.btnGroups.FlatAppearance.BorderSize = 0;
            this.btnGroups.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGroups.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGroups.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(96)))), ((int)(((byte)(98)))), ((int)(((byte)(102)))));
            this.btnGroups.Image = global::AppUI.Properties.Resources.icons8_sent_25_3;
            this.btnGroups.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnGroups.Location = new System.Drawing.Point(815, 0);
            this.btnGroups.Margin = new System.Windows.Forms.Padding(0);
            this.btnGroups.Name = "btnGroups";
            this.btnGroups.Size = new System.Drawing.Size(105, 43);
            this.btnGroups.TabIndex = 56;
            this.btnGroups.Text = "Groups";
            this.btnGroups.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnGroups.UseVisualStyleBackColor = false;
            this.btnGroups.Click += new System.EventHandler(this.btnGroups_Click);
            // 
            // btnPosts
            // 
            this.btnPosts.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnPosts.BackColor = System.Drawing.Color.Transparent;
            this.btnPosts.FlatAppearance.BorderSize = 0;
            this.btnPosts.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPosts.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPosts.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(96)))), ((int)(((byte)(98)))), ((int)(((byte)(102)))));
            this.btnPosts.Image = global::AppUI.Properties.Resources.icons8_sent_25_3;
            this.btnPosts.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnPosts.Location = new System.Drawing.Point(630, 0);
            this.btnPosts.Margin = new System.Windows.Forms.Padding(0);
            this.btnPosts.Name = "btnPosts";
            this.btnPosts.Size = new System.Drawing.Size(79, 43);
            this.btnPosts.TabIndex = 56;
            this.btnPosts.Text = " Posts";
            this.btnPosts.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnPosts.UseVisualStyleBackColor = false;
            this.btnPosts.Click += new System.EventHandler(this.btnPosts_Click);
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
            this.btnFriends.Image = global::AppUI.Properties.Resources.icons8_group_25_2;
            this.btnFriends.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnFriends.Location = new System.Drawing.Point(534, 0);
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
            this.btnEvents.Image = global::AppUI.Properties.Resources.icons8_event_25;
            this.btnEvents.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnEvents.Location = new System.Drawing.Point(438, 0);
            this.btnEvents.Margin = new System.Windows.Forms.Padding(0);
            this.btnEvents.Name = "btnEvents";
            this.btnEvents.Size = new System.Drawing.Size(96, 43);
            this.btnEvents.TabIndex = 3;
            this.btnEvents.Text = " Events";
            this.btnEvents.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnEvents.UseVisualStyleBackColor = false;
            this.btnEvents.Click += new System.EventHandler(this.btnEvents_Click);
            // 
            // btnLogout
            // 
            this.btnLogout.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnLogout.BackColor = System.Drawing.Color.Transparent;
            this.btnLogout.FlatAppearance.BorderSize = 0;
            this.btnLogout.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLogout.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLogout.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(96)))), ((int)(((byte)(98)))), ((int)(((byte)(102)))));
            this.btnLogout.Image = global::AppUI.Properties.Resources.icons8_logout_rounded_left_25_3;
            this.btnLogout.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnLogout.Location = new System.Drawing.Point(342, 0);
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
            this.btnLogin.Image = global::AppUI.Properties.Resources.icons8_login_25_5;
            this.btnLogin.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnLogin.Location = new System.Drawing.Point(260, 0);
            this.btnLogin.Margin = new System.Windows.Forms.Padding(0);
            this.btnLogin.Name = "btnLogin";
            this.btnLogin.Size = new System.Drawing.Size(82, 43);
            this.btnLogin.TabIndex = 0;
            this.btnLogin.Text = "Login";
            this.btnLogin.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnLogin.UseVisualStyleBackColor = false;
            this.btnLogin.Click += new System.EventHandler(this.btnLogin_Click);
            // 
            // tableLayoutFriends
            // 
            this.tableLayoutFriends.CellBorderStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.Single;
            this.tableLayoutFriends.ColumnCount = 2;
            this.tableLayoutFriends.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 29.85386F));
            this.tableLayoutFriends.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 70.14614F));
            this.tableLayoutFriends.Controls.Add(this.labelProfileFirstName, 1, 0);
            this.tableLayoutFriends.Controls.Add(this.labelProfileLastName, 1, 1);
            this.tableLayoutFriends.Controls.Add(this.label4, 0, 0);
            this.tableLayoutFriends.Controls.Add(this.label1, 0, 1);
            this.tableLayoutFriends.Controls.Add(this.labelProfileBirthday, 1, 5);
            this.tableLayoutFriends.Controls.Add(this.label3, 0, 5);
            this.tableLayoutFriends.Controls.Add(this.labelProfileEmail, 1, 4);
            this.tableLayoutFriends.Controls.Add(this.label6, 0, 4);
            this.tableLayoutFriends.Controls.Add(this.label2, 0, 3);
            this.tableLayoutFriends.Controls.Add(this.labelProfileLocation, 1, 3);
            this.tableLayoutFriends.Controls.Add(this.labelProfileGender, 1, 2);
            this.tableLayoutFriends.Controls.Add(this.label7, 0, 2);
            this.tableLayoutFriends.Controls.Add(this.label5, 0, 6);
            this.tableLayoutFriends.Controls.Add(this.labelProfileStatus, 1, 6);
            this.tableLayoutFriends.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tableLayoutFriends.Location = new System.Drawing.Point(534, 14);
            this.tableLayoutFriends.Name = "tableLayoutFriends";
            this.tableLayoutFriends.RowCount = 7;
            this.tableLayoutFriends.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 14.28571F));
            this.tableLayoutFriends.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 14.28571F));
            this.tableLayoutFriends.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 14.28571F));
            this.tableLayoutFriends.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 14.28571F));
            this.tableLayoutFriends.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 14.28571F));
            this.tableLayoutFriends.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 14.28571F));
            this.tableLayoutFriends.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 14.28571F));
            this.tableLayoutFriends.Size = new System.Drawing.Size(480, 402);
            this.tableLayoutFriends.TabIndex = 61;
            // 
            // labelProfileFirstName
            // 
            this.labelProfileFirstName.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.labelProfileFirstName.AutoSize = true;
            this.labelProfileFirstName.Location = new System.Drawing.Point(147, 1);
            this.labelProfileFirstName.MinimumSize = new System.Drawing.Size(10, 10);
            this.labelProfileFirstName.Name = "labelProfileFirstName";
            this.labelProfileFirstName.Size = new System.Drawing.Size(329, 56);
            this.labelProfileFirstName.TabIndex = 0;
            this.labelProfileFirstName.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // labelProfileLastName
            // 
            this.labelProfileLastName.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.labelProfileLastName.AutoSize = true;
            this.labelProfileLastName.Location = new System.Drawing.Point(147, 58);
            this.labelProfileLastName.MinimumSize = new System.Drawing.Size(10, 10);
            this.labelProfileLastName.Name = "labelProfileLastName";
            this.labelProfileLastName.Size = new System.Drawing.Size(329, 56);
            this.labelProfileLastName.TabIndex = 0;
            this.labelProfileLastName.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label4
            // 
            this.label4.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(4, 1);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(136, 56);
            this.label4.TabIndex = 0;
            this.label4.Text = "First Name";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(4, 58);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(136, 56);
            this.label1.TabIndex = 0;
            this.label1.Text = "Last Name";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // labelProfileBirthday
            // 
            this.labelProfileBirthday.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.labelProfileBirthday.AutoSize = true;
            this.labelProfileBirthday.Location = new System.Drawing.Point(147, 286);
            this.labelProfileBirthday.MinimumSize = new System.Drawing.Size(10, 10);
            this.labelProfileBirthday.Name = "labelProfileBirthday";
            this.labelProfileBirthday.Size = new System.Drawing.Size(329, 56);
            this.labelProfileBirthday.TabIndex = 0;
            this.labelProfileBirthday.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(4, 286);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(136, 56);
            this.label3.TabIndex = 0;
            this.label3.Text = "Birthday";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // labelProfileEmail
            // 
            this.labelProfileEmail.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.labelProfileEmail.AutoSize = true;
            this.labelProfileEmail.Location = new System.Drawing.Point(147, 229);
            this.labelProfileEmail.MinimumSize = new System.Drawing.Size(10, 10);
            this.labelProfileEmail.Name = "labelProfileEmail";
            this.labelProfileEmail.Size = new System.Drawing.Size(329, 56);
            this.labelProfileEmail.TabIndex = 0;
            this.labelProfileEmail.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label6
            // 
            this.label6.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(4, 229);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(136, 56);
            this.label6.TabIndex = 0;
            this.label6.Text = "Email";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(4, 172);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(136, 56);
            this.label2.TabIndex = 0;
            this.label2.Text = "Location";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // labelProfileLocation
            // 
            this.labelProfileLocation.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.labelProfileLocation.AutoSize = true;
            this.labelProfileLocation.Location = new System.Drawing.Point(147, 172);
            this.labelProfileLocation.MinimumSize = new System.Drawing.Size(10, 10);
            this.labelProfileLocation.Name = "labelProfileLocation";
            this.labelProfileLocation.Size = new System.Drawing.Size(329, 56);
            this.labelProfileLocation.TabIndex = 0;
            this.labelProfileLocation.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // labelProfileGender
            // 
            this.labelProfileGender.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.labelProfileGender.AutoSize = true;
            this.labelProfileGender.Location = new System.Drawing.Point(147, 115);
            this.labelProfileGender.MinimumSize = new System.Drawing.Size(10, 10);
            this.labelProfileGender.Name = "labelProfileGender";
            this.labelProfileGender.Size = new System.Drawing.Size(329, 56);
            this.labelProfileGender.TabIndex = 0;
            this.labelProfileGender.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label7
            // 
            this.label7.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(4, 115);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(136, 56);
            this.label7.TabIndex = 0;
            this.label7.Text = "Gender";
            this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label5
            // 
            this.label5.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(4, 343);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(136, 58);
            this.label5.TabIndex = 0;
            this.label5.Text = "Status";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // labelProfileStatus
            // 
            this.labelProfileStatus.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.labelProfileStatus.AutoSize = true;
            this.labelProfileStatus.Location = new System.Drawing.Point(147, 343);
            this.labelProfileStatus.MinimumSize = new System.Drawing.Size(10, 10);
            this.labelProfileStatus.Name = "labelProfileStatus";
            this.labelProfileStatus.Size = new System.Drawing.Size(329, 58);
            this.labelProfileStatus.TabIndex = 0;
            this.labelProfileStatus.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panel1
            // 
            this.panel1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Controls.Add(this.pictureBoxProfilePicture);
            this.panel1.Controls.Add(this.tableLayoutFriends);
            this.panel1.Location = new System.Drawing.Point(124, 75);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1045, 438);
            this.panel1.TabIndex = 62;
            // 
            // pictureBoxProfilePicture
            // 
            this.pictureBoxProfilePicture.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBoxProfilePicture.Location = new System.Drawing.Point(20, 14);
            this.pictureBoxProfilePicture.Name = "pictureBoxProfilePicture";
            this.pictureBoxProfilePicture.Size = new System.Drawing.Size(400, 400);
            this.pictureBoxProfilePicture.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBoxProfilePicture.TabIndex = 54;
            this.pictureBoxProfilePicture.TabStop = false;
            // 
            // mainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(242)))), ((int)(((byte)(245)))));
            this.ClientSize = new System.Drawing.Size(1292, 552);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panelMenu);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "mainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Application";
            this.panelMenu.ResumeLayout(false);
            this.panelMenu.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxProfile)).EndInit();
            this.tableLayoutFriends.ResumeLayout(false);
            this.tableLayoutFriends.PerformLayout();
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxProfilePicture)).EndInit();
            this.ResumeLayout(false);

        }

		#endregion
        private System.Windows.Forms.Panel panelMenu;
        private System.Windows.Forms.Button btnLogin;
        private System.Windows.Forms.Button btnLogout;
        private System.Windows.Forms.Button btnEvents;
        private System.Windows.Forms.Button btnFriends;
        private System.Windows.Forms.Panel selectionBar;
        private System.Windows.Forms.Button btnPosts;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Button btnMinimize;
        private System.Windows.Forms.PictureBox pictureBoxProfile;
        private System.Windows.Forms.Label labelUserName;
        private System.Windows.Forms.PictureBox pictureBoxProfilePicture;
        private System.Windows.Forms.TableLayoutPanel tableLayoutFriends;
        private System.Windows.Forms.Label labelProfileLastName;
        private System.Windows.Forms.Label labelProfileLocation;
        private System.Windows.Forms.Label labelProfileBirthday;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label labelProfileFirstName;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label labelProfileEmail;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label labelProfileGender;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button btnAlbums;
        private System.Windows.Forms.Button btnGroups;
        private System.Windows.Forms.CheckBox checkBoxRememberMe;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label labelProfileStatus;
        private System.Windows.Forms.Button btnLikeRated;
        private System.Windows.Forms.Button btnPostsCounter;
    }
}


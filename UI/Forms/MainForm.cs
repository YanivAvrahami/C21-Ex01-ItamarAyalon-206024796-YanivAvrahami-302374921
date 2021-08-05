using System;
using System.Drawing;
using System.Windows.Forms;
using FacebookWrapper.ObjectModel;
using FacebookWrapper;
using System.Collections.Generic;
using UI.Forms;
using Logic;

namespace UI
{
    public partial class mainForm : Form
    {
        private FacebookUserFetcher facebookUserFetcher = FacebookUserFetcher.sr_Instance;

        public mainForm()
        {
            InitializeComponent();
            setButtons(false);
            FacebookService.s_CollectionLimit = 100;

            checkBoxRememberMe.Checked = Properties.Settings.Default.RememberMe;
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            SetSelectionBarOnButton((Button)sender);
            Clipboard.SetText("design.patterns21c");

            LoginResult loginResult = facebookUserFetcher.Login();

            if (!string.IsNullOrEmpty(loginResult.AccessToken))
            {
                setButtons(true);
                toolbarFetch();
                profileFetch();
            }
            else
            {
                MessageBox.Show(loginResult.ErrorMessage, "Login Failed");
            }
        }

        private void profileFetch()
        {
            pictureBoxProfilePicture.Image = facebookUserFetcher.User.ImageLarge;
            labelProfileFirstName.Text = facebookUserFetcher.User.FirstName;
            labelProfileLastName.Text = facebookUserFetcher.User.LastName;
            labelProfileGender.Text = facebookUserFetcher.User.Gender.ToString();
            labelProfileLocation.Text = facebookUserFetcher.User.Location?.Name;
            labelProfileEmail.Text = facebookUserFetcher.User.Email;
            labelProfileBirthday.Text = facebookUserFetcher.User.Birthday;
            labelProfileStatus.Text = facebookUserFetcher.User.RelationshipStatus?.ToString();
        }

        private void clear()
        {
            pictureBoxProfilePicture.Image = null;

            labelProfileFirstName.Text = String.Empty;
            labelProfileLastName.Text = String.Empty;
            labelProfileGender.Text = String.Empty;
            labelProfileLocation.Text = String.Empty;
            labelProfileEmail.Text = String.Empty;
            labelProfileBirthday.Text = String.Empty;
        }

        private void setButtons(bool i_IsActive)
        {
            btnEvents.Enabled = i_IsActive;
            btnFriends.Enabled = i_IsActive;
            btnPosts.Enabled = i_IsActive;
            btnAlbums.Enabled = i_IsActive;
            btnGroups.Enabled = i_IsActive;
            btnLogout.Enabled = i_IsActive;
            btnLikeRated.Enabled = i_IsActive;
            btnPostsCounter.Enabled = i_IsActive;
            btnLogin.Enabled = !i_IsActive;
        }

        private void toolbarFetch()
        {
            pictureBoxProfile.LoadAsync(facebookUserFetcher.User.PictureSmallURL);
            labelUserName.Text = facebookUserFetcher.User.Name;
        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            SetSelectionBarOnButton((Button)sender);
            
            FacebookService.LogoutWithUI();
            pictureBoxProfile.Image = UI.Properties.Resources.icons8_name_25;
            labelUserName.Text = "";
            clear();
            setButtons(false);
        }

        private void btnEvents_Click(object sender, EventArgs e)
        {
            SetSelectionBarOnButton((Button)sender);
            new eventsForm().ShowDialog();
        }

        private void btnFriends_Click(object sender, EventArgs e)
        {
            SetSelectionBarOnButton((Button)sender);
            new friendsForm().ShowDialog();
        }

        private void btnPosts_Click(object sender, EventArgs e)
        {
            SetSelectionBarOnButton((Button)sender);
            new postsForm().ShowDialog();
        }

        private void btnAlbums_Click(object sender, EventArgs e)
        {
            SetSelectionBarOnButton((Button)sender);
            new albumsForm().ShowDialog();
        }

        private void btnGroups_Click(object sender, EventArgs e)
        {
            SetSelectionBarOnButton((Button)sender);
            new groupsForm().ShowDialog();
        }

        private void btnLikeRated_Click(object sender, EventArgs e)
        {
            SetSelectionBarOnButton((Button)sender);
            new likeRatedForm().ShowDialog();
        }

        private void btnPostsCounter_Click(object sender, EventArgs e)
        {
            SetSelectionBarOnButton((Button)sender);
            new postsCounterForm().ShowDialog();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        public void SetSelectionBarOnButton(Button i_Button) 
        {
            selectionBar.Width = i_Button.Width;
            selectionBar.Location = new Point(i_Button.Location.X, selectionBar.Location.Y);
            selectionBar.BringToFront();
        }

        private void btnMinimize_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private bool mouseDown;
        private Point lastLocation;

        private void panelMenu_MouseDown(object sender, MouseEventArgs e)
        {
            mouseDown = true;
            lastLocation = e.Location;
        }

        private void panelMenu_MouseMove(object sender, MouseEventArgs e)
        {
            if (mouseDown)
            {
                this.Location = new Point((this.Location.X - lastLocation.X) + e.X, (this.Location.Y - lastLocation.Y) + e.Y);
                this.Update();
            }
        }

        private void panelMenu_MouseUp(object sender, MouseEventArgs e)
        {
            mouseDown = false;
        }

        private void checkBoxRememberMe_CheckedChanged(object sender, EventArgs e)
        {
            CheckBox checkBox = sender as CheckBox;

            Properties.Settings.Default.RememberMe = checkBox.Checked;
            Properties.Settings.Default.Save();
        }
    }
}
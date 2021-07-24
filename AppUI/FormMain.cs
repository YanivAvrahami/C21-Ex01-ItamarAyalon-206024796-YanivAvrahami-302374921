using System;
using System.Drawing;
using System.Windows.Forms;
using FacebookWrapper.ObjectModel;
using FacebookWrapper;

namespace AppUI
{
    public partial class FormMain : Form
    {
        private FacebookUserFetcher facebookUserFetcher = FacebookUserFetcher.Instance;

        public FormMain()
        {
            InitializeComponent();
            FacebookService.s_CollectionLimit = 100;
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            SetSelectionBarOnButton((Button)sender);
            Clipboard.SetText("design.patterns20cc");

            LoginResult loginResult = facebookUserFetcher.Login();

            if (!string.IsNullOrEmpty(loginResult.AccessToken))
            {
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
            labelProfileStatus.Text = facebookUserFetcher.User.RelationshipStatus.ToString();
            labelProfileLocation.Text = facebookUserFetcher.User.Location.Name;
            labelProfileEmail.Text = facebookUserFetcher.User.Email;
            labelProfileBirthday.Text = facebookUserFetcher.User.Birthday;
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
            pictureBoxProfile.Image = AppUI.Properties.Resources.icons8_name_25;
            labelUserName.Text = "";
            clear();
        }

        private void btnEvents_Click(object sender, EventArgs e)
        {
            SetSelectionBarOnButton((Button)sender);
        }

        private void btnFriends_Click(object sender, EventArgs e)
        {
            SetSelectionBarOnButton((Button)sender);
        }

        private void btnPosts_Click(object sender, EventArgs e)
        {
            SetSelectionBarOnButton((Button)sender);
        }

        public void SetSelectionBarOnButton(Button i_Button) 
        {
            selectionBar.Width = i_Button.Width;
            selectionBar.Location = new Point(i_Button.Location.X, selectionBar.Location.Y);
            selectionBar.BringToFront();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
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
                this.Location = new Point(
                    (this.Location.X - lastLocation.X) + e.X, (this.Location.Y - lastLocation.Y) + e.Y);

                this.Update();
            }
        }

        private void panelMenu_MouseUp(object sender, MouseEventArgs e)
        {
            mouseDown = false;
        }

        private void clear()
        {
            pictureBoxProfilePicture.Image = null;

            labelProfileFirstName.Text = String.Empty;
            labelProfileLastName.Text = String.Empty;
            labelProfileGender.Text = String.Empty;
            labelProfileStatus.Text = String.Empty;
            labelProfileLocation.Text = String.Empty;
            labelProfileEmail.Text = String.Empty;
            labelProfileBirthday.Text = String.Empty;
        }
    }
}

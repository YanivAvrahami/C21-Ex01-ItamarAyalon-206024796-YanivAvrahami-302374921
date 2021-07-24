using System;
using System.Drawing;
using System.Windows.Forms;
using FacebookWrapper.ObjectModel;
using FacebookWrapper;

namespace BasicFacebookFeatures
{
    public partial class FormMain : Form
    {
        private User m_CurrentLoggedInUser;

        public FormMain()
        {
            InitializeComponent();
            FacebookService.s_CollectionLimit = 100;
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            SetSelectionBarOnButton((Button)sender);

            Clipboard.SetText("design.patterns20cc");
            LoginResult loginResult = FacebookService.Login(AppSettings.AppID, AppSettings.PermissionsToRequest);
            m_CurrentLoggedInUser = loginResult.LoggedInUser;
            pictureBoxProfile.Image = m_CurrentLoggedInUser.ImageSmall;
            labelUserName.Text = m_CurrentLoggedInUser.FirstName + " " + m_CurrentLoggedInUser.LastName;
        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            SetSelectionBarOnButton((Button)sender);

            FacebookService.LogoutWithUI();

            m_CurrentLoggedInUser = null;
            //DOTO: return to default profile picture
            //pictureBoxProfile.Image = m_LoggedUser.ImageSmall;
            labelUserName.Text = "";
        }

        private void btnHome_Click(object sender, EventArgs e)
        {
            SetSelectionBarOnButton((Button)sender);
        }

        private void btnEvents_Click(object sender, EventArgs e)
        {
            SetSelectionBarOnButton((Button)sender);
        }

        private void btnFriends_Click(object sender, EventArgs e)
        {
            SetSelectionBarOnButton((Button)sender);
        }

        private void btnGroups_Click(object sender, EventArgs e)
        {
            SetSelectionBarOnButton((Button)sender);
        }

        private void btnPosts_Click(object sender, EventArgs e)
        {
            SetSelectionBarOnButton((Button)sender);
        }

        private void btnNotifications_Click(object sender, EventArgs e)
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
    }
}

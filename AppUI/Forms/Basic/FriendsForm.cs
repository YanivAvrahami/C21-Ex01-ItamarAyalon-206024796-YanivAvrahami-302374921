using FacebookWrapper.ObjectModel;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace AppUI
{
    public partial class friendsForm : Form
    {
        private List<User> m_Friends;

        public friendsForm()
        {
            InitializeComponent();
            m_Friends = new List<User>();
        }

        private void btnFetchFriends_Click(object sender, EventArgs e)
        {
            m_Friends = FacebookUserFetcher.sr_Instance.FetchFriends();
            listBoxFriends.Items.Clear();
            foreach (User friend in m_Friends)
            {
                listBoxFriends.Items.Add(friend.Name);
            }
        }

        private void listBoxFriends_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listBoxFriends.SelectedIndex == -1)
            {
                return;
            }

            User user = m_Friends[listBoxFriends.SelectedIndex];

            labelFullName.Text = user.Name;
            labelGender.Text = user.Gender?.ToString();
            labelLocation.Text = user.Location?.Name;
            labelBirthday.Text = user.Birthday;
            labelStatus.Text = user.RelationshipStatus?.ToString();
            pictureBoxProfile.Image = user.ImageNormal;
        }
    }
}

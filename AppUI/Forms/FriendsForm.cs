using FacebookWrapper.ObjectModel;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AppUI
{
    public partial class FriendsForm : Form
    {
        private List<User> m_Friends;

        public FriendsForm()
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



            //listBoxEvents.Items.Clear();
            //for (int i = 0; i < m_Events.Count; i++)
            //{
            //    listBoxEvents.Items.Add(m_Events[i].Name);
            //}
            //
            //labelEventsCounted.Text = m_Events.Count.ToString();*/
        }

        private void listBoxFriends_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listBoxFriends.SelectedIndex == -1)
            {
                return;
            }

            User user = m_Friends[listBoxFriends.SelectedIndex];
        }

        /*private void listBoxPosts_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listBoxPosts.SelectedIndex == -1)
            {
                return;
            }

            Post chosen = m_Friends[listBoxPosts.SelectedIndex];

            textBoxDescption.Text = chosen.Message;
            labelName.Text = chosen.From.Name;
            labelComments.Text = chosen.Comments.Count.ToString();
            if (chosen.CreatedTime.HasValue)
            {
                labelPostedDate.Text = chosen.CreatedTime.Value.ToString("dd/MM/yy HH:mm");
            } else
            {
                labelPostedDate.Text = "-";
            }

            writeComments(chosen);
        }*/


    }
}

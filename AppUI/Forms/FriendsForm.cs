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

        private void btnFetchPosts_Click(object sender, EventArgs e)
        {

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

        private void writeComments(Post i_ThisPostComments)
        {
            //listBoxComments.Items.Clear();
            foreach (Comment comment in i_ThisPostComments.Comments)
            {
                if (comment.Message != null)
                {
                    //listBoxComments.Items.Add(comment.Message);
                } else
                {
                    //listBoxComments.Items.Add("*Hidden comment*");
                }
            }
        }
    }
}

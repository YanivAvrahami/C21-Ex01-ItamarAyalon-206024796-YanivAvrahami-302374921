using FacebookWrapper.ObjectModel;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace UI
{
    public partial class postsForm : Form
    {
        private List<Post> m_Posts;

        public postsForm()
        {
            InitializeComponent();

            m_Posts = new List<Post>();
        }

        private void btnFetchPosts_Click(object sender, EventArgs e)
        {
            m_Posts = FacebookUserFetcher.sr_Instance.FetchPosts();

            listBoxPosts.Items.Clear();
            foreach (Post post in m_Posts)
            {
                if (post.Message != null)
                {
                    listBoxPosts.Items.Add(post.Message);
                }
                else if (post.Caption != null)
                {
                    listBoxPosts.Items.Add(post.Caption);
                }
                else
                {
                    listBoxPosts.Items.Add(string.Format("[{0}]", post.Type));
                }
            }

            labelPostsCounted.Text = m_Posts.Count.ToString();
        }

        private void listBoxPosts_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listBoxPosts.SelectedIndex == -1)
            {
                return;
            }

            Post chosen = m_Posts[listBoxPosts.SelectedIndex];

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
        }

        private void writeComments(Post i_ThisPostComments)
        {
            listBoxComments.Items.Clear();
            foreach (Comment comment in i_ThisPostComments.Comments)
            {
                if (comment.Message != null)
                {
                    listBoxComments.Items.Add(comment.Message);
                } 
                else
                {
                    listBoxComments.Items.Add("*Hidden comment*");
                }
            }
        }
    }
}

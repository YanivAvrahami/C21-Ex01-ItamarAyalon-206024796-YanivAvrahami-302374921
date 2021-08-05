using FacebookWrapper.ObjectModel;
using System;
using System.Collections.Generic;
using System.Windows.Forms;
using Logic;

namespace UI.Forms
{
    public partial class groupsForm : Form
    {
        private List<Group> m_Groups;

        public groupsForm()
        {
            InitializeComponent();
            m_Groups = new List<Group>();
        }

        private void btnFetchGroups_Click(object sender, EventArgs e)
        {
            m_Groups = FacebookUserFetcher.sr_Instance.FetchGroups();
            listBoxGroups.Items.Clear();
            foreach (Group group in m_Groups)
            {
                listBoxGroups.Items.Add(group.Name);
            }
        }

        private void listBoxGroups_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listBoxGroups.SelectedIndex == -1)
            {
                return;
            }

            Group currentGroup = m_Groups[listBoxGroups.SelectedIndex];

            pictureBoxGroups.Image = currentGroup.ImageLarge;
            labelGroupDescription.Text = currentGroup.Description;
        }

        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        //private void listBoxPosts_SelectedIndexChanged(object sender, EventArgs e)
        //{
        //    if (listBoxPosts.SelectedIndex == -1)
        //    {
        //        return;
        //    }

        //    Post chosen = m_Posts[listBoxPosts.SelectedIndex];

        //    textBoxDescption.Text = chosen.Message;
        //    labelName.Text = chosen.From.Name;
        //    labelComments.Text = chosen.Comments.Count.ToString();
        //    if (chosen.CreatedTime.HasValue)
        //    {
        //        labelPostedDate.Text = chosen.CreatedTime.Value.ToString("dd/MM/yy HH:mm");
        //    }
        //    else
        //    {
        //        labelPostedDate.Text = "-";
        //    }

        //    writeComments(chosen);
        //}
    }
}

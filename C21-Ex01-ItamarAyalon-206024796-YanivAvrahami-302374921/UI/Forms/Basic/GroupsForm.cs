using System;
using FacebookWrapper.ObjectModel;
using System.Collections.Generic;
using System.Windows.Forms;
using Logic;

namespace UI
{
    public partial class GroupsForm : Form
    {
        private List<Group> m_Groups;

        public GroupsForm()
        {
            InitializeComponent();
            m_Groups = new List<Group>();
        }

        private void btnFetchGroups_Click(object sender, EventArgs e)
        {
            m_Groups = FacebookUserFetcher.Instance.FetchGroups();
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
    }
}

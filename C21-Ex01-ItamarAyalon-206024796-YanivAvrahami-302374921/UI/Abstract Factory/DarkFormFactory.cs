using System.Drawing;
using System.Windows.Forms;

namespace UI
{
    class DarkFormFactory : IFormFactory
    {
        private Color m_BackgroundColor = Color.DarkGray;

        public Form CreateAlbumsForm() 
        {
            Form newForm;
            newForm = new AlbumsForm();
            newForm.BackColor = m_BackgroundColor;
            newForm.ShowDialog();
            return newForm;
        }

        public Form CreateEventsForm()
        {
            Form newForm;
            newForm = new EventsForm();
            newForm.BackColor = m_BackgroundColor;
            newForm.ShowDialog();
            return newForm;
        }

        public Form CreateFriendsForm()
        {
            Form newForm;
            newForm = new FriendsForm();
            newForm.BackColor = m_BackgroundColor;
            newForm.ShowDialog();
            return newForm;
        }

        public Form CreateGroupsForm()
        {
            Form newForm;
            newForm = new GroupsForm();
            newForm.BackColor = m_BackgroundColor;
            newForm.ShowDialog();
            return newForm;
        }

        public Form CreatePostsForm()
        {
            Form newForm;
            newForm = new AlbumsForm();
            newForm.BackColor = m_BackgroundColor;
            newForm.ShowDialog();
            return newForm;
        }

        public Form CreateLikeRatedForm() 
        {
            Form newForm;
            newForm = new LikeRatedForm();
            newForm.BackColor = m_BackgroundColor;
            newForm.ShowDialog();
            return newForm;
        }

        public Form CreatePostsCounterForm()
        {
            Form newForm;
            newForm = new PostsCounterForm();
            newForm.BackColor = m_BackgroundColor;
            newForm.ShowDialog();
            return newForm;
        }
    }
}

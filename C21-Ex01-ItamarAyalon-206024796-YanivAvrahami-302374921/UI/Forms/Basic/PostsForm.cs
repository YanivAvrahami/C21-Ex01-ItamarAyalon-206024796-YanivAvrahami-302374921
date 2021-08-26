using System;
using FacebookWrapper.ObjectModel;
using System.Windows.Forms;
using Logic;

namespace UI
{
    public partial class PostsForm : Form
    {
        public postsForm()
        {
            InitializeComponent();

            bindComponents();
        }

        private void bindComponents()
        {
            Binding countCommentsBinding = new Binding("Text", postBindingSource, "Comments");
            countCommentsBinding.Format += countCommentsBinding_Format;
            Binding countPostsBinding = new Binding("Text", postBindingSource, "");
            countPostsBinding.Format += countPostsBinding_Format;

            labelName.DataBindings.Add(new Binding("Text", postBindingSource, "From.Name"));
            textBoxDescption.DataBindings.Add(new Binding("Text", postBindingSource, "Message"));
            labelPostsCounted.DataBindings.Add(countPostsBinding);
            labelComments.DataBindings.Add(countCommentsBinding);
        }

        private void countPostsBinding_Format(object sender, ConvertEventArgs e)
        {
            Binding theSender = sender as Binding;
            if (theSender.DataSource is BindingSource bSource)
            {
                e.Value = bSource.Count.ToString();
            }
        }

        private void countCommentsBinding_Format(object sender, ConvertEventArgs e)
        {
            Binding theSender = sender as Binding;
            if (theSender.DataSource is BindingSource bSource)
            {
                if (bSource.Current is Post post)
                {
                    e.Value = post.Comments.Count;
                }
            }
        }

        private void btnFetchPosts_Click(object sender, EventArgs e)
        {
            postBindingSource.DataSource = FacebookUserFetcher.Instance.FetchPosts();
        }
    }
}

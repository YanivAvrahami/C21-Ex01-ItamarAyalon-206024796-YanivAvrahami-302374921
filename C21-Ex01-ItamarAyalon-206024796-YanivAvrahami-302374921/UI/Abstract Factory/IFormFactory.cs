using System.Windows.Forms;

namespace UI
{
    interface IFormFactory
    {
        Form CreateAlbumsForm();
        Form CreateEventsForm();
        Form CreateFriendsForm();
        Form CreateGroupsForm();
        Form CreatePostsForm();
        Form CreateLikeRatedForm();
        Form CreatePostsCounterForm();
    }
}

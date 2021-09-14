using System.Drawing;

namespace UI
{
    public static class CommandManager
    {
        public static ICommand DisplayEventsCommand { get; }

        public static ICommand DisplayFriendsCommand { get; }

        public static ICommand DisplayPostsCommand { get; }

        public static ICommand DisplayAlbumsCommand { get; }

        public static ICommand DisplayGroupsCommand { get; }

        public static ICommand DisplayLikeRatedCommand { get; }

        public static ICommand DisplayPostsCounterCommand { get; }

        static CommandManager()
        {
            FormFactory formFactory = new FormFactory(Color.FromArgb(240, 242, 245));
            DisplayEventsCommand = new RelayCommand(() => formFactory.Create(typeof(EventsForm)).ShowDialog());
            DisplayFriendsCommand = new RelayCommand(() => formFactory.Create(typeof(FriendsForm)).ShowDialog());
            DisplayPostsCommand = new RelayCommand(() => formFactory.Create(typeof(PostsForm)).ShowDialog());
            DisplayAlbumsCommand = new RelayCommand(() => formFactory.Create(typeof(AlbumsForm)).ShowDialog());
            DisplayGroupsCommand = new RelayCommand(() => formFactory.Create(typeof(GroupsForm)).ShowDialog());
            DisplayLikeRatedCommand = new RelayCommand(() => formFactory.Create(typeof(LikeRatedForm)).ShowDialog());
            DisplayPostsCounterCommand = new RelayCommand(() => formFactory.Create(typeof(PostsCounterForm)).ShowDialog());
        }
    }
}

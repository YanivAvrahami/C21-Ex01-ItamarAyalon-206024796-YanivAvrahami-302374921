using FacebookWrapper;
using FacebookWrapper.ObjectModel;
using System.Collections.Generic;

namespace AppUI
{
    internal class FacebookUserFetcher
    {
        public static readonly FacebookUserFetcher sr_Instance = new FacebookUserFetcher();

        public User User { get; private set; }

        public bool IsLoggedIn => User != null;

        private FacebookUserFetcher()
        {
        }

        public LoginResult Login()
        {
            LoginResult loginResult = null;

            loginResult = Connect();

            if (loginResult == null)
            {
                loginResult = FacebookService.Login(AppSettings.Instance.AppID, AppSettings.Instance.PermissionsToRequest);
            }

            if (!string.IsNullOrEmpty(loginResult.AccessToken))
            {
                User = loginResult.LoggedInUser;
            }

            Properties.Settings.Default.Token = loginResult.AccessToken;
            Properties.Settings.Default.Save();

            return loginResult;
        }

        private LoginResult Connect()
        {
            if (Properties.Settings.Default.RememberMe &&
                !string.IsNullOrEmpty(Properties.Settings.Default.Token))
            {
                return FacebookService.Connect(Properties.Settings.Default.Token);
            }

            return null;
        }

        public void Logout()
        {
            User = null;
        }

        public List<Event> FetchEvents(eEventType i_Type)
        {
            FacebookObjectCollection<Event> requiredEvents = getRequiredEvents(i_Type);
            List<Event> events = new List<Event>(requiredEvents.Count);

            foreach (Event currentEvent in requiredEvents)
            {
                events.Add(currentEvent);
            }

            return events;
        }

        public List<Post> FetchPosts()
        {
            List<Post> posts = new List<Post>(User.Posts.Count);

            foreach (Post post in User.Posts)
            {
                posts.Add(post);
            }

            return posts;
        }

        public List<User> FetchFriends()
        {
            List<User> friends = new List<User>(User.Friends.Count);

            foreach (User friend in User.Friends)
            {
                friends.Add(friend);
            }
        
            return friends;
        }

        public List<FriendList> FetchFriendLists()
        {
            List<FriendList> friendLists = new List<FriendList>(User.FriendLists.Count);

            foreach (FriendList friendList in User.FriendLists)
            {
                friendLists.Add(friendList);
            }

            return friendLists;
        }

        public List<Group> FetchGroups()
        {
            List<Group> groups = new List<Group>(User.Groups.Count);

            foreach (Group group in User.Groups)
            {
                groups.Add(group);
            }

            return groups;
        }

        internal List<Album> FetchAlbums()
        {
            List<Album> albums = new List<Album>(User.Albums.Count);

            foreach (Album album in User.Albums)
            {
                albums.Add(album);
            }

            return albums;
        }

        internal List<Photo> FetchPhotos(Album i_Album)
        {
            int albumIdx = User.Albums.IndexOf(i_Album);
            if (albumIdx == -1)
            {
                return null;
            }

            List<Photo> photos = new List<Photo>();

            foreach (Photo photo in User.Albums[albumIdx].Photos)
            {
                photos.Add(photo);
            }

            return photos;
        }

        private FacebookObjectCollection<Event> getRequiredEvents(eEventType i_Type)
        {
            FacebookObjectCollection<Event> requiredEvents = null;

            switch (i_Type)
            {
                case eEventType.Events:
                    requiredEvents = User.Events;
                    break;
                case eEventType.EventsCreated:
                    requiredEvents = User.EventsCreated;
                    break;
                case eEventType.EventsDeclined:
                    requiredEvents = User.EventsDeclined;
                    break;
                case eEventType.EventsMaybe:
                    requiredEvents = User.EventsMaybe;
                    break;
                case eEventType.EventsNotYetReplied:
                    requiredEvents = User.EventsNotYetReplied;
                    break;
            }

            return requiredEvents;
        }
    }

    public enum eEventType
    {
        Events,
        EventsCreated,
        EventsDeclined,
        EventsMaybe,
        EventsNotYetReplied,
    }
}

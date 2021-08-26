using System;
using System.Collections.Generic;
using FacebookWrapper;
using FacebookWrapper.ObjectModel;

namespace Logic
{
    public class FacebookUserFetcher
    {
        private static readonly object myLock = new object();

        private static FacebookUserFetcher m_Instance = null;
        public static FacebookUserFetcher Instance 
        {
            get
            {
                if (m_Instance == null)
                {
                    lock (myLock)
                    {
                        if (m_Instance == null)
                        {
                            m_Instance = new FacebookUserFetcher();
                        }
                    }
                }
                return m_Instance;
            }
        }

        private readonly AppFetcherSettings m_AppSettings;

        public User User { get; private set; }

        public bool IsLoggedIn => User != null;

        private FacebookUserFetcher()
        {
            m_AppSettings = new AppFetcherSettings();
        }

        public LoginResult Login()
        {
            LoginResult loginResult = Connect();

            if (loginResult == null)
            {
                loginResult = FacebookService.Login(m_AppSettings.AppID, m_AppSettings.PermissionsToRequest);
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
                try
                {
                    return FacebookService.Connect(Properties.Settings.Default.Token);
                }
                catch (Exception e)
                {
                    return null;
                }
            }

            return null;
        }

        public void Logout()
        {
            User = null;
            Properties.Settings.Default.Token = "";
        }

        public FacebookObjectCollection<Event> FetchEvents(eEventType i_Type)
        {
            return getRequiredEvents(i_Type);
        }

        public FacebookObjectCollection<Post> FetchPosts()
        {
            return User.Posts;
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

        public List<Album> FetchAlbums()
        {
            List<Album> albums = new List<Album>(User.Albums.Count);

            foreach (Album album in User.Albums)
            {
                albums.Add(album);
            }

            return albums;
        }

        public FacebookObjectCollection<Photo> FetchPhotos(Album i_Album)
        {
            int albumIdx = User.Albums.IndexOf(i_Album);
            if (albumIdx == -1)
            {
                return null;
            }

            return User.Albums[albumIdx].Photos;
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
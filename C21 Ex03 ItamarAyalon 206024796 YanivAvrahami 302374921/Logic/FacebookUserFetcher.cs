using System;
using System.Collections.Generic;
using FacebookWrapper;
using FacebookWrapper.ObjectModel;

namespace Logic
{
    public sealed class FacebookUserFetcher
    {
        private static readonly object myLock = new object();
        private static readonly object fetchLock = new object();

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
        private readonly List<ILoginStrategy> r_LoginStrategies;

        public User User { get; private set; }

        public bool IsLoggedIn => User != null;

        private FacebookUserFetcher()
        {
            m_AppSettings = new AppFetcherSettings();

            r_LoginStrategies = new List<ILoginStrategy>();
            r_LoginStrategies.Add(new LoginWithTokenStrategy());
            r_LoginStrategies.Add(new RegularPopUpSignInStrategy(m_AppSettings.AppID, m_AppSettings.PermissionsToRequest));
        }

        public LoginResult Login()
        {
            LoginResult loginResult = null;

            foreach (ILoginStrategy loginStrategy in r_LoginStrategies)
            {
                loginResult = loginStrategy.TryLogin();

                if (loginResult != null)
                {
                    break;
                }
            }

            if (!string.IsNullOrEmpty(loginResult?.AccessToken))
            {
                User = loginResult.LoggedInUser;
            }

            Properties.Settings.Default.Token = loginResult.AccessToken;
            Properties.Settings.Default.Save();

            return loginResult;
        }

        public void InsertLoginStratrgy(int i_Index, ILoginStrategy i_LoginStrategy)
        {
            if (i_Index < 0 || i_Index > r_LoginStrategies.Count)
            {
                throw new IndexOutOfRangeException();
            }

            r_LoginStrategies.Insert(i_Index, i_LoginStrategy);
        }

        public void Logout()
        {
            lock (fetchLock)
            {
                User = null;
                Properties.Settings.Default.Token = string.Empty; 
            }
        }

        public FacebookObjectCollection<Event> FetchEvents(eEventType i_Type)
        {
            lock(fetchLock)
            {
                return getRequiredEvents(i_Type);
            }
        }

        public FacebookObjectCollection<Post> FetchPosts()
        {
            lock (fetchLock)
            {
                return User.Posts; 
            }
        }

        public List<User> FetchFriends()
        {
            lock (fetchLock)
            {
                List<User> friends = new List<User>(User.Friends.Count);

                foreach (User friend in User.Friends)
                {
                    friends.Add(friend);
                }

                return friends; 
            }
        }

        public List<FriendList> FetchFriendLists()
        {
            lock (fetchLock)
            {
                List<FriendList> friendLists = new List<FriendList>(User.FriendLists.Count);

                foreach (FriendList friendList in User.FriendLists)
                {
                    friendLists.Add(friendList);
                }

                return friendLists; 
            }
        }

        public List<Group> FetchGroups()
        {
            lock (fetchLock)
            {
                List<Group> groups = new List<Group>(User.Groups.Count);
                foreach (Group group in User.Groups)
                {
                    groups.Add(group);
                }

                return groups;
            }
        }

        public List<Album> FetchAlbums()
        {
            lock (fetchLock)
            {
                List<Album> albums = new List<Album>(User.Albums.Count);
                foreach (Album album in User.Albums)
                {
                    albums.Add(album);
                }

                return albums;
            }
        }

        public FacebookObjectCollection<Photo> FetchPhotos(Album i_Album)
        {
            lock (fetchLock)
            {
                int albumIdx = User.Albums.IndexOf(i_Album);
                if (albumIdx == -1)
                {
                    return null;
                }

                return User.Albums[albumIdx].Photos; 
            }
        }

        private FacebookObjectCollection<Event> getRequiredEvents(eEventType i_Type)
        {
            lock (fetchLock)
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
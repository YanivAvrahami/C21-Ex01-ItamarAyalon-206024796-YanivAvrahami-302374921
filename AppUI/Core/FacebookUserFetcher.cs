using FacebookWrapper;
using FacebookWrapper.ObjectModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
            LoginResult loginResult = FacebookService.Login(AppSettings.AppID, AppSettings.PermissionsToRequest);

            if (!string.IsNullOrEmpty(loginResult.AccessToken))
            {
                User = loginResult.LoggedInUser;
            }

            return loginResult;
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

        internal List<Album> FetchAlbums()
        {
            List<Album> albums = new List<Album>(User.Albums.Count);

            foreach (Album album in User.Albums)
            {
                albums.Add(album);
            }

            return albums;
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

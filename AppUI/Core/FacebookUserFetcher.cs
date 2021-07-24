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

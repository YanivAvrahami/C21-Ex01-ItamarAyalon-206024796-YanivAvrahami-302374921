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
        public readonly static FacebookUserFetcher Instance = new FacebookUserFetcher();

        public User User { get; private set; }

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
    }
}

using FacebookWrapper;

namespace Logic
{
    public class RegularPopUpSignInStrategy : ILoginStrategy
    {
        private static readonly object loginLock = new object();

        private readonly string r_AppID;
        private readonly string[] r_PremissionsToRequest;

        public RegularPopUpSignInStrategy(string i_AppID, string[] i_PremissionsToRequest)
        {
            r_AppID = i_AppID;
            r_PremissionsToRequest = i_PremissionsToRequest;
        }

        public LoginResult TryLogin()
        {
            lock (loginLock)
            {
                return FacebookService.Login(r_AppID, r_PremissionsToRequest);
            }
        }
    }
}
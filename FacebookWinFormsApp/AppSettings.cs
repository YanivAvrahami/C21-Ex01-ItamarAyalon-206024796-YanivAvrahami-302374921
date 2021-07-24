using System.Drawing;

namespace BasicFacebookFeatures
{
    class AppSettings
    {
        public static Point LastWindowLocation { get; set; }
        public static Size LastWindowSize { get; set; }
        public static bool RememberUser { get; set; }
        public static string LastAccessToken { get; set; }

        private string AppID { get; set; }
        private string[] PermissionsToRequest { get; set; }

        public AppSettings() 
        {
            LastWindowLocation = new Point(20, 50);
            LastWindowSize = new Size(500, 800);
            RememberUser = false;
            LastAccessToken = null;

            AppID = "1450160541956417";
            
            PermissionsToRequest = new string[] { "email", "public_profile", "user_photos", "user_hometown",
                                                  "groups_access_member_info", "user_birthday", "publish_to_groups",
                                                  "user_gender", "user_friends", "user_likes", "page_events", "user_posts"};


        }
    }
}

using System.Drawing;

namespace AppUI
{
    static class AppSettings
    {
        public static Point LastWindowLocation = new Point(20, 50);
        public static Size LastWindowSize = new Size(500, 800);
        public static bool RememberUser = false;
        public static string LastAccessToken = null;

        public static string AppID { get; }
        public static string[] PermissionsToRequest;

        static AppSettings()
        {
            LastWindowLocation = new Point(20, 50);
            LastWindowSize = new Size(500, 800);
            RememberUser = false;
            LastAccessToken = null;
            PermissionsToRequest = new string[] { "email", "public_profile", "user_photos", "user_location",
                "groups_access_member_info", "user_birthday", "publish_to_groups",
                "user_gender", "user_friends", "user_likes", "page_events", "user_posts" };

            AppID = "644877859803597";
        }
    }
}


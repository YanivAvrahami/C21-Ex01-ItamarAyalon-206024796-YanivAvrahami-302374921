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
            PermissionsToRequest = new string[] {
                // Home Profile
                "public_profile",
                "email",
                "user_location",
                "user_birthday",
                "user_gender",
                // Events form
                "user_events",
                // Posts form
                "user_posts",
                "user_likes",
                //"user_photos", - TODO: Albums
                "user_friends"
            };

            AppID = "644877859803597";
        }
    }
}


namespace AppUI
{
    public class AppSettings
    {
        public static AppSettings Instance = new AppSettings();

        public string AppID => "644877859803597";
        public string[] PermissionsToRequest { get; set; }

        private AppSettings()
        {
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
                // Albums form
                "user_photos",
                // Friends form
                "user_friends",
                // Groups form
                "groups_access_member_info",
                "publish_to_groups",
                // Feature 1
                "pages_read_engagement",
                "pages_read_user_content",

            };
        }
    }
}


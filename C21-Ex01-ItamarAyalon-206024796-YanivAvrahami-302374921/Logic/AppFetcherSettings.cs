namespace Logic
{
    internal class AppFetcherSettings
    {
        public string AppID => "644877859803597";
        public string[] PermissionsToRequest { get; set; }

        public AppFetcherSettings()
        {
            PermissionsToRequest = new string[] {
                "public_profile",
                "email",
                "user_location",
                "user_birthday",
                "user_gender",
                "user_events",
                "user_posts",
                "user_likes",
                "user_photos",
                "user_friends",
                "groups_access_member_info",
                "publish_to_groups",
                "pages_read_engagement",
                "pages_read_user_content",
            };
        }
    }
}
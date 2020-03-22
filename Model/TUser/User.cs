using System;
using System.Collections.Generic;
using System.Text;

namespace bot.Model.TUser
{
    public class User
    {
        public string ProfileImageUrl { get; }
        public string ProfileImageUrl400x400 { get; }
        public string ProfileImageUrlHttps { get; }
        public bool FollowRequestSent { get; }
        public bool DefaultProfile { get; }
        public bool DefaultProfileImage { get; }
        public int FavouritesCount { get; }
        public int ListedCount { get; }
        public string ProfileSidebarFillColor { get; }
        public string ProfileSidebarBorderColor { get; }
        public bool ProfileBackgroundTile { get; }
        public string ProfileBackgroundColor { get; }
        public string ProfileBackgroundImageUrl { get; }
        public string ProfileBackgroundImageUrlHttps { get; }
        public string ProfileBannerURL { get; }
        public string ProfileTextColor { get; }
        public string ProfileLinkColor { get; }
        public bool ProfileUseBackgroundImage { get; }
        public List<Tweet> Retweets { get; set; }
        public List<Tweet> Timeline { get; set; }
        public List<User> Contributees { get; set; }
        public List<User> Contributors { get; set; }
        public List<User> Followers { get; set; }
        public List<long> FollowerIds { get; set; }
        public string ProfileImageUrlFullSize { get; }
        public List<User> Friends { get; set; }
        public string WithheldScope { get; }
        public IEnumerable<string> WithheldInCountries { get; }
        public string TimeZone { get; }
        public int? UtcOffset { get; }
        public bool ContributorsEnabled { get; }
        public bool IsTranslator { get; }
        public List<long> FriendIds { get; set; }
        public List<Tweet> FriendsRetweets { get; set; }
        public List<Tweet> TweetsRetweetedByFollowers { get; set; }
        public UserEntities Entities { get; }
        public UserIdentifier UserIdentifier { get; }
        public string Name { get; }
        public string Description { get; }
        public DateTime CreatedAt { get; }
        public string Location { get; }
        public bool GeoEnabled { get; }
        public string Url { get; }
        public int StatusesCount { get; }
        public int FollowersCount { get; }
        public int FriendsCount { get; }
        public bool Following { get; }
        public bool Protected { get; }
        public bool Verified { get; }
        public bool Notifications { get; }
    }
}

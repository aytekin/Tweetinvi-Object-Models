using bot.Model.TUser;
using System;
using System.Collections.Generic;
using System.Text;

namespace bot.Model
{
    public class Tweet
    {
        public int RetweetCount { get; set; }
        public bool Favorited { get; set; }
        public int FavoriteCount { get; set; }
        public bool Retweeted { get; set; }
        public bool PossiblySensitive { get; set; }
        public Dictionary<string, object> Scopes { get; set; }
        public string FilterLevel { get; set; }
        public bool WithheldCopyright { get; set; }
        public IEnumerable<string> WithheldInCountries { get; set; }
        public string WithheldScope { get; set; }
        public DateTime TweetLocalCreationDate { get; set; }
        public List<HashtagEntity> Hashtags { get; set; }
        public List<UrlEntity> Urls { get; set; }
        public List<MediaEntity> Media { get; set; }
        public List<UserMentionEntity> UserMentions { get; set; }
        public List<Tweet> Retweets { get; set; }
        public bool IsRetweet { get; set; }
        public Tweet RetweetedTweet { get; set; }
        public int? QuoteCount { get; set; }
        public long? QuotedStatusId { get; set; }
        public string QuotedStatusIdStr { get; set; }
        public Tweet QuotedTweet { get; set; }
        public bool IsTweetPublished { get; set; }
        public TweetEntities Entities { get; set; }
        public bool IsTweetDestroyed { get; set; }
        public string Url { get; set; }
        public int[] ContributorsIds { get; set; }
        public DateTime CreatedAt { get; set; }
        public string Text { get; set; }
        public string Prefix { get; set; }
        public string Suffix { get; set; }
        public string FullText { get; set; }
        public int[] DisplayTextRange { get; set; }
        public IEnumerable<long> Contributors { get; set; }
        public ExtendedTweet ExtendedTweet { get; set; }
        public int[] SafeDisplayTextRange { get; set; }
        public bool Truncated { get; set; }
        public string Source { get; set; }
        public User CreatedBy { get; set; }
        public string InReplyToScreenName { get; set; }
        public string InReplyToUserIdStr { get; set; }
        public TweetIdentifier CurrentUserRetweetIdentifier { get; set; }
        public string InReplyToStatusIdStr { get; set; }
        public long? InReplyToStatusId { get; set; }
        public int? ReplyCount { get; set; }
        public long? InReplyToUserId { get; set; }

    }
}

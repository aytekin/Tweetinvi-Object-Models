using System;
using System.Collections.Generic;
using System.Text;

namespace bot.Model
{
    public class ExtendedTweet
    {
        public string Text { get; set; }
        public string FullText { get; set; }
        public int[] DisplayTextRange { get; set; }
        public TweetEntities LegacyEntities { get; set; }
        public TweetEntities ExtendedEntities { get; set; }
    }
}

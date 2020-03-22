using System;
using System.Collections.Generic;
using System.Text;

namespace bot.Model
{
    public class ObjectEntities
    {
        public List<UrlEntity> Urls { get; }
        public List<UserMentionEntity> UserMentions { get; }
        public List<HashtagEntity> Hashtags { get; }
        public List<SymbolEntity> Symbols { get; }
        public List<MediaEntity> Medias { get; }
    }
}

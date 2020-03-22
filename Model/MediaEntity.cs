using System;
using System.Collections.Generic;
using System.Text;

namespace bot.Model
{
    public class MediaEntity
    {
        public long? Id { get; set; }
        public string IdStr { get; set; }
        public string MediaURL { get; set; }
        public string MediaURLHttps { get; set; }
        public string URL { get; set; }
        public string DisplayURL { get; set; }
        public string ExpandedURL { get; set; }
        public string MediaType { get; set; }
        public int[] Indices { get; set; }
        public Dictionary<string, IMediaEntitySize> Sizes { get; set; }
        public IVideoInformationEntity VideoDetails { get; set; }
    }
}

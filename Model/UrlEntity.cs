using System;
using System.Collections.Generic;
using System.Text;

namespace bot.Model
{
    public class UrlEntity
    {
        public string URL { get; set; }
        public string DisplayedURL { get; set; }
        public string ExpandedURL { get; set; }
        public int[] Indices { get; set; }
    }
}

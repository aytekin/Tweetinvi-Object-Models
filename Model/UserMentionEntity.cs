using System;
using System.Collections.Generic;
using System.Text;

namespace bot.Model
{
    public class UserMentionEntity
    {
        public long? Id { get; set; }
        public string IdStr { get; set; }
        public string ScreenName { get; set; }
        public string Name { get; set; }
        public IList<int> Indices { get; set; }
    }
}

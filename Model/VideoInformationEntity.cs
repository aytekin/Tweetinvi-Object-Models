using System;
using System.Collections.Generic;
using System.Text;

namespace bot.Model
{
    public class VideoInformationEntity
    {
        public int[] AspectRatio { get; set; }
        public int DurationInMilliseconds { get; set; }
        public VideoEntityVariant[] Variants { get; set; }
    }
}

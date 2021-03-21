using System.Collections.Generic;

namespace TikTokWrapper.Core.DTO
{
    public class Video
    {
        public string id { get; set; }
        public int height { get; set; }
        public int width { get; set; }
        public int duration { get; set; }
        public string ratio { get; set; }
        public string cover { get; set; }
        public string originCover { get; set; }
        public string dynamicCover { get; set; }
        public string playAddr { get; set; }
        public string downloadAddr { get; set; }
        public List<string> shareCover { get; set; }
        public string reflowCover { get; set; }
    }
}
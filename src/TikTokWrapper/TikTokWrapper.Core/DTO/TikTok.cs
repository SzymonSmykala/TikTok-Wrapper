using System.Collections.Generic;

namespace TikTokWrapper.Core.DTO
{
    public class TikTok
    {
        public string id { get; set; }
        public string desc { get; set; }
        public int createTime { get; set; }
        public Video video { get; set; }
        public Author author { get; set; }
        public Music music { get; set; }
        public List<Challenge> challenges { get; set; }
        public Stats stats { get; set; }
        public DuetInfo duetInfo { get; set; }
        public bool originalItem { get; set; }
        public bool officalItem { get; set; }
        public List<TextExtra> textExtra { get; set; }
        public bool secret { get; set; }
        public bool forFriend { get; set; }
        public bool digged { get; set; }
        public int itemCommentStatus { get; set; }
        public bool showNotPass { get; set; }
        public bool vl1 { get; set; }
        public bool itemMute { get; set; }
        public AuthorStats authorStats { get; set; }
        public bool privateItem { get; set; }
        public bool duetEnabled { get; set; }
        public bool stitchEnabled { get; set; }
        public bool shareEnabled { get; set; }
        public bool isAd { get; set; }
    }
}
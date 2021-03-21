using System.Collections.Generic;

namespace TikTokWrapper.Console
{
    // TikTok myDeserializedClass = JsonConvert.DeserializeObject<TikTok>(myJsonResponse); 
    // TikTok myDeserializedClass = JsonConvert.DeserializeObject<TikTok>(myJsonResponse); 
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

    public class Author
    {
        public string id { get; set; }
        public string uniqueId { get; set; }
        public string nickname { get; set; }
        public string avatarThumb { get; set; }
        public string avatarMedium { get; set; }
        public string avatarLarger { get; set; }
        public string signature { get; set; }
        public bool verified { get; set; }
        public string secUid { get; set; }
        public bool secret { get; set; }
        public bool ftc { get; set; }
        public int relation { get; set; }
        public bool openFavorite { get; set; }
        public int commentSetting { get; set; }
        public int duetSetting { get; set; }
        public int stitchSetting { get; set; }
        public bool privateAccount { get; set; }
    }

    public class Music
    {
        public string id { get; set; }
        public string title { get; set; }
        public string playUrl { get; set; }
        public string coverThumb { get; set; }
        public string coverMedium { get; set; }
        public string coverLarge { get; set; }
        public string authorName { get; set; }
        public bool original { get; set; }
        public int duration { get; set; }
        public string album { get; set; }
    }

    public class Challenge
    {
        public string id { get; set; }
        public string title { get; set; }
        public string desc { get; set; }
        public string profileThumb { get; set; }
        public string profileMedium { get; set; }
        public string profileLarger { get; set; }
        public string coverThumb { get; set; }
        public string coverMedium { get; set; }
        public string coverLarger { get; set; }
        public bool isCommerce { get; set; }
    }

    public class Stats
    {
        public int diggCount { get; set; }
        public int shareCount { get; set; }
        public int commentCount { get; set; }
        public int playCount { get; set; }
    }

    public class DuetInfo
    {
        public string duetFromId { get; set; }
    }

    public class TextExtra
    {
        public string awemeId { get; set; }
        public int start { get; set; }
        public int end { get; set; }
        public string hashtagName { get; set; }
        public string hashtagId { get; set; }
        public int type { get; set; }
        public string userId { get; set; }
        public bool isCommerce { get; set; }
        public string userUniqueId { get; set; }
        public string secUid { get; set; }
    }

    public class AuthorStats
    {
        public int followingCount { get; set; }
        public int followerCount { get; set; }
        public int heartCount { get; set; }
        public int videoCount { get; set; }
        public int diggCount { get; set; }
        public int heart { get; set; }
    }

    public class MyArray
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

    public class Root
    {
        public List<MyArray> MyArray { get; set; }
    }



}
namespace TikTokWrapper.Core.DTO
{
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
}
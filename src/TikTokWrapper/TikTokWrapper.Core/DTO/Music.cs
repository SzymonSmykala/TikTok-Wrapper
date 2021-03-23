namespace TikTokWrapper.Core.DTO
{
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
}
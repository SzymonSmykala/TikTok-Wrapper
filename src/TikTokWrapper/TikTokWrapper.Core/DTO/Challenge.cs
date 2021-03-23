namespace TikTokWrapper.Core.DTO
{
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
}
namespace TikTokWrapper.Core.Factories
{
    public interface ITikTokManagerFactory
    {
        ITikTokManager Create(string pythonExePath);
        ITikTokManager Create();
    }
}
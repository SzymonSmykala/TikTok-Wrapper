namespace TikTokWrapper.Core.Providers
{
    internal interface IPythonExecutablePathProvider
    {
        string Get(string requiredVersion = "", string maxVersion = "");
    }
}
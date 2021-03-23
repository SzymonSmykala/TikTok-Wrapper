namespace TikTokWrapper.Core.Internal.Utilities
{
    internal interface IPythonRunner
    {
        string Run(string filePythonScript, out string standardError);
    }
}
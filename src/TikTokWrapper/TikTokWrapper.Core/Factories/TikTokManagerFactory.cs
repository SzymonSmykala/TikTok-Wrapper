using TikTokWrapper.Core.Internal;
using TikTokWrapper.Core.Internal.Utilities;

namespace TikTokWrapper.Core.Factories
{
    public class TikTokManagerFactory : ITikTokManagerFactory
    {
        public ITikTokManager Create(string pythonExePath)
        {
            var pythonRunner = new PythonRunner(pythonExePath);
            return new TikTokManager(pythonRunner);
        }
    }
}
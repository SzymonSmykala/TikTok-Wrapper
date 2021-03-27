using TikTokWrapper.Core.Internal;
using TikTokWrapper.Core.Internal.Utilities;
using TikTokWrapper.Core.Providers;

namespace TikTokWrapper.Core.Factories
{
    public class TikTokManagerFactory : ITikTokManagerFactory
    {
        public ITikTokManager Create(string pythonExePath)
        {
            var pythonRunner = new PythonRunner(pythonExePath);
            return new TikTokManager(pythonRunner);
        }

        public ITikTokManager Create()
        {
            var pythonExePathProvider = new PythonExecutablePathProvider();
            var pythonExePath = pythonExePathProvider.Get();
            var pythonRunner = new PythonRunner(pythonExePath);
            return new TikTokManager(pythonRunner);
        }
    }
}
using System.Collections.Generic;
using Newtonsoft.Json;
using TikTokWrapper.Core.DTO;
using TikTokWrapper.Core.Exceptions;
using TikTokWrapper.Core.Internal.Utilities;

namespace TikTokWrapper.Core.Internal
{
    internal class TikTokManager : ITikTokManager
    {
        private IPythonRunner _runner;

        public TikTokManager(IPythonRunner runner)
        {
            _runner = runner;
        }

        public List<TikTok> GetTrending()
        {
            string error;
            var result = _runner.Run(@"C:\Users\Szymon\repos\TikTok-Wrapper\TikTok-Api\test.py", out error);

            if (!string.IsNullOrEmpty(error))
            {
                throw new PythonRunnerException(error);
            }

            return JsonConvert.DeserializeObject<List<TikTok>>(result);
        }
    }
}
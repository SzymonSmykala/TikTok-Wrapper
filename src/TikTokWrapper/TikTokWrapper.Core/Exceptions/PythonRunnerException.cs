using System;

namespace TikTokWrapper.Core.Exceptions
{
    public class PythonRunnerException : Exception
    {
        public PythonRunnerException(string error) : base(error)
        {
        }
    }
}
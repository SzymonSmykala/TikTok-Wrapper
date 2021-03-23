using System;
using System.Diagnostics;

namespace TikTokWrapper.Core.Internal.Utilities
{
    internal class PythonRunner
    {
        public readonly string _filePythonExePath;

        public PythonRunner(string exePythonPath)
        {
            _filePythonExePath = exePythonPath;
        }

        public string Run(string filePythonScript, out string standardError)
        {
            var outputText = string.Empty;
            standardError = string.Empty;
            try
            {
                using Process process = new Process
                {
                    StartInfo = new ProcessStartInfo(_filePythonExePath)
                    {
                        Arguments = filePythonScript,
                        UseShellExecute = false,
                        RedirectStandardOutput = true,
                        RedirectStandardError = true,
                        CreateNoWindow = true
                    }
                };
                process.Start();
                outputText = process.StandardOutput.ReadToEnd();
                outputText = outputText.Replace(Environment.NewLine, string.Empty);
                standardError = process.StandardError.ReadToEnd();
                process.WaitForExit();
            }
            catch (Exception ex)
            {
                var exceptionMessage = ex.Message;
            }
            return outputText;
        }
    }
}
using System;
using System.Collections.Generic;
using System.Text.Json;
using System.Web.Helpers;
using IronPython.Hosting;
using Microsoft.Scripting.Hosting;
using Newtonsoft.Json;
using TikTokWrapper.Core.RunPythonScript;

namespace TikTokWrapper.Console
{
    class Program
    {
        static void Main(string[] args)
        {
            //            ScriptEngine engine = Python.CreateEngine();
            //
            //            ICollection<string> searchPaths = engine.GetSearchPaths();
            //            searchPaths.Add(@"C:\Users\Szymon\appdata\local\programs\python\python39\lib\site-packages");
            ////            searchPaths.Add("J:\\Python\\test2\\venv\\Lib\\site-packages");
            //            engine.SetSearchPaths(searchPaths);
            //            ScriptScope scope = engine.CreateScope();
            //            engine.ExecuteFile(@"C:\Users\Szymon\repos\TikTok-Wrapper\TikTok-Api\test.py", scope);
            //            dynamic testFunction = scope.GetVariable("get_trending");
            //            var result = testFunction();

            MlSharpPython runner = new MlSharpPython(@"C:\Users\Szymon\AppData\Local\Programs\Python\Python39\python.exe");
            string error = "";
            var result = runner.ExecutePythonScript(@"C:\Users\Szymon\repos\TikTok-Wrapper\TikTok-Api\test.py", out error);
            System.Console.WriteLine("*RESULT START");
            System.Console.WriteLine(result);
            System.Console.WriteLine("RESULT END*");
            System.Console.WriteLine(error);

            dynamic data = Json.Decode(result);

        }
    }
}

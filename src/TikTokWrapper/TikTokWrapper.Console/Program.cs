using TikTokWrapper.Core;
using TikTokWrapper.Core.Factories;

namespace TikTokWrapper.WindowsConsole
{
    class Program
    {
        static void Main(string[] args)
        {
           ITikTokManagerFactory factory = new TikTokManagerFactory();
           var manager = factory.Create(@"C:\Users\Szymon\AppData\Local\Programs\Python\Python39\python.exe");
           var trending = manager.GetTrending();
        }
    }
}

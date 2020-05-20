using System;
using System.Linq;
using System.Diagnostics;
using System.Threading;
using System.IO;
using System.Runtime.InteropServices;
using System.Collections.Generic;

namespace BingPointsNetCore
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(Directory.GetCurrentDirectory());
            string fullPtah = Path.GetDirectoryName(new Uri(System.Reflection.Assembly.GetExecutingAssembly().CodeBase).LocalPath);
            Console.WriteLine(Path.GetRelativePath("BingPointsNetCore", fullPtah));
            //Console.WriteLine(Figgle.FiggleFonts.Standard.Render("Hello, World!"));

            executeSearch();
        }

        static void executeSearch()
        {
            string filePath = "phrases.txt";
            //Get List of phrases from File
            List<String> phrases = new List<string>(File.ReadAllLines(filePath));
            string url = "https://account.microsoft.com/rewards/";
            openURL(url);
            Thread.Sleep(3000);
            for (int i = 0; i < 30; i++)
            {
                Random rnd = new Random();
                int index = rnd.Next(phrases.Count);
                string strPhrase = phrases[index];
                phrases.RemoveAt(index);
                url = "https://www.bing.com/search?q=" + strPhrase;
                openURL(url);
                Thread.Sleep(3000);
            }
            url = "https://account.microsoft.com/rewards/";
            openURL(url);

            //if you want to update the contents of the txt file 
            //phrases.ForEach(Console.WriteLine);
            //File.WriteAllLines(filePath, phrases);
        }

        static void openURL(string url)
        {
            // Good Link for Reference using Process in Multiple Platforms
            // https://brockallen.com/2016/09/24/process-start-for-urls-on-net-core/
            if (RuntimeInformation.IsOSPlatform(OSPlatform.Windows))
            {
                url = url.Replace("&", "^&");
                Process.Start(new ProcessStartInfo("cmd", $"/c start {url}") { CreateNoWindow = false });
            }
            else if (RuntimeInformation.IsOSPlatform(OSPlatform.OSX))
            {
                Process.Start("open", url);
            }
        }

    }
}

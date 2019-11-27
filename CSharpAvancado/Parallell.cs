using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace CSharpAvancado
{
    class Parallell
    {
        public static void Main(string[] args)
        {
            List<string> urls = new List<string>();
            for (int i = 0; i < 100; i++)
                urls.Add(i.ToString() + ".jpg");

            ParallelOptions op = new ParallelOptions();
            op.MaxDegreeOfParallelism = 10;

            Parallel.For(0, urls.Count, i => 
            {
                DownloadFile(urls[i]);
            });

            Parallel.Invoke(() =>
            {
                DownloadFile("Chrome.exe");
            },
            () =>
            {
                DownloadFile("Opera.exe");
            });

            Console.ReadKey();
        }

        static void DownloadFile(string url)
        {
            Thread.Sleep(5000);
            Console.WriteLine("Download done: {0} ThereadID: {1}", url, Thread.CurrentThread.ManagedThreadId);
        }
    }
}

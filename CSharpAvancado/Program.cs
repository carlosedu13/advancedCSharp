using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace CSharpAvancado
{
    class Program
    {
        static void Main(string[] args)
        {
            int sum = 0; // sum var
            bool completed = false; // Control

            Thread thread = new Thread(new ThreadStart(() =>
            {
                while (!completed || sum < 1000000) // While control var is false. Control var have be change in main thread
                {
                    sum += 1;
                }
            }));

            thread.Start(); // start secondary thread
            Thread.Sleep(10000); // Sleep for ten seconds the main thread
            completed = true;
            thread.Join();

            Console.WriteLine("Sum is: {0}", sum);
            Console.ReadKey();

        }
    }
}

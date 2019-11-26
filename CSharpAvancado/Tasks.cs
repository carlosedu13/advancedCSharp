using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpAvancado
{
 

    public class Tasks
    {
        private static void DoJob()
        {
            for (int i = 0; i < 100; i++)
                Console.WriteLine(i);
        }

        private static double Dobro(double x)
        {
            return 2 * x;
        }

        static void Main(string[] args)
        {
            // Tasks alike Threads
            Task t = new Task(DoJob);
            t.Start();

            Task t1 = Task.Run(() =>
            {
                for (int i = 0; i < 100; i++)
                    Console.WriteLine(i);
            });

            Task.Run(() => DoJob());
            Task.Factory.StartNew(DoJob);

            //Task<Double> dobro = new Task<double>(Dobro(10.2));
            Task<double> dobro = Task.Run(() => Dobro(15.0));
        }

    }
}

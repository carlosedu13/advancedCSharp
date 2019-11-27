using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpAvancado
{
    class ArrayOfTasks
    {
        public static void Main(string[] args)
        {
            Task[] tasks = new Task[2]
            {
                Task.Factory.StartNew(() =>
                {
                    Console.WriteLine("Task1");
                }),
                Task.Factory.StartNew(() =>
                {
                    Console.WriteLine("Task2");
                }),
            };

            Task.WaitAll(tasks);

            Console.ReadKey();
        }
    }
}

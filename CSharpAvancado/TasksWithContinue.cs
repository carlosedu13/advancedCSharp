using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpAvancado
{
    class TasksWithContinue
    {
        public static void Main(string[] args)
        {
            Task<int> passo1 = Task.Factory.StartNew(() =>
            {
                Random r = new Random();
                return (int)r.Next(100);
            });

            Task<int> passo2 = passo1.ContinueWith(numero => numero.Result * 2);
            Task<int> passo3 = passo2.ContinueWith(numero => numero.Result * 3);

            Console.WriteLine(passo3.Result);

            Console.ReadKey();
        }
    }
}

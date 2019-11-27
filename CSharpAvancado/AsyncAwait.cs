using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpAvancado
{
    class AsyncAwait
    {
        public static void Main(string[] args)
        {
            PrintMessage("John the ripper");

            Console.ReadKey();
        }

        static async void PrintMessage(string name)
        {
            Console.WriteLine("{0}", await Task.Run(() => GetMessage(name)));
        }
        
        static string GetMessage(string name)
        {
            return $"Hello, {name}";
        }
    }
}

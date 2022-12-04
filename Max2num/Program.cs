using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Max2num
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = int.Parse(Console.ReadLine());
            int b = int.Parse(Console.ReadLine());

            if (a > b) Console.WriteLine($"Max: {a}");
            else Console.WriteLine($"Max: {b}");

            Console.ReadLine();
        }
    }
}

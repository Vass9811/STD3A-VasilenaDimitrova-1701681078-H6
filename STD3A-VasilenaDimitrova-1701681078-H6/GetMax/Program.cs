using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GetMax
{
    class Program
    {
        static void Main(string[] args)
        {
            GetMax();
        }
        static void GetMax()
        {
            Console.WriteLine("Enter first number:");
            int a = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter second number:");
            int b = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter third number");
            int c = int.Parse(Console.ReadLine());
            Console.WriteLine("The biggest number is {0}", Math.Max(Math.Max(a, b), c));
        }
    }
}

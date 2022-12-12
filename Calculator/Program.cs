using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter first digit : ");
            string astr = Console.ReadLine();
            double a = Convert.ToDouble(astr);
            Console.WriteLine("Enter second digit : ");
            string bstr = Console.ReadLine();
            double b = Convert.ToDouble(astr);

            Console.ReadLine();

        }
    }
}

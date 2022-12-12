﻿using System;
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
            Console.WriteLine("Enter the Operation from addition, substraction, multiplication, division, modulus, square, square root ");
            string opr= Console.ReadLine();

            Console.WriteLine("Enter first digit : ");
            string astr = Console.ReadLine();
            double a = Convert.ToDouble(astr);

            Console.WriteLine("Enter second digit : ");
            string bstr = Console.ReadLine();
            double b = Convert.ToDouble(bstr);

            operation oprtn = new operation();
            switch (opr)
            {
                case "addition":
                    Console.WriteLine(oprtn.addition(a, b));
                    break;
                case "substraction":
                    Console.WriteLine(oprtn.substraction(a, b));
                    break;
                case "multiplication":
                    Console.WriteLine(oprtn.multiplication(a, b));
                    break;
                case "division":
                    Console.WriteLine(oprtn.division(a, b));
                    break;
                case "modulus":
                    Console.WriteLine(oprtn.modulus(a, b));
                    break;
                case "square":
                    Console.WriteLine(oprtn.square(a));
                    break;
                case "square root":
                    Console.WriteLine(oprtn.squareRoot(a));
                    break;
            }



            

            Console.ReadLine();

        }
    }
}

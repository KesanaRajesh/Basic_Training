﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day3_DotNet_Training
{
    class Program
    {
        public static int Calculator(int a, int b, out int sum, out int product, out int division)
        {
            sum = a + b;  //addition
            product = a * b;  //multiplication
            division = a / b; //division
            return a - b; // difference
        }

        //params example

        public static void ParamsMethod(params int[] numbers)
        {

        }
        static void Main(string[] args)
        {
            Console.WriteLine("-------Output Parameters--------");

            int Total, Prod, Difference, division;

            Difference = Program.Calculator(12, 6, out Total, out Prod, out division);
            Console.WriteLine("Sum = {0} Product = {1},  Difference = {2} , and division = {3}",  Total, Prod, Difference,division);

            Console.WriteLine("-----------------params example---------------");
            Console.Read();
        }
    }
}

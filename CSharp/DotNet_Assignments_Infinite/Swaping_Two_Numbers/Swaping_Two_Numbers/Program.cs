using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Swaping_Two_Numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter The Number1: ");
            int number1 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter The Number2: ");
            int number2 = Convert.ToInt32(Console.ReadLine());

            int temp;

            Console.WriteLine("Numbers Before Swapping: ");
            Console.WriteLine("Number1 is: " +number1+ " ");
            Console.WriteLine("Number2 is: " + number2 + " ");

            temp = number1;
            number1 = number2;
            number2 = temp;

            Console.WriteLine("Numbers After Swapping: ");
            Console.WriteLine("Number1 is: " + number1 + " ");
            Console.WriteLine("Number2 is: " + number2 + " ");

            Console.ReadLine();
        }
    }
}

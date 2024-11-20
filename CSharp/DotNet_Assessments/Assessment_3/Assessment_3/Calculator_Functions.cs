using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;



//Write a console program that uses delegate object as an argument to call Calculator Functionalities like 1. Addition, 2. Subtraction and 3. Multiplication by taking 2 integers and returning the output to the user.
//You should display all the return values accordingly.

namespace Assessment_3
{
    class Calculator_Functions
    {

        public delegate int Calculator(int a, int b);

        static void Main(string[] args)
        {

            Console.WriteLine("Operations:");
            Console.WriteLine("a. Addition");
            Console.WriteLine("b. Subtraction");
            Console.WriteLine("c. Multiplication");

            Console.Write("Enter your choice (a/b/c): ");
            string choice = Console.ReadLine();

            Console.Write("Enter the first number: ");
            int number1 = Convert.ToInt32(Console.ReadLine());

            Console.Write("Enter the second number: ");
            int number2 = Convert.ToInt32(Console.ReadLine());

            Calculator cal = null;

            switch (choice)
            {
                case "a":
                    cal = Add;
                    break;
                case "b":
                    cal = Subtract;
                    break;
                case "c":
                    cal = Multiply;
                    break;
                default:
                    Console.WriteLine("****Invalid****");
                    return;
            }

            int solution = cal(number1, number2);
            Console.WriteLine($"The solution is: {solution}");
            Console.Read();
        }

        public static int Add(int a, int b)
        {
            return a + b;
        }

        public static int Subtract(int a, int b)
        {
            return a - b;
        }

        public static int Multiply(int a, int b)
        {
            return a * b;
        }
    }
}


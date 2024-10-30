using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Performing_All_Operations
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Enter The Number1: ");
            int number1 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter The Operator: ");
            String operater = Console.ReadLine();

            Console.WriteLine("Enter The Number2: ");
            int number2 = Convert.ToInt32(Console.ReadLine());

            if(operater == "+")
            {
                Console.WriteLine(number1 + number2);
            }
            else if(operater == "-")
            {
                Console.WriteLine(number1 - number2);
            }
            else if (operater == "*")
            {
                Console.WriteLine(number1  *  number2);
            }
            else if (operater == "/")
            {
                Console.WriteLine(number1 / number2);
            }
            Console.Read();

        }
    }
}

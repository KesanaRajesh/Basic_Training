using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Triple_Sum
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the Number1: ");
            int number1 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter the Number2: ");
            int number2 = Convert.ToInt32(Console.ReadLine());

            int sum = number1 + number2;

            if(number1 == number2)
            {
                int solution = 3 * sum;
                Console.WriteLine(solution);
            }
            else
            {
                Console.WriteLine(sum);
            }
            Console.Read();

        }
    }
}

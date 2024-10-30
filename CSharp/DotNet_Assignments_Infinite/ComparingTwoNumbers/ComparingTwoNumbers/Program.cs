using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ComparingTwoNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter A Number1: ");
            int number1 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter A Number2: ");
            int number2 = Convert.ToInt32(Console.ReadLine());

            if(number1 == number2)
            {
                Console.WriteLine("Two Numbers Are Equal");
                Console.Read();
            }
            else
            {
                Console.WriteLine("Two Numbers Are Not Equal");
                Console.Read();


            }
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PositiveOrNegativeNumber
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter A Number: ");
            int number = Convert.ToInt32(Console.ReadLine());
            if(number > 0)
            {
                Console.WriteLine("Given Number Is Positive");
            }
            else if(number < 0)
            {
                Console.WriteLine("Given Number is Negative");
            }
            else
            {
                Console.WriteLine("Invalid Number");
            }
            Console.Read();
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assessment_2
{
    class NumberException_MainClass
    {
        public static void Main()
        {
            Console.Write("Enter a number: ");
            int number = Convert.ToInt32(Console.ReadLine());

            try
            {
                CheckForNegative(number);
                Console.WriteLine("The number is valid.");
            }
            catch (ArgumentOutOfRangeException ex)
            {
                Console.WriteLine($"Exception: {ex.Message}");
            }
            Console.Read();
        }

        static void CheckForNegative(int number)
        {
            if (number < 0)
            {
                throw new ArgumentOutOfRangeException( "The number cannot be negative.");
            }
        }
    }
}
    

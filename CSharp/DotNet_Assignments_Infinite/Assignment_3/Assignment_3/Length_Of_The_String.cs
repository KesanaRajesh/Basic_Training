using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_3
{
    class Length_Of_The_String
    {
        public static void LengthOfTheString()
        {
            Console.WriteLine("Enter The Word: ");
            String word = Console.ReadLine();
            Console.WriteLine("Length Of The Word Is: " + word.Length);
        }
        static void Main(string[] args)
        {
            LengthOfTheString();
            Console.Read();
        }
    }
}

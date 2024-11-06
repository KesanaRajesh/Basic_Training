using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_3
{
    class Comparing_Two_Strings
    {
        public static void Main(String[]args)
        {
            Console.WriteLine("Enter The String1: ");
            String string1 = Console.ReadLine();
            Console.WriteLine("Enter The String2: ");
            String string2 = Console.ReadLine();

            if(String.Equals(string1,string2))
            {
                Console.WriteLine("Two Strings Are Equal");
            }
            else
            {
                Console.WriteLine("Two Strings are Not Equal");
                Console.Read();
            }
        }
    }
}

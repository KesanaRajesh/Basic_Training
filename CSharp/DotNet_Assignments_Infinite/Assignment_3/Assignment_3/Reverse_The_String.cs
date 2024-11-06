using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_3
{
    class Reverse_The_String
    {

      
        public  static void ReverseString()
        {
            Console.WriteLine("Enter a string : ");
            String originalstring = Console.ReadLine();
            String reverseword = "";

            for(int i=originalstring.Length-1;i>=0;i--)
            {
                reverseword = reverseword + originalstring[i];
            }
            Console.WriteLine(reverseword);
        }
        static void Main(string[] args)
        {
            ReverseString();
            Console.Read();
        }


    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day3_DotNet
{
    class Program
    {
        static void Main(string[] args)
        {
            StringOperations();
            Console.Read();
        }

        public static void StringOperations()
        {
            string str = "Rajesh";
            Console.WriteLine("str for the first time is: {0}", str.GetHashCode());

            //Strings are immutable

            str = "Hello World";
            Console.WriteLine("str for the Second time is: {0}", str.GetHashCode());

            Console.WriteLine("--------String Builder--------------");

            StringBuilder stringBuilder = new StringBuilder("Hello");
            Console.WriteLine("stringbuilder hash code is: {0}" , stringBuilder.GetHashCode());

            stringBuilder.Append("Welcome To CSharp");
            Console.WriteLine(stringBuilder);
            stringBuilder.Capacity();
        }
    }
}

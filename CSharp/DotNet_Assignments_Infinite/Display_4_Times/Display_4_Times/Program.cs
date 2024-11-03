using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Display_4_Times
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter A Number: ");
            int number = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("{0} {0} {0} {0}" , number);
            Console.WriteLine("{0}{0}{0}{0}" , number);
            Console.WriteLine("{0} {0} {0} {0}", number);
            Console.WriteLine("{0}{0}{0}{0}", number);

            Console.Read();
        }
    }
}

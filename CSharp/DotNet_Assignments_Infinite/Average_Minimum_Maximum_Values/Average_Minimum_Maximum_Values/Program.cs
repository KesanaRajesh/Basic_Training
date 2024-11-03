using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Average_Minimum_Maximum_Values
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] array = new int[5] { 10, 20, 30, 40, 50 };
            Console.WriteLine("Average Number is:" + array.Average() );
            Console.WriteLine("------------------");
            Console.WriteLine("Average Number is:" + array.Min());
            Console.WriteLine("-------------------");
            Console.WriteLine("Average Number is:" + array.Max());

            Console.Read();


        }
    }
}

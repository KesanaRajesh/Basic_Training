using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

//3.Write a program in C# Sharp to count the number of lines in a file.

namespace Assignment_5
{
    class Count_No_Of_Lines_In_The_File
    {
        public static void Main(string[]args)
        {
            string path = @"C:\DotNet_Training\Infinite_1\Basics.txt";
            if (File.Exists(path))
            {
                int count = File.ReadAllLines(path).Length;
                Console.WriteLine("Number of Lines in the file is: {0}", count);
            }
            else
            {
                Console.WriteLine("File not Exist");
            }
            Console.Read();
        }
    }
}

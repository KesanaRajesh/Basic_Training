﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Storing_In_Another_Array
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] array1 = new int[5] { 5, 6, 7, 8, 9 };
            int[] array2 = array1;
            for(int i=0;i<array2.Length;i++)
            {
                
                Console.WriteLine(array2[i] + " ");
            }
          
            Console.ReadLine();
        }
    }
}
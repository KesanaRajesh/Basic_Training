﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//Write a class Box that has Length and breadth as its members. Write a function that adds 2 box objects and stores in the 3rd. 
// Display the 3rd object details. Create a Test class to execute the above.

namespace Assessment_3
{
    class Box
    {
        public double Length { get; set; }
        public double Breadth { get; set; }
        public static Box Add(Box b1, Box b2)
        {
            return new Box
            {
                Length = b1.Length + b2.Length,
                 Breadth = b1.Breadth + b2.Breadth
            };
        }
    }

    class Box_Main_Method
    {
        static void Main(string[] args)
        {
            Box box1 = new Box();
            Box box2 = new Box();

            Console.WriteLine("Enter Box1 details:");
            Console.Write("Length: ");
            box1.Length = Convert.ToDouble(Console.ReadLine());
            Console.Write("Breadth: ");
            box1.Breadth = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Enter Box2 details:");
            Console.Write("Length: ");
            box2.Length = Convert.ToDouble(Console.ReadLine());
            Console.Write("Breadth: ");
            box2.Breadth = Convert.ToDouble(Console.ReadLine());

            Box box3 = Box.Add(box1, box2);

            Console.WriteLine($"Box 3 Details: Length = {box3.Length}, Breadth = {box3.Breadth}");
            Console.Read();
        }
    }
}


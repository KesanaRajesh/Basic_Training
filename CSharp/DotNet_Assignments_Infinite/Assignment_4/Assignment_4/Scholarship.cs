using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_4
{
    class Scholarship
    {
       
        public double Merit(double fee,double marks)
        {
            double scholorshipAmount = 0;
            if(marks>=70 && marks<=80)
            {
                return scholorshipAmount = 0.20 * fee;
                
            }
            else if(marks > 80 && marks <= 90)
            {
                return scholorshipAmount = 0.30 * fee;
                
            }
            else if(marks > 90)
            {
                return scholorshipAmount = 0.50 * fee;
             }
            else
            {
                Console.WriteLine("******No ScholarShip Is Avaliable******");
                
            }
            return scholorshipAmount;
           
        }
    }
    class Scholorship_MainClass
    {
        public static void Main(string[] args)
        {
            Scholarship scholarship = new Scholarship();
            Console.WriteLine("Enter The Marks: ");
            double marks = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Enter The Fee: ");
            double fee = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine(scholarship.Merit(fee, marks));
            Console.Read();

        }
       
    }
}

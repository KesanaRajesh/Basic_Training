using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day3_Program_Constructs
{
    class SelectionControl
    {
        public void CheckGrade()
        {
            char grade;
            Console.WriteLine("Enter Your Grade: ");
            grade = Convert.ToChar(Console.ReadLine());

            if(grade=='O' || grade=='o')
                Console.WriteLine("OutStanding");

            else if(grade=='A' || grade=='a')
                Console.WriteLine("Excellent");

            else if(grade=='B' || grade=='b')
                Console.WriteLine("Very Good");

            else if(grade=='C' || grade=='c')
                Console.WriteLine("Can Improve");

            else
                Console.WriteLine("Invalid Grade");

            

        }
        public void CheckGradeWithSwitch()
        {
            char grade;
            Console.WriteLine("Enter Your Grade: ");
            grade = Convert.ToChar(Console.ReadLine());

            switch(grade)
            {
                case 'O':
                case 'o':
                    Console.WriteLine("OutStanding");
                    break;

                case 'A':
                case 'a':
                    Console.WriteLine("Excellent");
                    break;

                case 'B':
                case 'b':
                    Console.WriteLine("very good");
                    break;

                case 'C':
                case 'c':
                    Console.WriteLine("Can Improve");
                    break;

                default:
                    Console.WriteLine("Invalid Grade");
                    break;
            }
        }
    }
    class DecisionMaking
    {
        static void Main(string[] args)
        {
            SelectionControl selectionControl = new SelectionControl();
            selectionControl.CheckGrade();
            //selectionControl.CheckGradeWithSwitch();
            Console.Read();
        }
    }
}

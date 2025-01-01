using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Railway_Reservation_System
{
    class Program
    {
        public static void Main()
        {
            while (true) { 
            Console.WriteLine("Choose One Option");
            Console.WriteLine("1.Admin");
            Console.WriteLine("2.User");
            Console.WriteLine("3.Exit");

            Console.WriteLine("Enter your choice(1/2/3):");
            int option = Convert.ToInt32(Console.ReadLine());

            switch (option)
            {
                case 1:
                    AdminInformation.Admin();
                    break;
                case 2:
                    UserInformation.User();
                    break;
                case 3:
                    Exit.ExitFromBooking();
                    break;
                default:
                    Console.WriteLine("Invalid option.Please try again");
                    break;
            }
                if(option == 3)
                {
                    //Console.WriteLine("Thank you");
                    break;
                }
            }
            Console.Read();
        }
    }
}
   
   

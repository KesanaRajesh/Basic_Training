using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;


namespace Railway_Reservation_System
{
    class UserInformation
    {
        public static SqlConnection connection = null;
        public static SqlCommand command = null;
        public static IDataReader dr = null;
        static int count = 0;
        public static void User()
        {
          
                Console.WriteLine("Select an option: ");
            Console.WriteLine("1.Display Train Information which is active:");
            Console.WriteLine("2.Book Tickets");
            Console.WriteLine("3.Cancel Tickets");
            count = count + 1;
            string UserChoice = Console.ReadLine();


            switch (UserChoice)
            {
                case "1":
                    ShowAllTrainInformation();
                    break;
                case "2":
                    BookingTrainTickets();
                    break;
                case "3":
                    CancelTrainTickets();
                    break;

                default:
                    Console.WriteLine("Invalid Option");
                    break;
            }
            
        }
        public static void ShowAllTrainInformation()
        {
            connection = new SqlConnection("Data Source = ICS-LT-D244D68N; database =RAILWAY_RESERVATION_SYSTEM; trusted_connection = true;");
            connection.Open();
            command = new SqlCommand("SP_DISPLAY_TRAIN_INFORMATION", connection);
            command.CommandType = CommandType.StoredProcedure;
            SqlDataReader reader = command.ExecuteReader();
            Console.WriteLine("Available Trains Are Shown Below....");
            while (reader.Read())
            {
                Console.WriteLine($"TrainNo:{reader["TRAIN_NO"]}, TrainName:{reader["TRAIN_NAME"]}, Source:{reader["SOURCE"]}, Destination:{reader["DESTINATION"]}, Seats_Available:{reader["SEATS_AVALIABLE"]}, TrainStatus:{reader["TRAIN_STATUS"]},");
                Console.WriteLine("-----------------------------");
            }
            while (count == 1)
            {

                User();
                break;
            }
        }
        public static void BookingTrainTickets()
        {
            Console.WriteLine("Enter Train Number: ");
            int TrainNo = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter Train Name");
            string TrainName = Console.ReadLine();
            Console.WriteLine("Enter Passenger Name");
            string PassengerName = Console.ReadLine();
            Console.WriteLine("Enter Passenger Age");
            int PassengerAge = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter Gender");
            string gender = Console.ReadLine();
            Console.WriteLine("Enter the Class Type");
            string ClassType = Console.ReadLine();
            Console.WriteLine("Enter The Price Of Ticket: ");
            int PriceOfTicket = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter the Number of Tickets");
            int NumberOfTickets = Convert.ToInt32(Console.ReadLine());
            String status = "booked";
            connection = new SqlConnection("Data Source = ICS-LT-D244D68N; database =RAILWAY_RESERVATION_SYSTEM; trusted_connection = true;");
            connection.Open();
            command = new SqlCommand("SP_USER_BOOKING_INFORMATION", connection);
            command.CommandType = CommandType.StoredProcedure;
            command.Parameters.AddWithValue("@TRAIN_NO", TrainNo);
            command.Parameters.AddWithValue("@TRAIN_NAME", TrainName);
            command.Parameters.AddWithValue("@PASSENGER_NAME", PassengerName);
            command.Parameters.AddWithValue("@PASSENGER_AGE", PassengerAge);
            command.Parameters.AddWithValue("@GENDER", gender);
            command.Parameters.AddWithValue("@CLASS_TYPE", ClassType);
            command.Parameters.AddWithValue("@PRICE_OF_TICKET", PriceOfTicket);
            command.Parameters.AddWithValue("@NUMBER_OF_TICKETS", NumberOfTickets);
            command.Parameters.AddWithValue("@STATUS", status);
            int result = command.ExecuteNonQuery();
            if(result > 0) { 
            Console.WriteLine("Train Ticket booked successfully....!!!!");
            }
            else
            {
                Console.WriteLine("not booked:");
            }
        }
        public static void CancelTrainTickets()
        {
            Console.WriteLine("Enter the Booking ID");
            int bookingid = Convert.ToInt32(Console.ReadLine());
            
            string status = "Cancelled";
            connection = new SqlConnection("Data Source = ICS-LT-D244D68N; database =RAILWAY_RESERVATION_SYSTEM; trusted_connection = true;");
            connection.Open();
            command = new SqlCommand("sp_Cancel_Ticket", connection);
            command.CommandType = CommandType.StoredProcedure;
            command.Parameters.AddWithValue("@Booking_ID", bookingid);
               
            int result = command.ExecuteNonQuery();
            if (result > 0)
            {
                Console.WriteLine("Train Ticket cancelled successfully....!!!!");
            }
            else
            {
                Console.WriteLine("Tickt not cancelled.....!!!!");
            }
        }

    }
}


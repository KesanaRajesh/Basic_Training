using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace Railway_Reservation_System
{
    class AdminInformation
    {
        public static SqlConnection connection = null;
        public static SqlCommand command = null;
        public static IDataReader dataReader = null;
        public static void Admin()
        {
            Console.WriteLine("Select one option :");
            Console.WriteLine("1.Add Trains");
            Console.WriteLine("2.Modify Trains");
            Console.WriteLine("3.Delete Trains");
            Console.WriteLine("Enter your choice(1/2/3):");
            int AdminChoice = Convert.ToInt32(Console.ReadLine());
            switch (AdminChoice)
            {
                case 1:
                    AddingTrainDetails();
                    break;
                case 2:
                    UpdateTrainDetails();
                    break;
                case 3:
                    DeleteTrainDetails();
                    break;
                default:
                    Console.WriteLine("Enter Invalid option");
                    break;
            }
        }
        public static void AddingTrainDetails()
        {
            Console.WriteLine("Enter Train Number: ");
            int TrainNo = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter Train Name: ");
            string TrainName = Console.ReadLine();
            Console.WriteLine("Enter the Source: ");
            string Source = Console.ReadLine();
            Console.WriteLine("Enter The Destination: ");
            string Destination = Console.ReadLine();
            Console.WriteLine("Enter The Number Of Seats Avaliable: ");
            int SeatsAvaliable = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter the Train Status");
            String TrainStatus = Console.ReadLine();           
            connection = new SqlConnection("Data Source = ICS-LT-D244D68N; database =RAILWAY_RESERVATION_SYSTEM; trusted_connection = true");
            connection.Open();
            command = new SqlCommand("SP_INSERT_TRAIN_DETAILS", connection);
            command.CommandType = CommandType.StoredProcedure;
            command.Parameters.AddWithValue("@TRAIN_NO", TrainNo);
            command.Parameters.AddWithValue("@TRAIN_NAME", TrainName);
            command.Parameters.AddWithValue("@SOURCE", Source);
            command.Parameters.AddWithValue("@DESTINATION", Destination);          
            command.Parameters.AddWithValue("@SEATS_AVALIABLE", SeatsAvaliable);
            command.Parameters.AddWithValue("@TRAIN_STATUS", TrainStatus);
            
            command.ExecuteNonQuery();
            Console.WriteLine("Train Details Added successfully....!!!!");
        }
        public static void UpdateTrainDetails()
        {
            Console.WriteLine("Enter Train Number:");
            int TrainNo = Convert.ToInt32(Console.ReadLine());           
            Console.WriteLine("Enter the Train Status to Update: ");
            string TrainStatus = Console.ReadLine();
            connection = new SqlConnection("Data Source = ICS-LT-D244D68N; database =RAILWAY_RESERVATION_SYSTEM; trusted_connection = true");
            connection.Open();
            command = new SqlCommand("SP_UPDATE_TRAIN_DETAILS", connection);
            command.CommandType = CommandType.StoredProcedure;
            command.Parameters.AddWithValue("@TRAIN_NO", TrainNo);            
            command.Parameters.AddWithValue("@TRAIN_STATUS", TrainStatus);
            command.ExecuteNonQuery();
            Console.WriteLine("Train Details Updated Successfully....!!!!");
        }
        public static void DeleteTrainDetails()
        {
            Console.WriteLine("Enter Train Number to Delete");
            int TrainNo = Convert.ToInt32(Console.ReadLine());
            connection = new SqlConnection("Data Source = ICS-LT-D244D68N; database =RAILWAY_RESERVATION_SYSTEM; trusted_connection = true");
            connection.Open();
            command = new SqlCommand("SP_DELETE_TRAIN_DETAILS", connection);
            command.CommandType = CommandType.StoredProcedure;
            command.Parameters.Add(new SqlParameter("@TRAIN_NO", SqlDbType.Int)).Value = TrainNo;
            int result = command.ExecuteNonQuery();
            if (result > 0)
            {
                Console.WriteLine("Train Details Deleted Successfully....!!!!");
            }
            else
            {
                Console.WriteLine("Train Details not Deleted....!!!!");
            }
        }
    }
}


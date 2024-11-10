using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// Create a class called Saledetails which has data members like Salesno,  Productno,  Price, dateofsale, Qty, TotalAmount
//Create a method called Sales() that takes qty, Price details of the object and updates the TotalAmount as  Qty* Price
// Pass the other information like SalesNo, Productno, Price, Qty and Dateof sale through constructor
//call the show data method to display the values without an object.




namespace Assignment_3
{


    class SaleDetails
    {
        public int salesNo;
        public int productNo;
        public int price;
        public DateTime dateOfSale;
        public int qty;
        public int totalAmount;


        public  SaleDetails(int salesNo, int productNo, int price, DateTime dateOfSale, int qty, int totalAmount)
            {
            this.salesNo = salesNo;
            this.productNo = productNo;
            this.price = price;
            this.dateOfSale = dateOfSale;
            this.qty = qty;
            this.totalAmount = totalAmount;
            }

        public static void sales(int qty , int price)
        {
            int totalAmount = qty * price;
        }
        
        public static void showData(SaleDetails saleDetails)
        {
            Console.WriteLine("SalesNo is {0}",saleDetails.salesNo);
            Console.WriteLine("ProductNo is {0}", saleDetails.productNo);
            Console.WriteLine("price is {0}", saleDetails.price);
            Console.WriteLine("DateOfSale is {0}", saleDetails.dateOfSale);
            Console.WriteLine("Quantity is {0} ",saleDetails.qty);
            Console.WriteLine("TotalAmount is {0}", saleDetails.totalAmount);
        }

        public static void Main()
        {
            Console.WriteLine("Enter salesno: ");
            int salesNo = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter productNo: ");
            int productNo = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter price: ");
            int price = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter DateOfSale: ");
            DateTime dateOfSale = Convert.ToDateTime(Console.ReadLine());
            Console.WriteLine("Enter Quantity: ");
            int quantity = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter TotalAmount: ");
            int totalAmount = Convert.ToInt32(Console.ReadLine());

            SaleDetails saleDetails = new SaleDetails(salesNo,productNo,price,dateOfSale,quantity,totalAmount);
            SaleDetails.showData(saleDetails);
            Console.Read();
        }
           
    }
}

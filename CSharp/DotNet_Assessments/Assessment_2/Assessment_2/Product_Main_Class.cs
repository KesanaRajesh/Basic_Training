using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


//2.Create a Class called Products with Productid, Product Name, Price. Accept 10 Products,
// sort them based on the price, and display the sorted Products

namespace Assessment_2
{
    public class Product
    {
        public int ProductId;
        public string ProductName;
        public double Price;

        public Product(int productId, string productName, double price)
        {
            ProductId = productId;
            ProductName = productName;
            Price = price;
        }
    }

    class Product_Main_Class
    {
        static void Main(string[] args)
        {
            Product[] products = new Product[10];

            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine($"Enter details for Product {i + 1}:");

                Console.Write("Product ID: ");
                int productId = Convert.ToInt32(Console.ReadLine());

                Console.Write("Product Name: ");
                string productName = Console.ReadLine();

                Console.Write("Price: ");
                double price = Convert.ToDouble(Console.ReadLine());

                products[i] = new Product(productId, productName, price);
            }

            for (int i = 0; i < products.Length - 1; i++)
            {
                for (int j = 0; j < products.Length - i - 1; j++)
                {
                    if (products[j].Price > products[j + 1].Price)
                    {
                        Product temp = products[j];
                        products[j] = products[j + 1];
                        products[j + 1] = temp;
                    }
                }
            }

            Console.WriteLine("Sorted Products based on Price:");
            for (int i = 0; i < products.Length; i++)
            {
                Console.WriteLine($"Product ID: {products[i].ProductId}, Name: {products[i].ProductName}, Price: {products[i].Price:C}");
            }

        }
    }
}




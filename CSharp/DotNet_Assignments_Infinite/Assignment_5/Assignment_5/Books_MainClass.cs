using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//1.Create a class called Books with BookName and AuthorName as members.
//Instantiate the class through constructor and also write a method Display() to display the details. 
//Create an Indexer of Books Object to store 5 books in a class called BookShelf.
//Using the indexer method assign values to the books and display the same.

//Hint(use Aggregation/composition)


namespace Assignment_5
{
    public class Books
    {
        public string bookName { get; set; }
        public string authorName { get; set; }

        public Books(string bookName,string authorName)
        {
            this.bookName = bookName;
            this.authorName = authorName;
        }

        public  void display()
        {
            Console.WriteLine($"Bookname is {bookName},written by {authorName} ");
        }
    }
    public class BookShelf
    {
        private Books[] book = new Books[5];
        public Books this[int i]
        {
            get { return book[i]; }
            set { book[i] = value; }
        }
    }
    class Books_MainClass
    {
        static void Main(string[] args)
        {
            BookShelf bookShelf = new BookShelf();
            for (int i = 0; i < 5; i++)
            {
                Console.WriteLine($"Enter The Deatils of Books");
                Console.Write($"Enter Book {i + 1} BookName: ");
                Console.WriteLine();
                string bookName = Console.ReadLine();
                Console.Write($"Enter Book {i + 1} AuthorName: ");
                Console.WriteLine();
                string authorName = Console.ReadLine();
                bookShelf[i] = new Books(bookName,authorName);
            }
            for (int i = 0; i < 5; i++)
            {
                Console.WriteLine($"Book {i + 1} Details are");
                bookShelf[i].display();
            }
            Console.ReadLine();
        }
       
    }
}


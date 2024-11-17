using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//Write a query that returns list of numbers and their squares only if square is greater than 20 


namespace Assignment_6
{
    class SquaresOfNumbers
    {
        static void Main()
        {

            Console.WriteLine("Enter numbers separated by spaces:");
            var input = Console.ReadLine();
            var numbers = input.Split(' ').Select(int.Parse).ToList();

            var result = numbers
                .Select(n => new { Number = n, Square = n * n })
                .Where(x => x.Square > 20)
                .ToList();

            if (result.Any())
            {
                Console.WriteLine("Numbers and their squares greater than 20:");
                result.ForEach(x => Console.WriteLine($"{x.Number} - {x.Square}"));
            }
            else
            {
                Console.WriteLine("No numbers have squares greater than 20.");
            }
            Console.ReadKey();
        }

    }
}


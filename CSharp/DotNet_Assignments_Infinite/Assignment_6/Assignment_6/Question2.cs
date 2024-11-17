using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_6
{
    class Question2
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter words separated by spaces:");
            var input = Console.ReadLine();
            var words = input.Split(' ').ToList();

            var result = words
                .Where(word => word.StartsWith("a", StringComparison.OrdinalIgnoreCase)
                            && word.EndsWith("m", StringComparison.OrdinalIgnoreCase))
                .ToList();

            if (result.Any())
            {
                Console.WriteLine("Words starting with 'a' and ending with 'm':");
                result.ForEach(Console.WriteLine);
            }
            else
            {
                Console.WriteLine("No words match the criteria.");
            }
            Console.ReadKey();
        }
    }
}

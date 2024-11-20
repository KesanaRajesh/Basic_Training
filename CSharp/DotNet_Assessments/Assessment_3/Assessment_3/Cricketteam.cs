using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


//Write a program to find the Sum and the Average points scored by the teams in the IPL. Create a Class called CricketTeam that has a function called Pointscalculation(int no_of_matches) that takes no.of matches as input and accepts that many scores from the user.
//The function should then return the Count of Matches, Average and Sum of the scores.

namespace Assessment_3
{
    class Cricketteam
    {
        public string Team_name { get; set; }
        public int Matches { get; set; }
        public int Sum { get; set; }
        public double Average { get; set; }
        public (int, int, double) PointsCalculation(int no_of_matches)
        {
            Sum = 0;
            for (int i = 0; i < no_of_matches; i++)
            {
                Console.Write($"Enter score of match {i + 1}: ");
                Sum += Convert.ToInt32(Console.ReadLine());
            }
            Matches = no_of_matches;
            Average = (double)Sum / no_of_matches;
            return (Matches, Sum, Average);
        }
    }

    class Cricket_MainClass
    {
        static void Main()
        {
            Cricketteam team = new Cricketteam();
            Console.Write("Enter the  Team Name : ");
            string T_name = Console.ReadLine();
            team.Team_name = T_name;
            Console.Write("Ente the number of matches: ");
            int noOfMatches = Convert.ToInt32(Console.ReadLine());
            var (matches, sum, average) = team.PointsCalculation(noOfMatches);

            Console.WriteLine("---------------------------------");

            Console.WriteLine($"Team: {team.Team_name}");
            Console.WriteLine($"Matches : {matches}");
            Console.WriteLine($"Sum: {sum}");
            Console.WriteLine($"Average: {average}");
            Console.ReadKey();
        }
    }
}

    

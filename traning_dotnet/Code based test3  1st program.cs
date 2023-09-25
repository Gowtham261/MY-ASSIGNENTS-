using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeBasedTest3
{
    class Cricket
    {
        //function
        public void PointsCalculation(int no_of_matches)
        {
            Console.Write("Scores for IPL matches");
            int[] scores = new int[no_of_matches];
            for (int i = 0; i < no_of_matches; i++)
            {
                Console.Write("score for Match");
                if (int.TryParse(Console.ReadLine(), out int score))
                {
                    scores[i] = score;
                }
                else
                {
                    Console.WriteLine("enter a valid score");
                }
            }
           Console.WriteLine("enter sum");
            int sum = 0;
            foreach (int score in scores)
            {
                sum += score;
            }
            double average = (double)sum / no_of_matches;
            Console.WriteLine("total Points Scored");
            Console.WriteLine("Average Points Scored");
        }
    }
       class Program
       { 
            static void Main()
            {
                Console.Write("Number of IPL matches: ");
                if (int.TryParse(Console.ReadLine(), out int no_of_matches))
                {
                    Cricket cricket = new Cricket();
                    cricket.PointsCalculation(no_of_matches);
                }
                else
                {
                    Console.WriteLine("Enter a valid number of matches");
                }
            }
        }
    
}

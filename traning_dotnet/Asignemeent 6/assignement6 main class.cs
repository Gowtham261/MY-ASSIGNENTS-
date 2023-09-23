using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace assignemeent_6
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.Write("Enter your name");

            string name = Console.ReadLine();

            Console.Write("Enter your age");

            int age = Convert.ToInt32(Console.Read());

            if (int.TryParse(Console.ReadLine(), out age))

            {

                string concessionDetails = Concession.ConcessionCalculator.CalculateConcession(age, name);

                Console.WriteLine(concessionDetails);

            }
            else
            {

                Console.WriteLine("Incorrcet input.");

            }
             Console.ReadLine();

        }

    }



}

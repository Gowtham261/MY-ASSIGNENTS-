using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using assignement_6


namespace assignement_6
{
    public class Concession

    {

        int TotalFare = 700;

        public static CalculateConcession(int age, string name)

        {

            if (age <= 5)

            {

                Console.WriteLine("Little Champs- Free Ticket");

            }
            else if (age > 60)

            {

                Amount = TotalFare * 0.3;

                CutFare = TotalFare - Amount;

                Console.WriteLine("Aged people");
            }
        }
    }

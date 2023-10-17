using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignement_5
{
    class Program
    {
        static string firstname; static string lastname;
        static void Main(string[] args)
        {
            Console.WriteLine("Enter First name");
            firstname = Console.ReadLine();
            Console.WriteLine("Enter lastname name");
            lastname = Console.ReadLine();
            Console.Read();
        }

        public static void Display()
        {
            Console.WriteLine(firstname.ToUpper());
            Console.WriteLine(lastname.ToUpper());
            Console.Read();
        }
    }
}
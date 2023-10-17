using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignement_5_part_3_
{
    class C
    {
        static int Cid;
        static string Cname;
        static int CAge;
        static int Cphonenumber;
        static string CCity;

        static void Main(string[] args)
        {
            Console.WriteLine("enter C id");
            Cid = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("C name");
            Cname = Console.ReadLine();
            Console.WriteLine("enter C Age");
            CAge = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("enter C phonenumber");
            Cphonenumber = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("enter C city");
            CCity = Console.ReadLine();
            C cc = new C(Cid, Cname, CAge, Cphonenumber, CCity);
            displayCr();
            Console.Read();
        }
        public C()
        {
            //empy constroctur 
        }
        public C(int cid, string cName, int cage, int cphonenumber, string cCity)
        {
            Cid = cid;
            Cname = cName;
            CAge = cage;
            Cphonenumber = cphonenumber;
            CCity = cCity;
        }
        static void displayCr()
        {
            Console.WriteLine($"My customeid: {Cid}, My Cname: {Cname}, My Cage: {CAge}, My Cphonenumber: {Cphonenumber}, My CCity:{CCity}");
        }

        ~C()
        {
            Console.WriteLine("Cache cleared");
        }

    }    
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignement_5_2nd_program_
{
    class Customer
    {
        static void Main(string[] args)
        {
            int customerid;
            customerid = Convert.ToInt32(Console.Read());
            string name;
            Console.WriteLine("enter name");
            string city;
            Console.WriteLine("enter city");
            int phonumber;
            phonumber = Convert.ToInt32(Console.Read());
            int age;
            age = Convert.ToInt32(Console.Read());

        }
        class Customerinfo
        {
            public string Name;
            public string City;
            public int Phonumber;
            public int Age;
            public int Custid;

            public Customerinfo(string name, string city, int age, int custid, int phonumber)
            {
                Age = age;
                City = city;
                Custid = custid;
                Name = name;
                Phonumber = phonumber;
            }
            static void DisplayCustomerinfo()
            {
                Console.WriteLine("age,city,custid,name,phonumber");
            }
            Customerinfo()
            {
                Console.WriteLine("Destructor Is Activated");
            }

        }
    }
}

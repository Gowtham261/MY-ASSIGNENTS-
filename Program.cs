using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace postive
{
    class Program
    {
        static void Main(string[] args)
        {
            int num = Convert.ToInt32(Console.ReadLine());
            if (num > 0)
            {
                Console.WriteLine("positive");
                return;
            }
            else if (num < 0)
            {
                Console.WriteLine("negative");
                return;
            }
            else
            {
                Console.WriteLine("Zero");
                return;
            }
        }
    }
}

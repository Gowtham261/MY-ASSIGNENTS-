using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace CodeBaseTest4
{
    class Program
    {
        static void Main()
        {
            string filelocation = "sample.txt";

            using (StreamWriter writer = new StreamWriter(filelocation, true))
            {
                Console.WriteLine("Enter text to append to the file (Ctrl+Z to finish):");
                while (true)
                {
                    string input = Console.ReadLine();
                    if (input == null)
                        break;
                    writer.WriteLine(input);
                }
                Console.WriteLine("Text appended to the file successfully.");

            }

        }
    }  
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace code_2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("how many per week");
            int[] Cigi = new int[10];
            for (int i = 0; i < Cigi.Length; i++) 
            {
                Cigi[i] = Convert.ToInt32(Console.ReadLine());
            }
           
            int sum = Cigi.Sum();
            Console.WriteLine("sum " + sum);
           
            double avg = Cigi.Average();
            Console.WriteLine("average " + avg);
            Console.WriteLine("maxmium");
            int max = Cigi.Max();
            Console.WriteLine("minium");
            int mini = Cigi.Min();
            Console.WriteLine("assending");
            Array.Sort(Cigi);
            for (int i = 0; i < Cigi.Length; i++) 
            {
                Console.WriteLine(Cigi[i]);
            }
            Console.WriteLine("dessending");
            Array.Reverse(Cigi);
            for(int i = 0; i<Cigi.Length; i++)
            {
                Console.WriteLine(Cigi[i]);
            }
            Console.Read();


        }
    }
}

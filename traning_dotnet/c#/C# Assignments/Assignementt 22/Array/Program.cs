using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Array
{
    class Program
    {
        static int i;
        static void Main(string[] args)
        {
            Console.WriteLine("Assign integer valuse to array");
            int[] arr = { 2, 3, 5, 2, 3 };
            for(int i =0; i<=arr.Length; i++)
            {
                Console.WriteLine(arr);
            }
            if (arr.Length > 0) 

            {
                Console.WriteLine("Arr is mamium");
            }
            else 
            {
                Console.WriteLine("Arr is maxium");
            }
            int sum = 0; Convert.ToInt32(Console.ReadLine());
            float average= 0; Convert.ToInt32(Console.ReadLine());
            for (int i = 0; i <= arr.Length; i++);
                {
                   sum =+ arr[i];
                   Console.WriteLine("arr"); 
                }
                  average = sum/arr.Length;
            }
        }
    }


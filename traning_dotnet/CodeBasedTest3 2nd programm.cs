
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Codebasedtest3_program2
{
    class Box
    {
        public double Length { get; set; }

        public double Breadth { get; set; }



        public Box(double length, double breadth)
        {

            Length = length;

            Breadth = breadth;

        }


        //function to add boxes
        public static Box AddBoxes(Box box1, Box box2)
        {

            double newLength = box1.Length + box2.Length;

            double newBreadth = box1.Breadth + box2.Breadth;

            return new Box(newLength, newBreadth);

        }



        public void DisplayBoxDetails()
        {

            Console.WriteLine("Length meters");

            Console.WriteLine("Breadth meters");

        }

    
    }


    class Test
    {

        static void Main()
        {

            Box box1 = new Box(9, 8);

            Box box2 = new Box(13, 81);

            Box box3 = Box.AddBoxes(box1, box2);

            Console.WriteLine("Box 1 Details");

            box1.DisplayBoxDetails();



            Console.WriteLine("Box 2 Details");

            box2.DisplayBoxDetails();



            Console.WriteLine("Sum of Box 1 and Box 2 Details:");

            box3.DisplayBoxDetails();
            Console.ReadLine();

        }
    }

}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeBasedTest2ndSol
{
    delegate int MathOperation(int p, int q);
    class Program
    {
        public class Calculator
        {
            public int add(int p, int q)
            {
                return p + q;
            }
            public int subtract(int p, int q)
            {
                return p - q;
            }
            public int multiply(int p, int q)
            {
                return p * q;
            }
            public int divide(int p, int q)
            {
                return p / q;
            }
            class Program
            {
                public static void Main()
                {
                    int result = 0;
                    Calculator calculator = new Calculator();
                    MathOperation add = calculator.add;
                    MathOperation Subtract = calculator.subtract;
                    MathOperation Multiply = calculator.multiply;
                    Console.Write("Enter A Number: ");
                    int FirstNumber1 = Convert.ToInt32(Console.ReadLine());
                    Console.Write("Enter Another Number: ");
                    int SecondNumber2 = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine("1.Add\n2. Subtract\n3. Multiply\n4.Exit");
                    int choice = int.Parse(Console.ReadLine());
                    switch (choice)
                    {
                        case 1:
                            add(FirstNumber1, SecondNumber2); Console.WriteLine(result);
                            break;
                        case 2:
                            Subtract(FirstNumber1, SecondNumber2); Console.WriteLine(result);
                            break;
                        case 3:
                            Multiply(FirstNumber1, SecondNumber2); Console.WriteLine(result);
                            break;
                        case 5:
                            Calculator calc = new Calculator();
                            Console.WriteLine($"Addition: {calc.add(FirstNumber1, SecondNumber2)} \n");
                            Console.WriteLine($"Subtraction: {calc.subtract(FirstNumber1, SecondNumber2)} \n");
                            Console.WriteLine($"Multiplication: {calc.multiply(FirstNumber1, SecondNumber2)} \n");
                            break;
                    }                  
                }
                public static void options()
                {
                    Console.WriteLine("1. Again    2. Exit");
                    int choice = int.Parse(Console.ReadLine());
                    switch (choice)
                    {
                        case 1:
                            Main();
                            break;
                        case 2:
                            Environment.Exit(0);
                            break;
                        default:
                            Console.WriteLine("Not Correct Choice");
                            break;
                    }
                }

            }       
        }
    }
}
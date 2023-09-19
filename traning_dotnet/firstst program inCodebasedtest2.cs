using System;
using System.Collections.Generic;



namespace CodeBasedTest2
{
    public abstract class MyStudent
    {
        static string sn; 
        public static double sg; 
        static int ids;
        public Student(string sn, double sg, int ids)
        {
            sg = sg;
            ids = ids;
            sn = sn;
        }
        public abstract bool isPassed(double sg);
    }



    public class HEIsUndergraduate
    {
        public HEIsUndergraduate(string sn, double sg, int ids) : base(sn, sg, ids)
        { 
        }
        public override bool isPassed(double sg)
        {
            return sg >= 70;
        }
    }
    public class HEIsGraduate
    {
        public HEIsGraduate(string sn, double sg, int ids) : base(sn, sg, ids)
        {
        }
        public override bool isPassed(double sg)
        {
            return sg >= 80;
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter Student Name: ");
            string sname = Console.ReadLine();
            Console.Write("Enter Student Grade: ");
            double sgrade = Convert.ToDouble(Console.ReadLine());
            Console.Write("Enter Student ID: ");
            int sID = Convert.ToInt32(Console.ReadLine());
            Student Undergraduate = new Undergraduate(sname, sgrade, sID);
            Console.WriteLine($"Student Name: {sname}, Student Grade: {sgrade}, Student ID: {sid}");
            Console.WriteLine($"Status: {Undergraduate.isPassed(Undergraduate.sg)}");
            Console.Read();
        }
    }
}
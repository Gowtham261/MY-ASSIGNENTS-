using System;
using System.Collections.Generic;



namespace CodeBasedTest2
{
    public abstract class MyStudent
    {
        static string studentName; 
        public static double studentGrade; 
        static int studentID;
        public Student(string studentname, double studentgrade, int studentid)
        {
            studentGrade = studentgrade;
            studentID = studentid;
            studentName = studentname;
        }
        public abstract bool isPassed(double studentgrade);
    }



    public class HEIsUndergraduate
    {
        public HEIsUndergraduate(string studentname, double studentgrade, int studentid)
        {

            base(studentname, studentgrade, studentid)

        }
        public override bool isPassed(double studentgrade)
        {



            return studentgrade >= 70;
        }



    }
    public class HEIsGraduate
    {
        public HEIsGraduate(string studentname, double studentgrade, int studentid) : base(studentname, studentgrade, studentid)
        {



        }
        public override bool isPassed(double studentgrade)
        {



            return studentgrade >= 80;
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
            Student Undergraduate = new Undergraduate(SNAME, SGRADE, SID);
            Console.WriteLine($"Student Name: {SNAME}, Student Grade: {SGRADE}, Student ID: {SID}");
            Console.WriteLine($"Status: {Undergraduate.isPassed(Undergraduate.studentGrade)}");
            Console.Read();
        }
    }
}
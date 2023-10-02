using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CaseStudy1
{
    class Program
    {
        static int studentid;
        static string studentname;
        static DateTime studentdateofbirth;
        public class Student
        {
            internal static object studentName;
            internal static object studentID;
            internal static object studentDateOfBirth;

            public int StudentId { get; set; }
            public string StudentName { get; set; }
            public DateTime StudentDateOfBirth { get; set; }
        }
        //Constructor
        public Student(int StudentId, string StudentName, DateTime StudentDateOfBirth)
        {
            StudentId = studentid;
            StudentName = studentname;
            StudentDateOfBirth = studentdateofbirth;
        }
        public class Info
        {
            public void display(Student student)
            {
                Console.Write($"Student Name{Student.studentName},\n" +
                $"Student ID: {Student.studentID} \n" +
                $"Date Of Birth: {Student.studentDateOfBirth}\n");
            }
        }
    }
    public class App
    {
        public static int numberOfStudentObjects;
        static string studentname;
        static int studentid;
        static int studentbirthYear;
        static int studentbirthMonth;
        static int studentbirthDay;
        static DateTime studentdateofbirth;
        static void Main(string[] args)
        { }
        public static void scenario1()
        {
            Console.WriteLine($"Enter Student Details");
            Console.Write("Student Name:");
            studentname = Console.ReadLine();
            Console.Write("Student ID:");
            studentid = Convert.ToInt32(Console.ReadLine());
            Console.Write("Student BirthYear:");
            studentbirthYear = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Student BirthMonth:");
            studentbirthMonth = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Student BirthDay:");
            studentbirthDay = Convert.ToInt32(Console.ReadLine());
            studentdateofbirth = new DateTime(studentbirthYear, studentbirthMonth, studentbirthDay);
            Student stud = new Student(studentname, studentid, studentdateofbirth);
            Info info = new Info();
            info.display(stud);
        }
        public static void Senario2()
        {
            Console.WriteLine($"Enter Student Details");
            Console.Write("student Name: ");
            studentname = Console.ReadLine();
            Console.Write("studentb ID: ");
            studentid = Convert.ToInt32(Console.ReadLine());
            Console.Write("student Birth Year: ");
            studentbirthYear = Convert.ToInt32(Console.ReadLine());
            Console.Write("student Birth Month ");
            studentbirthMonth = Convert.ToInt32(Console.ReadLine());
            Console.Write("student Birth Day");
            studentbirthDay = Convert.ToInt32(Console.ReadLine());
            DateTime dateOfBirthStudent = new DateTime(studentbirthYear, studentbirthMonth, studentbirthDay);
            Console.Read();
        }
        
    }
}

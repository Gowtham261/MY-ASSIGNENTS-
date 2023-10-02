using CaseStudy3and4;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static CaseStudy3and4.Program;

namespace CaseStudy3and4
{
    public void ShowAllStudentsScreen()
    {
        Console.WriteLine("All students");
        Student[] students = AppEngine.ListOfStudents();
        foreach (Student student in students)
        {
            Console.WriteLine("Name: , ID: ");
        }
    }
    public void ShowStudentRegistrationScreen()
    {
        Console.WriteLine("Student registrartion");
        Console.WriteLine("Student name");
        string name = Console.ReadLine();
        Console.WriteLine("Enter Student ID");
        int id = Convert.ToInt32(Console.ReadLine());
        Student student = new Student(id, name, DateTime.Now);
        AppEngine.Register(student);
    }
    public void IntroduceNewCourseScreen()
    {
        Console.WriteLine("Introduce Course");
        Console.WriteLine("Enter Course Name");
        string Course = Console.ReadLine();
        AppEngine.Indroduce(Course);
    }
    public void ShowAdminScreen()
    {
        Console.WriteLine("1.Introduce to New Course");
        Console.WriteLine("2.View every Course");
        Console.WriteLine("select your choice");
        int choice = Convert.ToInt32(Console.ReadLine());
        switch (choice)
        {
            case 1:
                IntroduceNewCourseScreen();
                break;
            case 2:
                ShowAllStudentsScreen();
                break;
        }
    }
    public abstract class UserInterface
    {
        public abstract void ShowFirstscreen();
        public abstract void ShowStudentscreen();
        public abstract void ShowAdminscreen();
        public abstract void ShowStudentRegistrartionScreen();
        public abstract void ShowIntroduceNrwCoursescreen();
        public abstract void ShowAllStudentScreenscreen();
        public abstract void ShowAllCoursescreen();
        internal static void ShowFirstScreen()
        {
            throw new NotImplementedException();
        }

        public static implicit operator UserInterface(ConsoleUserInterface v)
        {
            throw new NotImplementedException();
        }
    }
    public class ConsoleUserInterface : Userinterface
    {
        private AppEngine appEngine;
        public ConsoleUserInterface()
        {
        }

        public ConsoleUserInterface(AppEngine ae)
        {
            appEngine = new AppEngine();
        }
    }
    public void ShowFirstScreen()
    {
        Console.WriteLine("Welcome to SMS(Student Mgmt. System) v1.0");
        Console.WriteLine("Tell us who you are : \n1. Student\n2. Admin");
        Console.WriteLine("Enter your choice ( 1 or 2 ) : ");
        int op = Convert.ToInt32(Console.ReadLine());
        switch (op)
        {
            case 1:
                ShowStudentscreen();
                break;
            case 2:
                ShowAdminscreen();
                break;
        }
    }
}
public class App
{
    public static void Main(string[] args)
    {
        AppEngine APP = new AppEngine();
        UserInterface ui = new ConsoleUserInterface(APP);
        Console.Read();
    }
}

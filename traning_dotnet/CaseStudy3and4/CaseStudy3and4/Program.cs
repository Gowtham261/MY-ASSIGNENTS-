using CaseStudy3and4;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CaseStudy3and4
{
    public class Student
    {
        public string name { get; set; }
        public Student(string name)
        {
            this.name = name;
        }

    }
    public class Course
    {
        public string name { get; set; }
        public Course(string name)
        {
            this.name = name;
        }

    }
    public class Enroll
    {
        private Student student { get; set; }
        private Course course { get; set; }
        private DateTime enrollmentDate { get; set; }
        public Enroll(Student student, Course course, DateTime enrollmentDate)
        {
            this.student = student;
            this.course = course;
            this.enrollmentDate = enrollmentDate;
        }
    }
    public class AppEngine
    {
        private List<Student> students = new List<Student>();
        private List<Course> courses = new List<Course>();
        private List<Enroll> enrollments = new List<Enroll>();
        public void Introduce(Course course)
        {
            courses.Add(course);
        }
        public void Register(Student student)
        {
            students.Add(student);
        }
        public List<Student> ListOfStudents()
        {
            return students;
        }
        public List<Course> ListOfCourses()
        {
            return courses;
        }
        public void Enroll(Student student, Course course)
        {
            DateTime enrollmentDate = DateTime.Now;
            Enroll enrollment = new Enroll(student, course, enrollmentDate);
            enrollments.Add(enrollment);
        }
        public List<Enroll> ListOfEnrollments()
        {
            return enrollments;
        }
    }
    public interface UserInterface
    {
        void ShowFirstScreen();
        void ShowStudentScreen();
        void ShowAdminScreen();
        void ShowAllStudentScreen();
        void ShowStudentRegistrationScreen();
        void IntroduceNewCourseScreen();
        void ShowAllCoursesScreen();
    }
    public class ConsoleUserInterface : UserInterface
    {
        public AppEngine APPE;
        public ConsoleUserInterface(AppEngine APPE)
        {
            this.APPE = APPE;
        }
        public void ShowFirstScreen()
        {
            Console.WriteLine("Welcome to Student Managment System");
            Console.WriteLine("Tell us who are you");
            Console.WriteLine("Select you choice(1or2):");
            int choice = Convert.ToInt32(Console.ReadLine());
            switch (choice)
            {
                case 1:
                    ShowStudentScreen();
                    break;
                case 2:
                    ShowAdminScreen();
                    break;
            }
            choices();
        }
        public void ShowStudentScreen()
        {
            Console.WriteLine("Welcome to student menu");
            Console.WriteLine("Please Enter Your Choice 1.View all courses 2. Enroll your course");
            int choice = Convert.ToByte(Console.ReadLine());
            switch (choice)
            {
                case 1:
                    ShowAllCoursesScreen();
                    break;
                case 2:
                    ShowStudentRegistrationScreen();
                    break;
            }
            choices();
        }
        public void ShowAdminScreen()
        {
            Console.WriteLine("WELCOME TO ADMIN MENU");
            Console.WriteLine("1. Introduce New Course 2. View All Students 3. View All Courses 4.Please Enter Your Choice");
            int choice = Convert.ToInt32(Console.ReadLine());
            switch (choice)
            {
                case 1:
                    IntroduceNewCourseScreen();
                    break;
                case 2:
                    ShowAllStudentScreen();
                    break;
                case 3:
                    ShowAllCoursesScreen();
                    break;
                case 4:
                    Environment.Exit(0);
                    break;
            }
            choices();
        }
        public void ShowAllStudentScreen()
        {
            Console.WriteLine("List Of Students");
            foreach (var student in APPE.ListOfStudents())
            {
                Console.WriteLine(student.name);
            }
            choices();
        }
        public void ShowStudentRegistrationScreen()
        {
            Console.WriteLine("Enter Student Name: ");
            string STUDENTname = Console.ReadLine();
            Student newStudent = new Student(STUDENTname);
            APPE.Register(newStudent);
            Console.WriteLine($"{STUDENTname} Registered");
            choices();
        }
        public void IntroduceNewCourseScreen()
        {
            Console.WriteLine("Enter Course Name");
            string COURSEname = Console.ReadLine();
            Course newCourse = new Course(COURSEname);
            APPE.Introduce(newCourse);
            Console.WriteLine($"{COURSEname} Introduced");
            choices();
        }
        public void ShowAllCoursesScreen()
        {
            Console.WriteLine("List Of Courses");
            foreach (var course in APPE.ListOfCourses())
            {
                Console.WriteLine(course.name);
            }
            choices();
        }
        public void choices()
        {
            Console.WriteLine("1. go to student    2. go to admin");
            int choice = int.Parse(Console.ReadLine());
            switch (choice)
            {
                case 1: ShowStudentScreen();
                    break;
                case 2: ShowAdminScreen();
                    break;
                default: Console.WriteLine("invalid");
                    break;
            }
        }

    }
    public class Program
    {
        public static void Main()
        {
            AppEngine APPE = new AppEngine();
            UserInterface UI = new ConsoleUserInterface(APPE);
            UI.ShowFirstScreen();
            Console.Read();
        }
    }
}

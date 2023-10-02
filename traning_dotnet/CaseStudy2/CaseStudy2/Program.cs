using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CaseStudy2
{
    public class Student
    {
        public string student { get; set; }
        public string Student1 { get; set; }
    }
    public class Course
    {
        public string Course1 { get; set; }
        public string course { get; set; }
    }
    public class Enroll
    {
        private Student student;
        private Course course;
        private DateTime enrollmentDate;

        public Enroll(Student student, Course course)
        {
            this.student = student;
            this.course = course;
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
        public Student[] ListOfStudents()
        {
            return students.ToArray();
        }
        public Course[] ListOfCourses()
        {
            return courses.ToArray();
        }
        public void Enroll(Student student, Course course, DateTime enrollmentDate)
        {
            enrollments.Add(new Enroll(student, course));
        }
        public Enroll[] ListOfEnrollments()
        {
            return enrollments.ToArray();
        }
    }
    public class App
    {
        public static void Main()
        {
            AppEngine appEngine = new AppEngine();
            Course course1 = new Course {course = "Social"};
            appEngine.Introduce(course1);
            Student student1 = new Student { student = "Shiva"};
            appEngine.Register(student1);
            DateTime enrollmentDate = new DateTime(2002,11,03);
            appEngine.Enroll(student1, course1, enrollmentDate);
            
            Console.WriteLine("List of Students");
            foreach (var student in appEngine.ListOfStudents())
            {
                Console.WriteLine($"Student Name: {student.Student1}");
            }
            Console.WriteLine("List of Courses");
            foreach (var course in appEngine.ListOfCourses())
            {
                Console.WriteLine($"Course Name:{course.Course1}");
            }
            Console.WriteLine("List of Enrollments");
            foreach (var enrollment in appEngine.ListOfEnrollments())
            {
                Console.WriteLine($"Student: {student1}, Course: {course1}, Enrollment Date: {enrollmentDate}");
            }
            Console.Read();
        }
    }
}   

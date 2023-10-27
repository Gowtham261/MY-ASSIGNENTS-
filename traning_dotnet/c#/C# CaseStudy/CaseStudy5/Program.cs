using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;

namespace CASESTUDY5
{
    public class Student
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public DateTime DateOfBirth { get; set; }
        public Student(int id, string name, DateTime dateOfBirth)
        {
            ID = id;
            Name = name;
            DateOfBirth = dateOfBirth;
        }
    }
    public class Course
    {
        public int ID { get; set; }
        public string Name { get; set; }

        public Course(int id, string name)
        {
            ID = id;
            Name = name;
        }
    }
    public class Enroll
    {
        public Student Student { get; set; }
        public Course Course { get; set; }
        public DateTime EnrollmentDate { get; set; }

        public Enroll(Student student, Course course, DateTime enrollmentDate)
        {
            Student = student;
            Course = course;
            EnrollmentDate = enrollmentDate;
        }
    }
    public class AppEngine
    {
        private string connectionString = "The connection string here";
        public void Introduce(Course course)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                using (SqlCommand cmd = new SqlCommand("INSERT INTO Courses (Name) VALUES (@Name)", connection))
                {
                    cmd.Parameters.AddWithValue("@Name", course.Name);
                    cmd.ExecuteNonQuery();
                }
            }
        }
        public void Register(Student student)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                using (SqlCommand cmd = new SqlCommand("INSERT INTO Students (Name, DateOfBirth) VALUES (@Name, @DateOfBirth)", connection))
                {
                    cmd.Parameters.AddWithValue("@Name", student.Name);
                    cmd.Parameters.AddWithValue("@DateOfBirth", student.DateOfBirth);
                    cmd.ExecuteNonQuery();
                }
            }
        }
        public List<Student> ListOfStudents()
        {
            List<Student> students = new List<Student>();
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                using (SqlCommand cmd = new SqlCommand("SELECT * FROM Students", connection))
                using (SqlDataReader reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        students.Add(new Student
                        {
                            ID = reader.GetInt32(0),
                            Name = reader.GetString(1),
                            DateOfBirth = reader.GetDateTime(2)
                        });
                    }
                }
            }
            return students;
        }
        public List<Course> ListOfCourses()
        {
            List<Course> courses = new List<Course>();
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                using (SqlCommand cmd = new SqlCommand("SELECT * FROM Courses", connection))
                using (SqlDataReader reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        courses.Add(new Course
                        {
                            ID = reader.GetInt32(0),
                            Name = reader.GetString(1)
                        });
                    }
                }
            }
            return courses;
        }
        public void Enroll(Student student, Course course)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                using (SqlCommand cmd = new SqlCommand("INSERT INTO Enrollments (StudentID, CourseID, EnrollmentDate) VALUES (@StudentID, @CourseID, @EnrollmentDate)", connection))
                {
                    cmd.Parameters.AddWithValue("@StudentID", student.ID);
                    cmd.Parameters.AddWithValue("@CourseID", course.ID);
                    cmd.Parameters.AddWithValue("@EnrollmentDate", DateTime.Now);
                    cmd.ExecuteNonQuery();
                }
            }
        }
        public List<Enroll> ListOfEnrollments()
        {
            List<Enroll> enrollments = new List<Enroll>();
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                using (SqlCommand cmd = new SqlCommand("SELECT * FROM Enrollments", connection))
                using (SqlDataReader reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        int studentID = reader.GetInt32(1);
                        int courseID = reader.GetInt32(2);
                        DateTime enrollmentDate = reader.GetDateTime(3);
                        Student student = ListOfStudents().Find(s => s.ID == studentID);
                        Course course = ListOfCourses().Find(c => c.ID == courseID);
                        enrollments.Add(new Enroll(student, course, enrollmentDate));
                    }
                }
            }
            return enrollments;
        }
    }
    public interface UserInterface
    {
        void ShowFirstScreen();
        void ShowStudentScreen();
        void ShowAdminScreen();
    }
    public class ConsoleUserInterface : UserInterface
    {
        private AppEngine engine;

        public ConsoleUserInterface(AppEngine engine)
        {
            this.engine = engine;
        }
        public void ShowAdminScreen()
        {
            throw new NotImplementedException();
        }
        public void ShowFirstScreen()
        {
            Console.WriteLine("Welcome to Student Management System");
            Console.WriteLine("Tell us who you are");
            Console.WriteLine("Select your choice (1 or 2):");
            int choice = Convert.ToInt32(Console.ReadLine());

            switch (choice)
            {
                case 1:
                    ShowStudentScreen();
                    break;
                case 2:
                    ShowAdminScreen();
                    break;
                default:
                    Console.WriteLine("Invalid choice");
                    break;
            }
        }
        public void ShowStudentScreen()
        {
            Console.WriteLine("Student Menu:");
            Console.WriteLine("1. View All Courses");
            Console.WriteLine("2. Enroll in a Course");
            int choice = Convert.ToInt32(Console.ReadLine());

            switch (choice)
            {
                case 1:
                    List<Course> courses = engine.ListOfCourses();
                    Console.WriteLine("List of Courses:");
                    foreach (var course in courses)
                    {
                        Console.WriteLine($"{course.ID}. {course.Name}");
                    }
                    break;
                case 2:
                    List<Student> students = engine.ListOfStudents();
                    Console.WriteLine("List of Students:");
                    foreach (var student in students)
                    {
                        Console.WriteLine($"{student.ID}. {student.Name}");
                    }
                    Console.Write("Enter the student ID you want to enroll: ");
                    int studentID = Convert.ToInt32(Console.ReadLine());
                    Console.Write("Enter the course ID you want to enroll in: ");
                    int courseID = Convert.ToInt32(Console.ReadLine());
                    engine.Enroll(students.Find(s => s.ID == studentID), engine.ListOfCourses().Find(c => c.ID == courseID));
                    Console.WriteLine("Enrollment successful.");
                    break;
                    Console.WriteLine("Invalid choice");
                    break;
            }
        }
        public void Main()
        {
            ShowFirstScreen();
            Console.Read();
        }
    }
}
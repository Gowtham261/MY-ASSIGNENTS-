using System;
using System.Collections.Generic;
using System.Linq;

class Employee
{
    public object FirstName { get; private set; }
    public object LastName { get; private set; }
    int employeeid { get; set; }
    string Firstname { get; set; }
    string Lastname { get; set; }
    string Title { get; set; }
    DateTime DOb { get; set; }
    DateTime DateOfJoin { get; set; }
    string City { get; set; }
    static void Main()
    {
        List<Employee> empList = new List<Employee>();
        empList.Add(new Employee
        {
            employeeid = 1001,
            Firstname = "Malcolm",
            Lastname = "Daruwalla",
            Title = "Manager",
            DOb = new DateTime(16 / 11 / 1984),
            DateOfJoin = new DateTime(8 /3 / 2011),
            City = "Mumbai"
        });
        empList.Add(new Employee
        {
            employeeid = 1002,
            Firstname = "Asdin",
            Lastname = "Dalla",
            Title = "AsstManager",
            DOb = new DateTime(20/2/1984),
            DateOfJoin = new DateTime(8 /4 / 2012),
            City = "Mumbai"
        });
        empList.Add(new Employee
        {
            employeeid = 1003,
            Firstname = "Saba",
            Lastname = "Dalla",
            Title = "AsstManager",
            DOb = new DateTime(14 / 11 / 1984),
            DateOfJoin = new DateTime(8 / 6 / 2013),
            City = "Pune",
        });
        empList.Add(new Employee
        {
            employeeid = 1004,
            Firstname = "Zina",
            Lastname = "Sakhi",
            Title = "SE",
            DOb = new DateTime(3 / 11 / 1984),
            DateOfJoin = new DateTime(8 / 6 / 2013),
            City = "Pune",
        });
        empList.Add(new Employee
        {
            employeeid = 1005,
            Firstname = "Amit",
            Lastname = "Patak",
            Title = "Consultent",
            DOb = new DateTime(8 / 11 / 1984),
            DateOfJoin = new DateTime(8 / 5/ 2016),
            City = "Mumbai",
        });
        empList.Add(new Employee
        {
            employeeid = 1006,
            Firstname = "Vijay",
            Lastname = "Parthiban",
            Title = "Consultent",
            DOb = new DateTime(7 / 11 / 1984),
            DateOfJoin = new DateTime(8 /6 / 2016),
            City = "Chennai",
        });
        empList.Add(new Employee
        {
            employeeid = 1007,
            Firstname = "Suresh",
            Lastname = "Patak",
            Title = "Consultent",
            DOb = new DateTime(3 / 14/84),
            DateOfJoin = new DateTime(8 /7 / 2014),
            City = "Chennai",
        });
        empList.Add(new Employee
        {
            employeeid = 1008,
            Firstname = "rahul",
            Lastname = "Patak",
            Title = "Associate",
            DOb = new DateTime(11/ 11 / 1984),
            DateOfJoin = new DateTime(8 /8 / 2015),
            City = "Chennai",
        });
        empList.Add(new Employee
        {
            employeeid = 1009,
            Firstname = "sumith",
            Lastname = "Patak",
            Title = "Associate",
            DOb = new DateTime(12/ 11 / 1984),
            DateOfJoin = new DateTime(8 / 9/ 2014),
            City = "pune",
        });
        //  Display employees joined before 1/1/2015
        var before2015 = empList.Where(e => e.DateOfJoin < new DateTime(2015, 1, 1));
        Console.WriteLine("Employees joined before 1/1/2015:");
        foreach (var employee in before2015)
        {
            Console.WriteLine($"{employee.FirstName} {employee.Lastname}");
        }
        // Display employees with DOB after 1/1/1990
        var after1990 = empList.Where(e => e.DOb > new DateTime(1990, 1, 1));
        Console.WriteLine("\nEmployees with DOB after 1/1/1990:");
        foreach (var employee in after1990)
        {
            Console.WriteLine($"{employee.FirstName} {employee.LastName}");
        }
        // Display employees with designation "Consultant" or "Associate"
        var consultantsAndAssociates = empList.Where(e => e.Title == "Consultant" || e.Title == "Associate");
        Console.WriteLine("\nEmployees with designation 'Consultant' or 'Associate':");
        foreach (var Employee in consultantsAndAssociates)
        {
            Console.WriteLine($"{Employee.FirstName} {Employee.LastName}");
        }
        // Task 4: Display total number of employees
        int totalEmployees = empList.Count;
        Console.WriteLine($"\nTotal number of employees: {totalEmployees}");

        // Display total number of employees belonging to "Chennai"
        int chennaiEmployees = empList.Count(e => e.City == "Chennai");
        Console.WriteLine($"Total number of employees in Chennai: {chennaiEmployees}");
        // Task 6: Display highest employee ID
        int highestEmployeeID = empList.Max(e => e.employeeid);
        Console.WriteLine($"Highest Employee ID: {highestEmployeeID}");
        //  Display total number of employees joined after 1/1/2015
        int employeesJoinedAfter2015 = empList.Count(e => e.DateOfJoin > new DateTime(2015, 1, 1));
        Console.WriteLine($"Employees joined after 1/1/2015: {employeesJoinedAfter2015}");
        // Display total number of employees whose designation is not "Associate"
      int nonAssociateEmployees = empList.Count(e => e.Title != "Associate");
        Console.WriteLine($"Employees with a designation other than 'Associate': {nonAssociateEmployees}");
        // Display total number of employees based on City
        var cityGrouping = empList.GroupBy(e => e.City);
        Console.WriteLine("\nTotal number of employees based on City:");
        foreach (var group in cityGrouping)
        {
            Console.WriteLine($"{group.Key}: {group.Count()}");
        }
        // Display total number of employees based on city and title
        var cityTitleGrouping = empList.GroupBy(e => new { e.City, e.Title });
        Console.WriteLine("\nTotal number of employees based on City and Title:");
        foreach (var group in cityTitleGrouping)
        {
            Console.WriteLine($"{group.Key.City} ({group.Key.Title}): {group.Count()}");
        }
        // Display the youngest employee
        var youngestEmployee = empList.OrderBy(e => e.DOb).LastOrDefault();
        Console.WriteLine("\nYoungest employee:");
        Console.WriteLine($"{youngestEmployee.FirstName} {youngestEmployee.LastName}");
        Console.Read();
    }
}
























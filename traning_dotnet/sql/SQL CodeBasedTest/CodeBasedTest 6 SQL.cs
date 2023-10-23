using System;
using System.Data;
using System.Data.SqlClient;

class program
{
    static string connectionString = "Server=ICS-LT-JFTM9K3; Database=infiniteDB; Integrated Security=True";
    private static object command;
    public static SqlCommand SqlCommand { get; private set; }

    static void Main()
    {
        string connectString = "connect string from here";
        using (SqlConnection connection = new SqlConnection(connectionString))
        {
            connection.Open();

            SqlCommand command = new SqlCommand("THEEmployee", connection);
            command.CommandType = CommandType.StoredProcedure;

            command.Parameters.Add(new SqlParameter("@empname", "Siva Gowtham"));
            command.Parameters.Add(new SqlParameter("@empsal", 25000));
            command.Parameters.Add(new SqlParameter("@emptype", "M"));

            command.ExecuteNonQuery();
        }
        Console.WriteLine("New employee records are added");
        DisplayEmployeeRecords(connectString);
    }
    static void DisplayEmployeeRecords(string connectionString)
    {
        using (SqlConnection connection = new SqlConnection(connectionString))
        {
            connection.Open();
            SqlCommand = new SqlCommand("SELECT * FROM Code_Employee", connection);
            using (SqlDataReader reader = command.ExecuteReader())
            {
                Console.WriteLine("Employee Records:");
                while (reader.Read())
                {
                    Console.WriteLine($"empno:{reader["empno"]},empname:{reader["empname"]},emptype:{reader["emptype"]}");
                }
            }

        }
    }
}

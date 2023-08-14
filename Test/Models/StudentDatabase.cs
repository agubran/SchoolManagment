using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test.Models
{
    internal class StudentDatabase
    {
        public void ExecuteCode()
        {
            string connectionString = "Server=.;Database=Test;Trusted_Connection=True;";

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();

                // Create (Insert)
                InsertStudent(connection, "NewStudent", "newstudent@example.com");

                // Read (Select)
                DataTable students = ReadStudents(connection);
                DisplayStudents(students);

                // Update
                UpdateStudent(connection, 1, "UpdatedName");

                // Delete
                DeleteStudent(connection, 10);
            }
        }

        static void InsertStudent(SqlConnection connection, string name, string email)
        {
            string insertQuery = "INSERT INTO Students (Name, Email, IsActive, IsDeleted) VALUES (@Name, @Email, 1, 0)";

            using (SqlCommand command = new SqlCommand(insertQuery, connection))
            {
                command.Parameters.AddWithValue("@Name", name);
                command.Parameters.AddWithValue("@Email", email);

                command.ExecuteNonQuery();
                Console.WriteLine("Student inserted.");
            }
        }

        static DataTable ReadStudents(SqlConnection connection)
        {
            string selectQuery = "SELECT Id, Name, Email, IsActive, IsDeleted FROM Students";
            DataTable dataTable = new DataTable();

            using (SqlCommand command = new SqlCommand(selectQuery, connection))
            {
                using (SqlDataAdapter adapter = new SqlDataAdapter(command))
                {
                    adapter.Fill(dataTable);
                }
            }

            return dataTable;
        }

        static void DisplayStudents(DataTable students)
        {
            foreach (DataRow row in students.Rows)
            {
                Console.WriteLine($"ID: {row["Id"]}, Name: {row["Name"]}, Email: {row["Email"]}");
            }
        }

        static void UpdateStudent(SqlConnection connection, int id, string newName)
        {
            string updateQuery = "UPDATE Students SET Name = @NewName WHERE Id = @Id";

            using (SqlCommand command = new SqlCommand(updateQuery, connection))
            {
                command.Parameters.AddWithValue("@NewName", newName);
                command.Parameters.AddWithValue("@Id", id);

                command.ExecuteNonQuery();
                Console.WriteLine("Student updated.");
            }
        }

        static void DeleteStudent(SqlConnection connection, int id)
        {
            string deleteQuery = "DELETE FROM Students WHERE Id = @Id";

            using (SqlCommand command = new SqlCommand(deleteQuery, connection))
            {
                command.Parameters.AddWithValue("@Id", id);

                command.ExecuteNonQuery();
                Console.WriteLine("Student deleted.");
            }
        }
    }
}

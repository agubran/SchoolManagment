using System.Data;
using System.Data.SqlClient;

namespace SchoolManagment.Web.AdoDatabase
{
    public class StudentDatabase
    {
        public string connectionString = "Server=.;Database=Test;Trusted_Connection=True;";
        public void ExecuteCode()
        {
            

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();

                // Create (Insert)
                InsertStudent(connection, "NewStudent", "newstudent@example.com");

                // Read (Select)
                DataTable students = ReadStudents(connection);
                //DisplayStudents(students);

                // Update
                UpdateStudent(connection, 1, "UpdatedName");

                // Delete
                DeleteStudent(connection, 10);
            }
        }

        public void InsertStudent(SqlConnection connection, string name, string email)
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

        public DataTable ReadStudents(SqlConnection connection)
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

        public List<Student> GetStudents()
        {
            List<Student> lstStudent = new List<Student>();
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                DataTable students = ReadStudents(connection);                
                foreach (DataRow row in students.Rows)
                {
                    lstStudent.Add(new Student
                    {
                        Id = Convert.ToInt32(row["Id"]),
                        Name = row["Name"].ToString(),
                        Email = row["Email"].ToString(),
                        IsActive = Convert.ToBoolean(row["IsActive"]),
                        IsDeleted = Convert.ToBoolean(row["IsDeleted"])
                    });
                    //Console.WriteLine($"ID: {row["Id"]}, Name: {row["Name"]}, Email: {row["Email"]}");
                }
            }
            return lstStudent;
        }

        public void UpdateStudent(SqlConnection connection, int id, string newName)
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

        public void DeleteStudent(SqlConnection connection, int id)
        {
            string deleteQuery = "DELETE FROM Students WHERE Id = @Id";

            using (SqlCommand command = new SqlCommand(deleteQuery, connection))
            {
                command.Parameters.AddWithValue("@Id", id);

                command.ExecuteNonQuery();
                Console.WriteLine("Student deleted.");
            }
        }

        public Student GetStudent(int id)
        {
            Student student = null;

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                student = ReadStudent(connection, id);
            }
            return student;
        }

        private Student ReadStudent(SqlConnection connection, int id)
        {
            string selectQuery = "SELECT Id, Name, Email, IsActive, IsDeleted FROM Students WHERE Id = @Id";
            Student student = null;

            using (SqlCommand command = new SqlCommand(selectQuery, connection))
            {
                command.Parameters.AddWithValue("@Id", id);

                using (SqlDataReader reader = command.ExecuteReader())
                {
                    if (reader.Read())
                    {
                        student = new Student
                        {
                            Id = Convert.ToInt32(reader["Id"]),
                            Name = reader["Name"].ToString(),
                            Email = reader["Email"].ToString(),
                            IsActive = Convert.ToBoolean(reader["IsActive"]),
                            IsDeleted = Convert.ToBoolean(reader["IsDeleted"])
                        };
                    }
                }
            }

            return student;
        }

    }
}

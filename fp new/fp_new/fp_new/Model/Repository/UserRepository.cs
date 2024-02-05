using fp_new.Model.Entity;
using fp_new.Model.Context;
using System;
using System.Collections.Generic;
using System.Data.SQLite;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace fp_new.Model.Repository
{
    public class UserRepository
    {
        private readonly SiakadDbContext _context;

        public UserRepository(SiakadDbContext context)
        {
            _context = context;
        }

        public bool CreateUser(User user)
        {
            bool result = false;

            // Check if the user with the given username already exists
            if (!IsUsernameExists(user.Username))
            {
                string insertQuery = "INSERT INTO User (ser, pass, role) VALUES (@Username, @Password, @Role)";

                using (SQLiteCommand command = new SQLiteCommand(insertQuery, _context.Conn))
                {
                    command.Parameters.AddWithValue("@Username", user.Username);
                    command.Parameters.AddWithValue("@Password", user.Password);
                    command.Parameters.AddWithValue("@Role", user.Role);

                    int rowsAffected = command.ExecuteNonQuery();

                    result = rowsAffected > 0;
                }
            }

            return result;
        }

        public bool IsUsernameExists(string username)
        {
            string selectQuery = "SELECT COUNT(*) FROM User WHERE ser = @Username";

            using (SQLiteCommand command = new SQLiteCommand(selectQuery, _context.Conn))
            {
                command.Parameters.AddWithValue("@Username", username);

                int count = Convert.ToInt32(command.ExecuteScalar());
                return count > 0;
            }
        }

        public bool ValidateUser(string username, string password)
        {
            bool isValidUser = false;

            string selectQuery = "SELECT COUNT(*) FROM User WHERE ser = @Username AND pass = @Password";

            using (SQLiteCommand command = new SQLiteCommand(selectQuery, _context.Conn))
            {
                command.Parameters.AddWithValue("@Username", username);
                command.Parameters.AddWithValue("@Password", password);

                int count = Convert.ToInt32(command.ExecuteScalar());
                isValidUser = count > 0;
            }

            return isValidUser;
        }

        public string GetUserRole(string username)
        {
            string userRole = string.Empty;

            string selectQuery = "SELECT Role FROM User WHERE ser = @Username";

            using (SQLiteCommand command = new SQLiteCommand(selectQuery, _context.Conn))
            {
                command.Parameters.AddWithValue("@Username", username);

                using (SQLiteDataReader reader = command.ExecuteReader())
                {
                    if (reader.Read())
                    {
                        userRole = reader["Role"].ToString();
                    }
                }
            }

            return userRole;
        }

        public List<User> GetAllUsers()
        {
            List<User> userList = new List<User>();

            string selectQuery = "SELECT * FROM User";

            using (SQLiteCommand command = new SQLiteCommand(selectQuery, _context.Conn))
            {
                using (SQLiteDataReader reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        User user = new User
                        {
                            Username = reader["Username"].ToString(),
                            Password = reader["Password"].ToString(),
                            Role = reader["Role"].ToString()
                        };

                        userList.Add(user);
                    }
                }
            }

            return userList;
        }
    }
}

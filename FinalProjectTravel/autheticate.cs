using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace FinalProjectTravel
{
    public class autheticate
    {
        /* By having a dedicated User class, it becomes easier to extend and modify user-related properties 
* or methods in the future without directly affecting the authentication logic. 
* This modularity enhances code maintainability. */
        public class User
        {
            public string Username { get; set; } 
            public string Password { get; set; }
            public string Email { get; set; }
        }

        /* The DatabaseManager class is responsible for handling database operations, including user authentication. 
        * This is a good practice in software design, as it allows for better organization and maintainability. */
        public class DatabaseManager
        {
            public static User AuthenticateUser(string username, string password)
            {
                User user = RetrieveUserInformation(username, password);
                return user;
            }

            /*The RetrieveUserInformation method encapsulates the logic for querying the database and retrieving user information based on the provided username and password. 
            * This method is private, meaning it is intended to be used only within the DatabaseManager class. */
            private static User RetrieveUserInformation(string username, string password)
            {
                using (SqlConnection sqlCon = new SqlConnection(@"Data Source=LAB109PC05\SQLEXPRESS; Initial Catalog=userInfo; Integrated Security=True;"))
                {
                    sqlCon.Open();

                    string loginQuery = "SELECT COUNT(1) FROM userInfo4 WHERE Username=@Username AND Password=@Password";
                    string emailQuery = "SELECT Email FROM userInfo4 WHERE Username=@Username AND Password=@Password";


                    using (SqlCommand loginCmd = new SqlCommand(loginQuery, sqlCon))
                    {
                            using (SqlCommand emailCmd = new SqlCommand(emailQuery, sqlCon))
                            {
                                loginCmd.CommandType = CommandType.Text;
                                emailCmd.CommandType = CommandType.Text;

                                loginCmd.Parameters.AddWithValue("@Username", username);
                                loginCmd.Parameters.AddWithValue("@Password", password);
                                emailCmd.Parameters.AddWithValue("@Username", username);
                                emailCmd.Parameters.AddWithValue("@Password", password);

                                int count = Convert.ToInt32(loginCmd.ExecuteScalar()); 

                                if (count == 1)
                                {
                                    using (SqlDataReader reader = emailCmd.ExecuteReader())
                                    {
                                        if (reader.Read())
                                        {
                                            string email = reader["Email"].ToString();
                                            reader.Close(); 
                                            return new User { Username = username, Password = password, Email = email};
                                                }
                                            }
                                        }
                                    }
                                }
                                return null; 
                            }
                        }
                    }
                }
        }

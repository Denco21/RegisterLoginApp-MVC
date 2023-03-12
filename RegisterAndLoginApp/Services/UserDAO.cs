using static System.Net.Mime.MediaTypeNames;
using System.Drawing;
using System;
using RegisterAndLoginApp.Models;
using System.Data.SqlClient;

namespace RegisterAndLoginApp.Services
{
    public class UserDAO
    {


        string connectionString = @"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=Test;Integrated Security=True;Connect Timeout=30;";

        public bool FindUserByNameAndPassword(UserModel user) 
        {
            bool success = false;
            string sqlStatment = "Select * FROM dbo.Users WHERE username = @username AND password = @password";

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                SqlCommand command = new SqlCommand( sqlStatment, connection);

                command.Parameters.Add("@username", System.Data.SqlDbType.VarChar, 40).Value = user.UserName;
                command.Parameters.Add("@password", System.Data.SqlDbType.VarChar, 40).Value = user.Password;

                try
                {
                    connection.Open();
                    SqlDataReader reader = command.ExecuteReader();

                    if (reader.HasRows)
                    {
                        success = true;
                    }

                }
                catch (Exception e)
                {
                    Console.WriteLine(e.Message);

                }

                return success;
            }



        }
        
        }

}

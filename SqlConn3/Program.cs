using System;
using System.Data.SqlClient;
using System.Configuration;
using System.Collections.Generic;
using System.Data;
namespace SqlConn
{
    class Program
    {
        static void Main(string[] args)
        {


            //inline query on users table 
            SqlConnection conn = new SqlConnection(ConfigurationManager.ConnectionStrings["conn1"].ConnectionString);
            /*  conn.Open();
              Console.WriteLine(conn.State);
              using (SqlCommand cmd = new SqlCommand())
              {
                  cmd.Connection = conn;
                  cmd.CommandText = "insert into users(UserId,UserName,Email,PasswordHash,RegistrationDate)values(7, 'jaco', 'jaco@gmail.com', 'sghfvdgdw5rd', '2024-06-12 10:23:23 AM')";


                  int rows_effected = cmd.ExecuteNonQuery();


                  if (rows_effected > 0)
                  {
                      Console.WriteLine("INSERTED SUCCESSFULLY");

                  }
              }*/





            //stored procedure for insertion in users table

            /*using (SqlCommand cmd = new SqlCommand("IUser"))
            {
                conn.Open();
                Console.WriteLine(conn.State);

                cmd.Connection = conn;
                cmd.CommandType = CommandType.StoredProcedure;


                cmd.Parameters.AddWithValue("@UserId", 8);
                cmd.Parameters.AddWithValue("@UserName", "rose");
                cmd.Parameters.AddWithValue("@Email", "rosy@gmail.com");
                cmd.Parameters.AddWithValue("@PasswordHash", "vsgfstwwddd");
                cmd.Parameters.AddWithValue("@RegistrationDate", DateTime.Parse("2024-06-12 10:23:23 AM"));


                int rows_effected = cmd.ExecuteNonQuery();


                if (rows_effected > 0)
                {
                    Console.WriteLine("INSERTED SUCCESSFULLY");

                }
            }
                
*/


            //inline for updation in category table

            /*conn.Open();
            Console.WriteLine(conn.State);
            using (SqlCommand cmd = new SqlCommand())
            {
                cmd.Connection = conn;
                cmd.CommandText = "UPDATE Category SET Name = 'mystery', Description = 'unveal new things' WHERE CategoryId = 45";


                int rows_effected = cmd.ExecuteNonQuery();


                if (rows_effected > 0)
                {
                    Console.WriteLine("UPDATED SUCCESSFULLY");

                }
            }*/


            //stored procedure for updation table
            using (SqlCommand cmd = new SqlCommand("UpdateCategory")) {
                conn.Open();
                Console.WriteLine(conn.State);

                cmd.Connection = conn;
                cmd.CommandType = CommandType.StoredProcedure;


                cmd.Parameters.AddWithValue("@CategoryId", 47);
                cmd.Parameters.AddWithValue("@NewName", "ROMCOM");
                cmd.Parameters.AddWithValue("@NewDescription", "awesome movie");


                int rows_effected = cmd.ExecuteNonQuery();


                if (rows_effected > 0)
                {
                    Console.WriteLine("UPDATED  SUCCESSFULLY USING STORED PROCEDURE");

                }
            }
        }
            conn.Close();
            Console.WriteLine(conn.State);
            Console.ReadKey();
           


        }

    }
}


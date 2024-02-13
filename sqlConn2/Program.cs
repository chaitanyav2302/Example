using System;
using System.Data.SqlClient;
using System.Configuration;

namespace SqlConn
{
    class Program
    {
        static void Main(string[] args)
        {
            // Initialize SqlConnection object with connection string
            SqlConnection conn = new SqlConnection("Server=EPINHYDW0BE6\\SQLEXPRESS;Database=WordVoyager;Integrated Security=true");

            try
            {
                // Open the connection
                conn.Open();

                // Check the connection state
                Console.WriteLine("Connection State: " + conn.State);
            }
            catch (Exception ex)
            {
                // Handle any exceptions
                Console.WriteLine("Error: " + ex.Message);
            }
            finally
            {
                // Ensure the connection is closed before exiting
                if (conn.State == System.Data.ConnectionState.Open)
                {
                    conn.Close();
                    Console.WriteLine("Connection Closed.");
                }
            }

            Console.ReadKey();
        }
    }
}

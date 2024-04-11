using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace CobaltPrototype
{
    public static class DatabaseHelper
    {
        public static bool IsConnectionSuccessful(string serverName)
        {
            string connectionString = $"Data Source={serverName};Integrated Security=True;";

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                try
                {
                    connection.Open();
                    return true; // Connection opened successfully
                }
                catch (Exception ex)
                {
                    return false;
                }
                finally
                {
                    connection.Close();
                }
            }
        }
    }
}

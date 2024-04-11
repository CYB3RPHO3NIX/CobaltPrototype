using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Dapper;

namespace CobaltPrototype
{
    public class StoredProcedureExecutor
    {
        private readonly string _connectionString;

        public StoredProcedureExecutor(string serverName, string databaseName)
        {
            _connectionString = $"Data Source={serverName};Initial Catalog={databaseName};Integrated Security=True;";
        }

        public DataTable ExecuteStoredProcedure(string procedureName, DynamicParameters parameters = null)
        {
            using (SqlConnection connection = new SqlConnection(_connectionString))
            {
                connection.Open();

                // Using Dapper's Query method to execute the stored procedure
                // and map the result to a DataTable
                DataTable resultTable = new DataTable();
                using (var reader = connection.ExecuteReader(procedureName, parameters, commandType: CommandType.StoredProcedure))
                {
                    resultTable.Load(reader);
                }

                return resultTable;
            }
        }
    }
}

using Dapper;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CobaltPrototype
{
    public class DataManager
    {
        private StoredProcedureExecutor _executor;
        public DataManager(string server, string database)
        {
            _executor = new StoredProcedureExecutor(server, database);
        }
        public DataTable GetData(string schemaName, string tableName, int pageNumber, int pageSize)
        {
            DynamicParameters dynamicParameters = new DynamicParameters();

            // Add parameters to the DynamicParameters object
            dynamicParameters.Add("@SchemaName", schemaName, DbType.String, ParameterDirection.Input);
            dynamicParameters.Add("@TableName", tableName, DbType.String, ParameterDirection.Input);
            dynamicParameters.Add("@PageNumber", pageNumber, DbType.Int32, ParameterDirection.Input);
            dynamicParameters.Add("@PageSize", pageSize, DbType.Int32, ParameterDirection.Input);
            var data = _executor.ExecuteStoredProcedure(StoredProcedures.GetData, dynamicParameters);
            return data; 
        }
    }
}

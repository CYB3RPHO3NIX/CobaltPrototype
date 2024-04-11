using CobaltPrototype.Models;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CobaltPrototype
{
    public class DatabaseManager
    {
        private string _serverName;
        public List<Database> _databases { get; private set; }
        public List<Schema> _schemas { get; private set; }
        public List<Table> _tables { get; private set; }
        public DatabaseManager(string serverName) 
        {
            this._serverName = serverName;
            _databases = new List<Database>();
            _schemas = new List<Schema>();
            _tables = new List<Table>();
        }
        public bool IsConnectionSuccessful()
        {
            string connectionString = $"Data Source={_serverName};Integrated Security=True;";

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
                }finally 
                {
                    connection.Close(); 
                }
            }
        }
        public void GetAllDatabases()
        {
            if (string.IsNullOrEmpty(_serverName))
                return;

            string connectionString = $"Data Source={_serverName};Integrated Security=True;";

            _databases.Clear();
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                try
                {
                    connection.Open();

                    DataTable databases = connection.GetSchema("Databases");

                    //Console.WriteLine($"Databases on server '{serverName}':");
                    foreach (DataRow row in databases.Rows)
                    {
                        string databaseName = row.Field<string>("database_name");
                        _databases.Add(new Database()
                        {
                            Name = databaseName,
                            IsSelected = false
                        });
                    }
                }
                catch (Exception ex)
                {
                    throw;
                }finally 
                {
                    connection.Close(); 
                }
            }
        }
        public void GetAllSchemas()
        {
            if (_databases.Find(e => e.IsSelected == true) == null)
                return;

            string databaseName = _databases.Find(e => e.IsSelected == true).Name;
            string connectionString = $"Data Source={_serverName};Initial Catalog={databaseName};Integrated Security=True;";

            _schemas.Clear();
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                try
                {
                    connection.Open();

                    string query = "SELECT name FROM sys.schemas where principal_id = 1;";

                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        using (SqlDataReader reader = command.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                string schemaName = reader.GetString(0);
                                _schemas.Add(new Schema()
                                {
                                    Name = schemaName,
                                    IsSelected = false
                                });
                            }
                        }
                    }
                }
                catch (Exception ex)
                {
                    // Handle the exception
                    throw;
                }
                finally
                {
                    // Ensure connection is closed
                    connection.Close();
                }
            }


        }
        public void GetAllTables()
        {
            if (_databases.Find(e => e.IsSelected == true) == null)
                return;
            if (_schemas.Find(e => e.IsSelected == true) == null)
                return;
            string databaseName = _databases.Find(e => e.IsSelected == true).Name;
            string schemaName = _schemas.Find(e => e.IsSelected == true).Name;

            string connectionString = $"Data Source={_serverName};Initial Catalog={databaseName};Integrated Security=True;";

            _tables.Clear();
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                try
                {
                    connection.Open();

                    DataTable tables = connection.GetSchema("Tables", new string[] { null, schemaName });

                    foreach (DataRow row in tables.Rows)
                    {
                        string tableName = row.Field<string>("TABLE_NAME");
                        _tables.Add(new Table()
                        {
                            Name = tableName,
                            IsSelected = false
                        });
                    }
                }
                catch (Exception ex)
                {
                    throw;
                }
                finally
                {
                    connection.Close();
                }
            }
        }

        public void SelectDatabase(string databaseName)
        {
            if(_databases.Exists(e => e.Name == databaseName))
            {
                _databases.ForEach(database => database.IsSelected = false);
                _databases.Find(e => e.Name == databaseName).IsSelected = true;

                GetAllSchemas();
            }
        }
        public void SelectSchema(string schemaName)
        {
            if (_schemas.Exists(e => e.Name == schemaName))
            {
                _schemas.ForEach(schema => schema.IsSelected = false);
                _schemas.Find(e => e.Name == schemaName).IsSelected = true;

                GetAllTables();
            }
        }
        public void SelectTable(string tableName) 
        {
            if (_tables.Exists(e => e.Name == tableName))
            {
                _tables.ForEach(table => table.IsSelected = false);
                _tables.Find(e => e.Name == tableName).IsSelected = true;
            }
        }
    }
}

using System.Data;
using System.Data.OleDb;
using System.Windows.Forms;

namespace pharmacyp
{
    public class OleDbCrudHelper
    {
        private readonly string connectionString;

        public OleDbCrudHelper()
        {
            this.connectionString = @"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\Users\Han\Documents\Database8.accdb";
        }

        public DataTable Select(string sql, OleDbParameter[] parameters = null)
        {
            using (OleDbConnection connection = new OleDbConnection(connectionString))
            {
                connection.Open();

                using (OleDbCommand command = new OleDbCommand(sql, connection))
                {
                    if (parameters != null)
                    {
                        command.Parameters.AddRange(parameters);
                    }

                    using (OleDbDataAdapter adapter = new OleDbDataAdapter(command))
                    {
                        DataTable dataTable = new DataTable();
                        adapter.Fill(dataTable);
                        return dataTable;
                    }                  
                }
            }
        }
        public DataTable Selectt(string sql, OleDbParameter parameter = null)
        {
            using (OleDbConnection connection = new OleDbConnection(connectionString))
            {
                connection.Open();

                using (OleDbCommand command = new OleDbCommand(sql, connection))
                {
                    if (parameter != null)
                    {
                        command.Parameters.Add(parameter);
                    }

                    using (OleDbDataAdapter adapter = new OleDbDataAdapter(command))
                    {
                        DataTable dataTable = new DataTable();
                        adapter.Fill(dataTable);
                        return dataTable;
                    }
                }
            }
        }

        public int Insert(string sql, OleDbParameter[] parameters)
        {
            using (OleDbConnection connection = new OleDbConnection(connectionString))
            {
                connection.Open();

                using (OleDbCommand command = new OleDbCommand(sql, connection))
                {
                    if (parameters != null)
                    {
                        command.Parameters.AddRange(parameters);
                    }

                    return command.ExecuteNonQuery();
                }
            }
        }

        public int Update(string sql, OleDbParameter[] parameters)
        {
            using (OleDbConnection connection = new OleDbConnection(connectionString))
            {
                connection.Open();

                using (OleDbCommand command = new OleDbCommand(sql, connection))
                {
                    if (parameters != null)
                    {
                        command.Parameters.AddRange(parameters);
                    }

                    return command.ExecuteNonQuery();
                }
            }
        }

        public OleDbDataReader ExecuteReader(string sql, OleDbParameter[] parameters = null)
        {
            OleDbConnection connection = new OleDbConnection(connectionString);
            OleDbCommand command = new OleDbCommand(sql, connection);

            if (parameters != null)
            {
                command.Parameters.AddRange(parameters);
            }

            connection.Open();
            OleDbDataReader reader = command.ExecuteReader(CommandBehavior.CloseConnection);
            return reader;
        }

        public OleDbDataReader ExecuteReader2(string sql, OleDbParameter parameters = null)
        {
            OleDbConnection connection = new OleDbConnection(connectionString);
            OleDbCommand command = new OleDbCommand(sql, connection);

            if (parameters != null)
            {
                command.Parameters.Add(parameters);
            }

            connection.Open();
            OleDbDataReader reader = command.ExecuteReader(CommandBehavior.CloseConnection);
            return reader;
        }

        public OleDbDataAdapter ExecuteDataAdapter(string sql, OleDbParameter[] parameters = null)
        {
            OleDbConnection connection = new OleDbConnection(connectionString);
            OleDbCommand command = new OleDbCommand(sql, connection);

            if (parameters != null)
            {
                command.Parameters.AddRange(parameters);
            }

            OleDbDataAdapter adapter = new OleDbDataAdapter(command);
            return adapter;
        }

        public OleDbDataAdapter ExecuteDataAdapter(string sql, OleDbParameter parameter = null)
        {
            OleDbConnection connection = new OleDbConnection(connectionString);
            OleDbCommand command = new OleDbCommand(sql, connection);

            if (parameter != null)
            {
                command.Parameters.Add(parameter);
            }

            OleDbDataAdapter adapter = new OleDbDataAdapter(command);
            return adapter;
        }

        public int Delete(string sql, OleDbParameter[] parameters)
        {
            using (OleDbConnection connection = new OleDbConnection(connectionString))
            {
                connection.Open();

                using (OleDbCommand command = new OleDbCommand(sql, connection))
                {
                    if (parameters != null)
                    {
                        command.Parameters.AddRange(parameters);
                    }

                    return command.ExecuteNonQuery();
                }
            }
        }
        public int Delete(string sql, OleDbParameter parameters)
        {
            using (OleDbConnection connection = new OleDbConnection(connectionString))
            {
                connection.Open();

                using (OleDbCommand command = new OleDbCommand(sql, connection))
                {
                    if (parameters != null)
                    {
                        command.Parameters.Add(parameters);
                    }

                    return command.ExecuteNonQuery();
                }
            }
        }
    }

}

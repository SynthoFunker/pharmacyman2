using System;
using System.Data;
using System.Data.OleDb;

namespace pharmacyp
{
    public class OleDbCrudHelper
    {
        public readonly string connectionString;

        public OleDbCrudHelper(string ConnectionString)
        {
            connectionString = connectionString == string.Empty
                ? @"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\Users\Han\source\repos\pharmacyp\Miscellaneous\PharD.accdb"
                : ConnectionString;

        }
        public OleDbCrudHelper()
        {
            connectionString = @"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\Users\Han\source\repos\pharmacyp\Miscellaneous\PharD.accdb";
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
                        _ = adapter.Fill(dataTable);
                        return dataTable;
                    }
                }
            }
        }

        public DataTable SSelect(string sql, OleDbParameter parameter)
        {
            return Select(sql, new OleDbParameter[] { parameter });
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

        public int SInsert(string sql, OleDbParameter parameter)
        {
            return Insert(sql, new OleDbParameter[] { parameter });
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

        public int SUpdate(string sql, OleDbParameter parameter)
        {
            return Update(sql, new OleDbParameter[] { parameter });
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

        public OleDbDataReader SExecuteReader(string sql, OleDbParameter parameter)
        {
            return ExecuteReader(sql, new OleDbParameter[] { parameter });
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

        public OleDbDataAdapter SExecuteDataAdapter(string sql, OleDbParameter parameter)
        {
            return ExecuteDataAdapter(sql, new OleDbParameter[] { parameter });
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

        public int SDelete(string sql, OleDbParameter parameter)
        {
            return Delete(sql, new OleDbParameter[] { parameter });
        }

        public int ExecuteNonQueryWithTransaction(string sql, OleDbParameter[] parameters = null)
        {
            using (OleDbConnection connection = new OleDbConnection(connectionString))
            {
                connection.Open();
                OleDbTransaction transaction = connection.BeginTransaction();

                using (OleDbCommand command = new OleDbCommand(sql, connection, transaction))
                {
                    if (parameters != null)
                    {
                        command.Parameters.AddRange(parameters);
                    }

                    try
                    {
                        int result = command.ExecuteNonQuery();
                        transaction.Commit();
                        return result;
                    }
                    catch (Exception ex)
                    {
                        transaction.Rollback();
                        throw ex;
                    }
                }
            }
        }

        public int SExecuteNonQueryWithTransaction(string sql, OleDbParameter parameter = null)
        {
            return ExecuteNonQueryWithTransaction(sql, new OleDbParameter[] { parameter });
        }
       
        public DataSet SelectDataSet(string sql, OleDbParameter[] parameters = null)
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
                        DataSet dataSet = new DataSet();
                        _ = adapter.Fill(dataSet);
                        return dataSet;
                    }
                }
            }
        }

        public void ExecuteQuery(string sql, OleDbParameter[] parameters = null)
        {
            string[] keywords = sql.Split(' ');

            switch (keywords[0].ToUpper())
            {
                case "SELECT":
                    _ = Select(sql, parameters);
                    break;
                case "INSERT":
                    _ = Insert(sql, parameters);
                    break;
                case "UPDATE":
                    _ = Update(sql, parameters);
                    break;
                case "DELETE":
                    _ = Delete(sql, parameters);
                    break;
                default:
                    throw new Exception("Unknown query type");
            }
        }

        public void SExecuteQuery(string sql, OleDbParameter parameter = null)
        {
            OleDbParameter[] parameters = null;
            if (parameter != null)
            {
                parameters = new OleDbParameter[] { parameter };
            }
            ExecuteQuery(sql, parameters);
        }
    }
}

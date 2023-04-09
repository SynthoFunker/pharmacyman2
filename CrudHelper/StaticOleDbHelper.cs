using System.Data;
using System.Data.OleDb;

namespace pharmacyp.CrudHelper
{
    public static class StaticOleDbHelper
    {

        private static readonly OleDbConnection connection = new OleDbConnection();
        private static string connectionString;

        public static void SetConnectionString(string connectionString)
        {
            StaticOleDbHelper.connectionString = connectionString;
            connection.ConnectionString = connectionString;
        }

        public static DataTable Selectt(string OleDb, OleDbParameter[] parameters = null)
        {
            using (OleDbCommand command = new OleDbCommand(OleDb, connection))
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

        public static int Insert(string OleDb, OleDbParameter[] parameters)
        {
            using (OleDbCommand command = new OleDbCommand(OleDb, connection))
            {
                if (parameters != null)
                {
                    command.Parameters.AddRange(parameters);
                }

                return command.ExecuteNonQuery();
            }
        }

        public static int Update(string OleDb, OleDbParameter[] parameters)
        {
            using (OleDbCommand command = new OleDbCommand(OleDb, connection))
            {
                if (parameters != null)
                {
                    command.Parameters.AddRange(parameters);
                }

                return command.ExecuteNonQuery();
            }
        }

        public static int Delete(string OleDb, OleDbParameter[] parameters)
        {
            using (OleDbCommand command = new OleDbCommand(OleDb, connection))
            {
                if (parameters != null)
                {
                    command.Parameters.AddRange(parameters);
                }

                return command.ExecuteNonQuery();
            }
        }

        public static OleDbDataReader ExecuteReader(string OleDb, OleDbParameter[] parameters = null)
        {
            using (OleDbCommand command = new OleDbCommand(OleDb, connection))
            {
                if (parameters != null)
                {
                    command.Parameters.AddRange(parameters);
                }

                return command.ExecuteReader(CommandBehavior.CloseConnection);
            }
        }

        public static OleDbDataAdapter ExecuteDataAdapter(string OleDb, OleDbParameter[] parameters = null)
        {
            using (OleDbCommand command = new OleDbCommand(OleDb, connection))
            {
                if (parameters != null)
                {
                    command.Parameters.AddRange(parameters);
                }

                using (OleDbDataAdapter adapter = new OleDbDataAdapter(command))
                {
                    return adapter;
                }
            }
        }

        public static DataTable Select(string OleDb, OleDbParameter parameter = null)
        {
            using (OleDbCommand command = new OleDbCommand(OleDb, connection))
            {
                if (parameter != null)
                {
                    _ = command.Parameters.Add(parameter);
                }

                using (OleDbDataAdapter adapter = new OleDbDataAdapter(command))
                {
                    DataTable dataTable = new DataTable();
                    _ = adapter.Fill(dataTable);
                    return dataTable;
                }
            }
        }

        public static int Insert(string OleDb, OleDbParameter parameter)
        {
            using (OleDbCommand command = new OleDbCommand(OleDb, connection))
            {
                if (parameter != null)
                {
                    _ = command.Parameters.Add(parameter);
                }

                return command.ExecuteNonQuery();
            }
        }

        public static int Update(string OleDb, OleDbParameter parameter)
        {
            using (OleDbCommand command = new OleDbCommand(OleDb, connection))
            {
                if (parameter != null)
                {
                    _ = command.Parameters.Add(parameter);
                }

                return command.ExecuteNonQuery();
            }
        }

        public static int Delete(string OleDb, OleDbParameter parameter)
        {
            using (OleDbCommand command = new OleDbCommand(OleDb, connection))
            {
                if (parameter != null)
                {
                    _ = command.Parameters.Add(parameter);
                }

                return command.ExecuteNonQuery();
            }
        }

        public static OleDbDataReader ExecuteReader(string OleDb, OleDbParameter parameter = null)
        {
            using (OleDbCommand command = new OleDbCommand(OleDb, connection))
            {
                if (parameter != null)
                {
                    _ = command.Parameters.Add(parameter);
                }

                return command.ExecuteReader(CommandBehavior.CloseConnection);
            }
        }

        public static OleDbDataAdapter ExecuteDataAdapter(string OleDb, OleDbParameter parameter = null)
        {
            using (OleDbCommand command = new OleDbCommand(OleDb, connection))
            {
                if (parameter != null)
                {
                    _ = command.Parameters.Add(parameter);
                }

                using (OleDbDataAdapter adapter = new OleDbDataAdapter(command))
                {
                    return adapter;
                }
            }
        }
    }
}



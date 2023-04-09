using System.Data;
using System.Data.SqlClient;

namespace pharmacyp.TabContainer
{
    public static class StaticCrudHelper
    {
        private static readonly SqlConnection connection = new SqlConnection();
        private static string connectionString;

        public static void SetConnectionString(string connectionString)
        {
            StaticCrudHelper.connectionString = connectionString;
            connection.ConnectionString = connectionString;
        }

        public static DataTable Select(string sql, SqlParameter[] parameters = null)
        {
            using (SqlCommand command = new SqlCommand(sql, connection))
            {
                if (parameters != null)
                {
                    command.Parameters.AddRange(parameters);
                }

                using (SqlDataAdapter adapter = new SqlDataAdapter(command))
                {
                    DataTable dataTable = new DataTable();
                    _ = adapter.Fill(dataTable);
                    return dataTable;
                }
            }
        }

        public static int Insert(string sql, SqlParameter[] parameters)
        {
            using (SqlCommand command = new SqlCommand(sql, connection))
            {
                if (parameters != null)
                {
                    command.Parameters.AddRange(parameters);
                }

                return command.ExecuteNonQuery();
            }
        }

        public static int Update(string sql, SqlParameter[] parameters)
        {
            using (SqlCommand command = new SqlCommand(sql, connection))
            {
                if (parameters != null)
                {
                    command.Parameters.AddRange(parameters);
                }

                return command.ExecuteNonQuery();
            }
        }

        public static int Delete(string sql, SqlParameter[] parameters)
        {
            using (SqlCommand command = new SqlCommand(sql, connection))
            {
                if (parameters != null)
                {
                    command.Parameters.AddRange(parameters);
                }

                return command.ExecuteNonQuery();
            }
        }

        public static SqlDataReader ExecuteReader(string sql, SqlParameter[] parameters = null)
        {
            using (SqlCommand command = new SqlCommand(sql, connection))
            {
                if (parameters != null)
                {
                    command.Parameters.AddRange(parameters);
                }

                return command.ExecuteReader(CommandBehavior.CloseConnection);
            }
        }

        public static SqlDataAdapter ExecuteDataAdapter(string sql, SqlParameter[] parameters = null)
        {
            using (SqlCommand command = new SqlCommand(sql, connection))
            {
                if (parameters != null)
                {
                    command.Parameters.AddRange(parameters);
                }

                using (SqlDataAdapter adapter = new SqlDataAdapter(command))
                {
                    return adapter;
                }
            }
        }

        public static DataTable Select(string sql, SqlParameter parameters = null)
        {
            using (SqlCommand command = new SqlCommand(sql, connection))
            {
                if (parameters != null)
                {
                    _ = command.Parameters.Add(parameters);
                }

                using (SqlDataAdapter adapter = new SqlDataAdapter(command))
                {
                    DataTable dataTable = new DataTable();
                    _ = adapter.Fill(dataTable);
                    return dataTable;
                }
            }
        }

        public static int Insert(string sql, SqlParameter parameter)
        {
            using (SqlCommand command = new SqlCommand(sql, connection))
            {
                if (parameter != null)
                {
                    _ = command.Parameters.Add(parameter);
                }

                return command.ExecuteNonQuery();
            }
        }

        public static int Update(string sql, SqlParameter parameters)
        {
            using (SqlCommand command = new SqlCommand(sql, connection))
            {
                if (parameters != null)
                {
                    _ = command.Parameters.Add(parameters);
                }

                return command.ExecuteNonQuery();
            }
        }

        public static int Delete(string sql, SqlParameter parameters)
        {
            using (SqlCommand command = new SqlCommand(sql, connection))
            {
                if (parameters != null)
                {
                    _ = command.Parameters.Add(parameters);
                }

                return command.ExecuteNonQuery();
            }
        }

        public static SqlDataReader ExecuteReader(string sql, SqlParameter parameters = null)
        {
            using (SqlCommand command = new SqlCommand(sql, connection))
            {

                if (parameters != null)
                {
                    _ = command.Parameters.Add(parameters);
                }

                return command.ExecuteReader(CommandBehavior.CloseConnection);
            }
        }

        public static SqlDataAdapter ExecuteDataAdapter(string sql, SqlParameter parameters = null)
        {
            using (SqlCommand command = new SqlCommand(sql, connection))
            {
                if (parameters != null)
                {
                    _ = command.Parameters.Add(parameters);
                }

                using (SqlDataAdapter adapter = new SqlDataAdapter(command))
                {
                    return adapter;
                }
            }
        }
    }
}

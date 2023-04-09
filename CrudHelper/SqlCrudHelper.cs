using System.Data;
using System.Data.OleDb;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace pharmacyp
{
    public class SqlCrudHelper
    {
        private readonly string connectionString;

        public SqlCrudHelper()
        {
            this.connectionString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Han\Documents\PharDB.mdf;Integrated Security=True;Connect Timeout=30";
        }

        public DataTable Select(string sql, SqlParameter[] parameters = null)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();

                using (SqlCommand command = new SqlCommand(sql, connection))
                {
                    if (parameters != null)
                    {
                        command.Parameters.AddRange(parameters);
                    }

                    using (SqlDataAdapter adapter = new SqlDataAdapter(command))
                    {
                        DataTable dataTable = new DataTable();
                        adapter.Fill(dataTable);
                        return dataTable;
                    }                  
                }
            }
        }

        public int Insert(string sql, SqlParameter[] parameters)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();

                using (SqlCommand command = new SqlCommand(sql, connection))
                {
                    if (parameters != null)
                    {
                        command.Parameters.AddRange(parameters);
                    }

                    return command.ExecuteNonQuery();
                }
            }
        }

        public int Update(string sql, SqlParameter[] parameters)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();

                using (SqlCommand command = new SqlCommand(sql, connection))
                {
                    if (parameters != null)
                    {
                        command.Parameters.AddRange(parameters);
                    }

                    return command.ExecuteNonQuery();
                }
            }
        }

        public SqlDataReader ExecuteReader(string sql, SqlParameter[] parameters = null)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                using (SqlCommand command = new SqlCommand(sql, connection))
                {
                    if (parameters != null)
                    {
                        command.Parameters.AddRange(parameters);
                    }

                    connection.Open();
                    return command.ExecuteReader(CommandBehavior.CloseConnection);
                }
            }
        }

        public SqlDataReader ExecuteReader2(string sql, SqlParameter parameters = null)
        {
            SqlConnection connection = new SqlConnection(connectionString);
            SqlCommand command = new SqlCommand(sql, connection);

            if (parameters != null)
            {
                command.Parameters.Add(parameters);
            }

            connection.Open();
            SqlDataReader reader = command.ExecuteReader(CommandBehavior.CloseConnection);
            return reader;
        }

        public SqlDataAdapter ExecuteDataAdapter(string sql, SqlParameter[] parameters = null)
        {
            SqlConnection connection = new SqlConnection(connectionString);
            SqlCommand command = new SqlCommand(sql, connection);

            if (parameters != null)
            {
                command.Parameters.AddRange(parameters);
            }

            SqlDataAdapter adapter = new SqlDataAdapter(command);
            return adapter;
        }

        public SqlDataAdapter ExecuteDataAdapter(string sql, SqlParameter parameter = null)
        {
            SqlConnection connection = new SqlConnection(connectionString);
            SqlCommand command = new SqlCommand(sql, connection);

            if (parameter != null)
            {
                command.Parameters.Add(parameter);
            }

            SqlDataAdapter adapter = new SqlDataAdapter(command);
            return adapter;
        }

        public int Delete(string sql, SqlParameter[] parameters)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();

                using (SqlCommand command = new SqlCommand(sql, connection))
                {
                    if (parameters != null)
                    {
                        command.Parameters.AddRange(parameters);
                    }

                    return command.ExecuteNonQuery();
                }
            }
        }
    }

}

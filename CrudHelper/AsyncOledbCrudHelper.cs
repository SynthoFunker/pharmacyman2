using System;
using System.Data;
using System.Data.Common;
using System.Data.OleDb;
using System.Threading.Tasks;

namespace pharmacyp
{
    public class AsyncOleDbCrudHelper : OleDbCrudHelper, IDisposable
    {
        public readonly string ConnectionString;

        public OleDbConnection Connection { get; set; }

        public AsyncOleDbCrudHelper(string connectionString)
        {
            this.ConnectionString = this.ConnectionString == string.Empty
                ? @"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\Users\Han\source\repos\pharmacyp\Miscellaneous\PharD.accdb"
                : connectionString;
        }

        public AsyncOleDbCrudHelper()
        {
            this.ConnectionString = @"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\Users\Han\source\repos\pharmacyp\Miscellaneous\PharD.accdb";
        }

        public async Task<DataTable> SelectAsync(string sql, OleDbParameter[] parameters = null)
        {
            using (OleDbConnection connection = new OleDbConnection(this.ConnectionString))
            {
                await connection.OpenAsync();
                using (OleDbCommand command = new OleDbCommand(sql, connection))
                {
                    if (parameters != null)
                    {
                        command.Parameters.AddRange(parameters);
                    }

                    using (OleDbDataAdapter adapter = new OleDbDataAdapter(command))
                    {
                        DataTable dataTable = new DataTable();
                        await Task.Run(() =>
                        {
                            adapter.Fill(dataTable);
                        });
                        return dataTable;
                    }
                }
            }
        }

        public async Task<DataTable> SSelectAsync(string sql, OleDbParameter parameter)
        {
            return await SelectAsync(sql, new OleDbParameter[] { parameter });
        }

        public async Task<int> InsertAsync(string sql, OleDbParameter[] parameters)
        {
            using (OleDbConnection connection = new OleDbConnection(ConnectionString))
            {
                await connection.OpenAsync();

                using (OleDbCommand command = new OleDbCommand(sql, connection))
                {
                    if (parameters != null)
                    {
                        command.Parameters.AddRange(parameters);
                    }

                    return await command.ExecuteNonQueryAsync();
                }
            }
        }

        public async Task<int> SInsertAsync(string sql, OleDbParameter parameter)
        {
            return await InsertAsync(sql, new OleDbParameter[] { parameter });
        }

        public async Task<int> UpdateAsync(string sql, OleDbParameter[] parameters)
        {
            using (OleDbConnection connection = new OleDbConnection(ConnectionString))
            {
                await connection.OpenAsync();

                using (OleDbCommand command = new OleDbCommand(sql, connection))
                {
                    if (parameters != null)
                    {
                        command.Parameters.AddRange(parameters);
                    }

                    return await command.ExecuteNonQueryAsync();
                }
            }
        }

        public async Task<int> SUpdateAsync(string sql, OleDbParameter parameter)
        {
            return await UpdateAsync(sql, new OleDbParameter[] { parameter });
        }

        public async Task<OleDbDataReader> ExecuteReaderAsync(string sql, OleDbParameter[] parameters = null)
        {
            OleDbConnection connection = new OleDbConnection(ConnectionString);
            OleDbCommand command = new OleDbCommand(sql, connection);

            if (parameters != null)
            {
                command.Parameters.AddRange(parameters);
            }

            await connection.OpenAsync();
            OleDbDataReader reader = (OleDbDataReader)await command.ExecuteReaderAsync(CommandBehavior.CloseConnection);
            return reader;
        }

        public async Task<OleDbDataReader> SExecuteReaderAsync(string sql, OleDbParameter parameter)
        {
            return await ExecuteReaderAsync(sql, new OleDbParameter[] { parameter });
        }

        public async Task<OleDbDataAdapter> ExecuteDataAdapterAsync(string sql, OleDbParameter[] parameters = null)
        {
            OleDbConnection connection = new OleDbConnection(ConnectionString);
            OleDbCommand command = new OleDbCommand(sql, connection);

            if (parameters != null)
            {
                command.Parameters.AddRange(parameters);
            }

            await connection.OpenAsync();

            OleDbDataAdapter adapter = new OleDbDataAdapter(command);
            return adapter;
        }

        public async Task<OleDbDataAdapter> SExecuteDataAdapterAsync(string sql, OleDbParameter parameter)
        {
            return await ExecuteDataAdapterAsync(sql, new OleDbParameter[] { parameter });
        }

        public async Task<int> DeleteAsync(string sql, OleDbParameter[] parameters)
        {
            using (OleDbConnection connection = new OleDbConnection(ConnectionString))
            {
                await connection.OpenAsync();

                using (OleDbCommand command = new OleDbCommand(sql, connection))
                {
                    if (parameters != null)
                    {
                        command.Parameters.AddRange(parameters);
                    }

                    return await command.ExecuteNonQueryAsync();
                }
            }
        }

        public async Task<int> SDeleteAsync(string sql, OleDbParameter parameter)
        {
            return await DeleteAsync(sql, new OleDbParameter[] { parameter });
        }

        public async Task<int> AsyncExecuteNonQueryWithTransaction(string sql, OleDbParameter[] parameters = null)
        {
            using (OleDbConnection connection = new OleDbConnection(ConnectionString))
            {
                await connection.OpenAsync();
                using (OleDbTransaction transaction = await Task.Run(() => connection.BeginTransaction()))
                {
                    using (OleDbCommand command = new OleDbCommand(sql, connection, transaction))
                    {
                        if (parameters != null)
                        {
                            command.Parameters.AddRange(parameters);
                        }

                        try
                        {
                            int result = await command.ExecuteNonQueryAsync();
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
        }

        public new async Task<int> SExecuteNonQueryWithTransaction(string sql, OleDbParameter parameter = null)
        {
            return await this.AsyncExecuteNonQueryWithTransaction(sql, new OleDbParameter[] { parameter });
        }

        public async Task<DataSet> SelectDataSetAsync(string sql, OleDbParameter[] parameters = null)
        {
            using (OleDbConnection connection = new OleDbConnection(this.ConnectionString))
            {
                await connection.OpenAsync();

                using (OleDbCommand command = new OleDbCommand(sql, connection))
                {
                    if (parameters != null)
                    {
                        command.Parameters.AddRange(parameters);
                    }

                    using (OleDbDataAdapter adapter = new OleDbDataAdapter(command))
                    {
                        DataSet dataSet = new DataSet();
                        await Task.Run(() =>
                        {
                            adapter.Fill(dataSet);
                        });
                        return dataSet;
                    }
                }
            }
        }

        public async Task ExecuteQueryAsync(string sql, OleDbParameter[] parameters = null)
        {
            string[] keywords = sql.Split(' ');

            switch (keywords[0].ToUpper())
            {
                case "SELECT":
                    await this.SelectAsync(sql, parameters);
                    break;
                case "INSERT":
                    await this.InsertAsync(sql, parameters);
                    break;
                case "UPDATE":
                    await this.UpdateAsync(sql, parameters);
                    break;
                case "DELETE":
                    await this.DeleteAsync(sql, parameters);
                    break;
                default:
                    break;
            }
        }

        public async Task SExecuteQueryAsync(string sql, OleDbParameter parameter = null)
        {
            OleDbParameter[] parameters = null;
            if (parameter != null)
            {
                parameters = new OleDbParameter[] { parameter };
            }

            await this.ExecuteQueryAsync(sql, parameters);
        }

        public void Dispose()
        {
            if (this.Connection != null)
            {
                if (this.Connection.State == ConnectionState.Open)
                {
                    this.Connection.Close();
                }

                this.Connection.Dispose();
                this.Connection = null;
            }
        }
    }

}

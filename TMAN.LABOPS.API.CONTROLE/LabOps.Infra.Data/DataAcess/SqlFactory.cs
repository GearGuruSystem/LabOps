using Dapper;
using Microsoft.Extensions.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Data.SqlTypes;

#pragma warning disable IDE0063 // Use simple 'using' statement
#pragma warning disable IDE0290 // Use primary constructor

namespace LabOps.Infra.Data.DataAcess
{
    public class SqlFactory
    {
        private readonly IConfiguration configuration;

        public SqlFactory(IConfiguration configuration)
        {
            this.configuration = configuration;
        }

        public async Task<IQueryable<T>> LoadDataAsync<T>(string storedProcedure, object parameters = null, string connectionName = "AppDBConnection")
        {
            using (IDbConnection connection = new SqlConnection(configuration.GetConnectionString(connectionName)))
            {
                var response = await connection.QueryAsync<T>(storedProcedure, parameters, commandType: CommandType.StoredProcedure);
                if (response.Any())
                {
                    return response.AsQueryable();
                }
                throw new SqlNullValueException("Não encontrado nenhum valor no banco");
            }
        }

        public async Task<Task> SaveDataAsync<T>(string storedProcedure, T parameters, string connectionName = "AppDBConnection")
        {
            using (IDbConnection connection = new SqlConnection(configuration.GetConnectionString(connectionName)))
            {
                var result = await connection.ExecuteAsync(storedProcedure, parameters, commandType: CommandType.StoredProcedure);
                if (result == 0)
                {
                    throw new Exception("Não foi alterada nenhuma linha no banco de dados");
                }
                return Task.CompletedTask;
            }
        }
    }
}
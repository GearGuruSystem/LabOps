using Dapper;
using Microsoft.Data.SqlClient;
using Microsoft.Extensions.Configuration;
using System.Data;

#pragma warning disable IDE0063 // Use simple 'using' statement
#pragma warning disable IDE0290 // Use primary constructor

namespace LabOps.Infrastructure.Data.DataAcess
{
    public class SqlFactory
    {
        private readonly IConfiguration configuration;

        public SqlFactory(IConfiguration configuration)
        {
            this.configuration = configuration;
        }

        //METODO QUE FAZ A LEITURA NO BANCO
        public async Task<IEnumerable<T>> LoadDataAsync<T, U>(string storedProcedure, U parameters, string connectionName = "SqlDataLocal")
        {
            using (IDbConnection connection = new SqlConnection(configuration.GetConnectionString(connectionName)))
            {
                var response = await connection.QueryAsync<T>(storedProcedure, parameters, commandType: CommandType.StoredProcedure);
                return response;
            }
        }

        //METODO QUE FAZ EXECUÇÃO NO BANCO
        public async Task<Task> SaveDataAsync<T>(string storedProcedure, T parameters, string connectionName = "SqlDataLocal")
        {
            using (IDbConnection connection = new SqlConnection(configuration.GetConnectionString(connectionName)))
            {
                var result = await connection.ExecuteAsync(storedProcedure, parameters, commandType: CommandType.StoredProcedure);
                if (result.GetHashCode() == 0)
                {
                    throw new Exception("Ocorreu um erro ao executar procedure.");
                }
                return Task.CompletedTask;
            }
        }
    }
}

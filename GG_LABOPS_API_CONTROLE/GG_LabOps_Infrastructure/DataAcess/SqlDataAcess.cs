using Dapper;
using GG_LabOps_Domain.Interfaces;
using Microsoft.Extensions.Configuration;
using System.Data;
using System.Data.SqlClient;
#pragma warning disable IDE0063 // Use simple 'using' statement
#pragma warning disable IDE0290 // Use primary constructor

namespace GG_LabOps_Infrastructure.DataAcess
{
    internal class SqlDataAcess : ISqlDataAcess
    {
        private readonly IConfiguration configuration;

        public SqlDataAcess(IConfiguration configuration)
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
        public async Task SaveDataAsync<T>(string storedProcedure, T parameters, string connectionName = "SqlDataLocal")
        {
            using (IDbConnection connection = new SqlConnection(configuration.GetConnectionString(connectionName)))
            {
                await connection.ExecuteAsync(storedProcedure, parameters, commandType: CommandType.StoredProcedure);
            }
        }
    }
}
 
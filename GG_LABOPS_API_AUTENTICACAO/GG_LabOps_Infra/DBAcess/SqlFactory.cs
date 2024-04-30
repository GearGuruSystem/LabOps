using Dapper;
using GG_labOps_Domain.Exceptions;
using GG_LabOps_Services.Interfaces;
using Microsoft.Extensions.Configuration;
using System.Data;
using System.Data.SqlClient;

namespace GG_LabOps_Infra.DBAcess
#pragma warning disable IDE0063 // Use simple 'using' statement
#pragma warning disable IDE0290 // Use primary constructor
{
    public class SqlFactory : ISqlFactory
    {
        private readonly IConfiguration configuration;

        public SqlFactory(IConfiguration configuration)
        {
            this.configuration = configuration;
        }

        //METODO QUE FAZ A LEITURA NO BANCO
        public async Task<IEnumerable<T>> LoadData<T, U>(string storedProcedure, U parameters, string connectionName = "AppDataContext")
        {
            using (IDbConnection connection = new SqlConnection(configuration.GetConnectionString(connectionName)))
            {
                var result = await connection.QueryAsync<T>(storedProcedure, parameters, commandType: CommandType.StoredProcedure);
                if (result.Any())
                {
                    return result;
                }
                throw new DataBaseExceptions("Não foi encontrado nenhuma informação.");
            }
        }

        //METODO QUE FAZ EXECUÇÃO NO BANCO
        public async Task<Task> SaveData<T>(string storedProcedure, T parameters, string connectionName = "AppDataContext")
        {
            using (IDbConnection connection = new SqlConnection(configuration.GetConnectionString(connectionName)))
            {
                var result = await connection.ExecuteAsync(storedProcedure, parameters, commandType: CommandType.StoredProcedure);
                if (result.GetHashCode() == 0)
                {
                    throw new DataBaseExceptions();
                }
                return Task.CompletedTask;
            }
        }
    }
}
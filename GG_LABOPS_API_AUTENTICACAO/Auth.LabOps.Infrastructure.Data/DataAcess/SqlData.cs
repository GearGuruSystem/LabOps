﻿using Dapper;
using Microsoft.Data.SqlClient;
using Microsoft.Extensions.Configuration;
using System.Data;

#pragma warning disable IDE0063 // Use simple 'using' statement
#pragma warning disable IDE0290 // Use primary constructor

namespace Auth.LabOps.Infrastructure.Data.DataAcess
{
    public class SqlData : ISqlData
    {
        private readonly IConfiguration configuration;

        public SqlData(IConfiguration configuration)
        {
            this.configuration = configuration;
        }
        public async Task<IEnumerable<T>> LoadDataAsync<T, U>(string storedProcedure, U parameters, string connectionName = "SqlDataAcess")
        {
            using (IDbConnection connection = new SqlConnection(configuration.GetConnectionString(connectionName)))
            {
                var response = await connection.QueryAsync<T>(storedProcedure, parameters, commandType: CommandType.StoredProcedure);
                if(response.Any())
                {
                    return response;
                }
                throw new Exception("Não foi encontrado nenhum resultado");
            }
        }

        //METODO QUE FAZ EXECUÇÃO NO BANCO
        public async Task<Task> SaveDataAsync<T>(string storedProcedure, T parameters, string connectionName = "SqlDataAcess")
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

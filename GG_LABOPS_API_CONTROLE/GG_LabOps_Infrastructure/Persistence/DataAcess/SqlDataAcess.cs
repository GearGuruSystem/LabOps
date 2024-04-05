using Dapper;
using GG_LabOps_Domain.Interfaces;
using Microsoft.Extensions.Configuration;
using System.Data;
using System.Data.SqlClient;

namespace GG_LabOps_Infrastructure.Persistence.DataAcess
{
    public class SqlDataAcess : ISqlDataAcess
    {
        private readonly IConfiguration configuration;

        public SqlDataAcess(IConfiguration configuration)
        {
            this.configuration = configuration;
        }

        //METODO QUE FAZ A LEITURA NO BANCO
        public async Task<IEnumerable<T>> LoadData<T, U>(string storedProcedure, U parameters, string connectionName = "SqlDataLocal")
        {
            using (IDbConnection connection = new SqlConnection(configuration.GetConnectionString(connectionName)))
            {
                return await connection.QueryAsync<T>(storedProcedure, parameters, commandType: CommandType.StoredProcedure);
            }
        }

        //METODO QUE FAZ EXECUÇÃO NO BANCO
        public async Task SaveData<T>(string storedProcedure, T parameters, string connectionName = "SqlDataLocal")
        {
            using (IDbConnection connection = new SqlConnection(configuration.GetConnectionString(connectionName)))
            {
                await connection.ExecuteAsync(storedProcedure, parameters, commandType: CommandType.StoredProcedure);
            }
        }
    }
}

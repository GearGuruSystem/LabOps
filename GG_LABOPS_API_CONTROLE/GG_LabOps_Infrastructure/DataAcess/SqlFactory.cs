using GG_LabOps_Domain.Interfaces;
using Microsoft.Extensions.Configuration;
using System.Data;
using System.Data.SqlClient;
#pragma warning disable IDE0290 // Use primary constructor

namespace GG_LabOps_Infrastructure.DataAcess
{
    public class SqlFactory : ISqlFactory
    {
        public readonly IConfiguration configuration;

        public SqlFactory(IConfiguration configuration)
        {
            this.configuration = configuration;
        }

        public IDbConnection CreateConnection()
        {
            var connectionString = configuration.GetConnectionString("SqlDataLocal");
            return new SqlConnection(connectionString);
        }
    }
}

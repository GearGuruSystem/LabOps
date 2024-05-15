using Microsoft.Data.SqlClient;
using Microsoft.Extensions.Configuration;
using System.Data;

#pragma warning disable IDE0290 // Use primary constructor

namespace LabOps.Infrastructure.Data.DataAcess
{
    public class SqlDataAcess
    {
        public readonly IConfiguration configuration;

        public SqlDataAcess(IConfiguration configuration)
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

using Microsoft.Data.SqlClient;
using Microsoft.Extensions.Configuration;
using System.Data;

#pragma warning disable IDE0290 // Use primary constructor

namespace Auth.LabOps.Infrastructure.Data.DataAcess
{
    public class SqlFactory
    {
        public readonly IConfiguration configuration;

        public SqlFactory(IConfiguration configuration)
        {
            this.configuration = configuration;
        }

        public IDbConnection CreateConnection()
        {
            var connectionString = configuration.GetConnectionString("SqlDataAcess");
            return new SqlConnection(connectionString);
        }
    }
}

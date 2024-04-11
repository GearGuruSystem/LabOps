using GG_LabOps_Domain.Interfaces;
using Microsoft.Extensions.Configuration;
using System.Data;
using System.Data.SqlClient;
#pragma warning disable IDE0290 // Use primary constructor

namespace GG_LabOps_Infrastructure.DataContext
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
            var connectionString = configuration.GetSection("ConnectionString").Value;
            return new SqlConnection(connectionString);
        }
    }
}

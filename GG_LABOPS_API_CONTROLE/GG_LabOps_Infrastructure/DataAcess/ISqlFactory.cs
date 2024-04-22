using System.Data;

namespace GG_LabOps_Infrastructure.DataAcess
{
    public interface ISqlFactory
    {
        public IDbConnection CreateConnection();
    }
}

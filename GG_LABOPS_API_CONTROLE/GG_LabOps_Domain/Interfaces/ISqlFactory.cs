using System.Data;

namespace GG_LabOps_Domain.Interfaces
{
    public interface ISqlFactory
    {
        public IDbConnection CreateConnection();
    }
}

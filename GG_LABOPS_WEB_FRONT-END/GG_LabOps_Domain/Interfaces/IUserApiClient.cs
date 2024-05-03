using GG_LabOps_Domain.Entities;

namespace GG_LabOps_Domain.Interfaces
{
    public interface IUserApiClient
    {
        Task<User> FindByKey(string userKey);
    }
}

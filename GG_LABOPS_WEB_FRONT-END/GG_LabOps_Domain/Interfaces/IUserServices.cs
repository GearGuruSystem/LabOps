using GG_LabOps_Domain.Entities;

namespace GG_LabOps_Domain.Interfaces
{
    public interface IUserServices
    {
        Task<User> SearchUserByKey(string userKey);
    }
}

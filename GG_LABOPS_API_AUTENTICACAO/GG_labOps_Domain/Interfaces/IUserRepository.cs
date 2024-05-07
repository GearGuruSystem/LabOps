using GG_labOps_Domain.Entities;

namespace GG_labOps_Domain.Interfaces
{
    public interface IUserRepository
    {
        Task<User> AddUser(User user);

        Task<User> SearchUser(string userKey);

        Task<User> SearchUser(User user);

        Task<User> UpdateUser(int id, User user);
    }
}
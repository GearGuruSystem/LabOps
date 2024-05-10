using GG_labOps_Domain.Entities;

namespace GG_labOps_Domain.Interfaces
{
    public interface IUserRepository
    {
        Task<User> InsertUserAsync(User user);

        Task<User> SearchUserAsync(string userKey);

        Task<User> SearchUserAsync(User user);

        Task<User> UpdateUser(int id, User user);
    }
}
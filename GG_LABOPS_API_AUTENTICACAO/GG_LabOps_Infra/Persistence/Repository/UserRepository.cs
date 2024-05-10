using GG_labOps_Domain.Entities;
using GG_labOps_Domain.Exceptions;
using GG_labOps_Domain.Interfaces;
using GG_LabOps_Services.Security;
#pragma warning disable IDE0290 // Use primary constructor

namespace GG_LabOps_Infra.Persistence.Repository
{
    public class UserRepository : IUserRepository
    {
        private readonly ISqlFactory _sqlFactory;

        public UserRepository(ISqlFactory sqlFactory)
        {
            _sqlFactory = sqlFactory;
        }

        public async Task<User> SearchUserAsync(User user)
        {
            VerifyParameters(user);
            var userData = await _sqlFactory.LoadData<User, dynamic>("", new
            {
            });
            return userData.FirstOrDefault();
        }

        public async Task<User> SearchUserAsync(string userKey)
        {
            VerifyParameters(userKey);
            var userData = await _sqlFactory.LoadData<User, dynamic>("", new
            {
            });
            return userData.FirstOrDefault();
        }

        public async Task<User> InsertUserAsync(User user)
        {
            await _sqlFactory.SaveData("", new
            {
                user.Nome,
                user.ChaveUsuario,
                user.Email,
                user.Senha,
                user.ConfirmaSenha
            });
            return user;
        }

        public async Task<User> UpdateUser(int id, User user)
        {
            await SearchUserAsync(user);
            GeneratesHashPasswordUser.ConverteSenhaEmHash(user);
            await _sqlFactory.SaveData("", new
            {
            });
            return user;
        }

        private static bool VerifyParameters(string userKey)
        {
            if (userKey == null)
            {
                throw new GenericsErrorExceptions("Reveja o parametro enviado");
            }
            return true;
        }

        private static bool VerifyParameters(User user)
        {
            if (user.ChaveUsuario == null)
            {
                throw new GenericsErrorExceptions("Reveja o parametro enviado");
            }
            return true;
        }
    }
}
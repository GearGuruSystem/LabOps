using GG_labOps_Domain.Entities;
using GG_labOps_Domain.Exceptions;
using GG_LabOps_Services.Interfaces;

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

        public async Task<User> SearchUser(User user)
        {
            VerifyParameters(user);
            var uData = await _sqlFactory.LoadData<User, dynamic>("", new 
            {
                
            });
            if (uData.Any())
            {
                return uData.FirstOrDefault();
            }
            throw new BancoDeDadosExceptions("Encontrado nenhum valor.");
        }

        public async Task<User> AddUser(User user)
        {
            var result = await _sqlFactory.SaveData("", new
            {
                user.Nome,
                user.ChaveUsuario,
                user.Email,
                user.Senha,
                user.ConfirmaSenha
            });
            if (result.IsCompleted)
            {
                return user;
            }
            throw new BancoDeDadosExceptions($@"Falha ao inserir usuário {user.Nome} no banco de dados!");
        }

        public Task<User> UpdateUser(int id, User user)
        {
            throw new NotImplementedException();
        }

        private static bool VerifyParameters(User user)
        {
            if (user.ChaveUsuario != null)
            {
                throw new ErroGenericoExceptions("Reveja o parametro enviado");
            }
            return true;
        }
    }
}

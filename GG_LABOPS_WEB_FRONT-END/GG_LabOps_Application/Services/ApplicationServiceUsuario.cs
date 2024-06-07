using GG_LabOps_Application.Interfaces;
using GG_LabOps_Domain.Entities;
using GG_LabOps_Domain.Interfaces;

#pragma warning disable IDE0290

namespace GG_LabOps_Application.Services
{
    public class ApplicationServiceUsuario : IApplicationServiceUsuario
    {
        private readonly IUsuarioApiClient _userClient;

        public ApplicationServiceUsuario(IUsuarioApiClient userClient)
        {
            _userClient = userClient;
        }

        public async Task<Usuario> LoginUser(Usuario userDTO)
        {
            return await _userClient.LoginUsuario(userDTO);
        }

        public async Task<Usuario> SearchUserByKey(string userKey)
        {
            return await _userClient.BuscaPorChave(userKey);
        }
    }
}
using Auth.LabOps.Domain.Entities;
using Auth.LabOps.Domain.Services.Services;
using Microsoft.AspNetCore.Identity;

namespace Auth.LabOps.Domain.Services.Security
{
    public static class ServiceSecurity
    {
        private static readonly ServiceUsuario service;
        private static ServiceUsuario Service => service;

        public static void ConverteSenhaEmHash(Usuario usuario)
        {
            var senhaHasher = new PasswordHasher<Usuario>();
            usuario.Senha = senhaHasher.HashPassword(usuario, usuario.Senha);
        }

        public static async Task<bool> ValidaAtualizaHashAsync(Usuario usuario, string hash)
        {
            var passwordHasher = new PasswordHasher<Usuario>();
            var status = passwordHasher.VerifyHashedPassword(usuario, hash, usuario.Senha);
            switch (status)
            {
                case PasswordVerificationResult.Failed:
                    return false;
                case PasswordVerificationResult.Success:
                    return true;
                case PasswordVerificationResult.SuccessRehashNeeded:
                    await Service.Atualiza(usuario);
                    return true;
                default:
                    throw new InvalidOperationException();
            }
        }
    }
}

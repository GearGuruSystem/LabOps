using GG_labOps_Domain.Entities;
using GG_LabOps_Services.Interfaces;
using Microsoft.AspNetCore.Identity;

namespace GG_LabOps_Services.Security
{
    public static class GeneratesHashPasswordUser
    {
        private static readonly IUserService _service;

        public static void ConverteSenhaEmHash(User user)
        {
            var passwordHasher = new PasswordHasher<User>();
            user.Senha = passwordHasher.HashPassword(user, user.Senha);
        }

        public static bool ValidUpdateHashAsync (User user, string hash)
        {
            var passwordHasher = new PasswordHasher<User>();
            var status = passwordHasher.VerifyHashedPassword(user, hash, user.Senha);
            switch (status)
            {
                case PasswordVerificationResult.Failed:
                    return false;
                case PasswordVerificationResult.Success:
                    return true;
                case PasswordVerificationResult.SuccessRehashNeeded:
                    _service.UpdateUser(user.Id, user);
                    return true;
                default:
                    throw new InvalidOperationException();
            }
        }
    }
}

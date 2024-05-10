using GG_labOps_Domain.Interfaces;
using System.ComponentModel.DataAnnotations;

namespace GG_labOps_Domain.Validations
{
    internal class KeyUserValidations : ValidationAttribute
    {
        private static readonly IUserService _service;

        private static async Task<bool> ValidKeyUserInDataBase(string keyUser)
        {
            var userverify = await _service.GetUser(keyUser);
            if (userverify != null)
            {
                return true;
            }
            return false;
        }

        protected override ValidationResult IsValid(object value, ValidationContext validationContext)
        {
            var user = ValidKeyUserInDataBase((string)value);
            if (user.Result.Equals(false))
            {
                return ValidationResult.Success;
            }
            return new ValidationResult(ErrorMessage);
        }
    }
}
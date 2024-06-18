using System.ComponentModel.DataAnnotations;

namespace LabOps.WebUI.Annotations
{
    public class CookiesVerification : ValidationAttribute
    {
        public override bool IsValid(object? value)
        {
            return base.IsValid(value);
        }
    }
}

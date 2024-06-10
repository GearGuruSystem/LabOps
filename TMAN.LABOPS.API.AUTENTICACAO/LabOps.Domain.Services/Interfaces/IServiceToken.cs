using Auth.LabOps.Domain.Entities;

namespace Auth.LabOps.Domain.Services.Interfaces
{
    public interface IServiceToken
    {
        string GerarToken(Usuario usuario);
    }
}

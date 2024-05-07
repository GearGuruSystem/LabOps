using GG_labOps_Domain.Entities;

namespace GG_labOps_Domain.Interfaces
{
    public interface IJWTService
    {
        string GenerateToken(User user);
    }
}
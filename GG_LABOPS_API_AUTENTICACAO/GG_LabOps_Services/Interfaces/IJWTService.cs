using GG_labOps_Domain.Entities;

namespace GG_LabOps_Services.Interfaces
{
    internal interface IJWTService
    {
        string GenerateToken(User user);
    }
}

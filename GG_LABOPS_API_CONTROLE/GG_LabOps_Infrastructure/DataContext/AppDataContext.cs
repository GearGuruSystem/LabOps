using GG_LabOps_Domain.Entities;
using Microsoft.EntityFrameworkCore;

namespace GG_LabOps_Infrastructure.DataContext
{
    public class AppDataContext : DbContext
    {
        public DbSet<Equipament> Equipaments { get; set; }
    }
}

using GG_LabOps_Application.DTOs;
using GG_LabOps_Domain.Entities;
using GG_LabOps_Domain.Interfaces;

namespace GG_LabOps_Application.Services
{
    public class EquipamentServices : IEquipamentService
    {
        private readonly IEquipamentRepository repository;

#pragma warning disable IDE0290 // Use primary constructor
        public EquipamentServices(IEquipamentRepository repository)
        {
            this.repository = repository;
        }

        public async Task<Equipament> RegisterEquipament(Equipament equipament)
        {
            var resp = await repository.CreateAsync(equipament);
            await Console.Out.WriteLineAsync("CADASTROU PORRA");
            return resp;
        }
    }
}

using AutoMapper;
using GG_LabOps_Domain.DTOs;
using GG_LabOps_Domain.Entities;
using GG_LabOps_Domain.Interfaces;

namespace GG_LabOps_Application.Services
{
    public class EquipamentServices : IEquipamentService
    {
        private readonly IEquipamentRepository repository;
        private readonly IMapper mapper;

#pragma warning disable IDE0290 // Use primary constructor
        public EquipamentServices(IEquipamentRepository repository, IMapper mapper)
        {
            this.repository = repository;
            this.mapper = mapper;
        }

        public async Task<IEnumerable<ViewEquipamentDTO>> GetEquipamentsAsync()
        {
            var response = await repository.GetAllAsync();
            await Console.Out.WriteLineAsync("FEZ A CONSULTA");
            return mapper.Map<IEnumerable<ViewEquipamentDTO>>(response);
            
        }

        public async Task<Equipament> RegisterEquipament(Equipament equipament)
        {
            var response = await repository.CreateAsync(equipament);
            await Console.Out.WriteLineAsync("CADASTROU PORRA");
            return response;
        }
    }
}

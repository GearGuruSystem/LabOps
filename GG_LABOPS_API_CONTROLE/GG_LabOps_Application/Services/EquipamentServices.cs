using AutoMapper;
using GG_LabOps_Application.Interfaces;
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
            return response;
        }

        public async Task<ViewEquipamentDTO> GetEquipamentsAsync(int id)
        {
            var response = await repository.GetByIdAsync(id);
            return response;
        }

        public Task RegisterEquipament(CreateEquipamentDTO equipamentDTO)
        {
            repository.CreateAsync(equipamentDTO);
            return Task.CompletedTask;
        }

        public async Task<UpdateEquipamentDTO> UpdateEquipament(int id, UpdateEquipamentDTO equipament)
        {
            var response = await repository.UpdateAsync(id, equipament);
            return response;
        }
    }
}

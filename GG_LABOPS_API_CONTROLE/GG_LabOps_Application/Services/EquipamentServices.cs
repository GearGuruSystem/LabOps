using GG_LabOps_Application.Interfaces;
using GG_LabOps_Domain.DTOs;
using GG_LabOps_Domain.Exceptions;
using GG_LabOps_Domain.Interfaces;

namespace GG_LabOps_Application.Services
{
    public class EquipamentServices : IEquipamentService
    {
        private readonly IEquipamentRepository _repository;

#pragma warning disable IDE0290 // Use primary constructor
        public EquipamentServices(IEquipamentRepository repository)
        {
            _repository = repository;
        }

        public async Task<IEnumerable<ViewEquipamentDTO>> GetEquipamentsAsync()
        {
            var response = await _repository.GetAllAsync();
            return response;
        }

        public async Task<ViewEquipamentDTO> GetEquipamentsAsync(int id)
        {
            var response = await _repository.GetByIdAsync(id);
            return response;
        }

        public async Task<CreateEquipamentDTO> RegisterEquipament(CreateEquipamentDTO equipamentDTO)
        {
            var response = await _repository.CreateAsync(equipamentDTO);
            return response;
        }

        public async Task<UpdateEquipamentDTO> UpdateEquipament(int id, UpdateEquipamentDTO equipament)
        {
            var response = await _repository.UpdateAsync(id, equipament);
            return response;
        }

        public async Task<DisableEquipamentDTO> DisableEquipament(int id)
        {
            var response = await _repository.DisableById(id);
            if(response == true)
            {
                return new DisableEquipamentDTO
                {
                    Id = id
                };
            }
            throw new ErroGenericoException();
        }
    }
}

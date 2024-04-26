using AutoMapper;
using GG_LabOps_Application.Interfaces;
using GG_LabOps_Domain.DTOs;
using GG_LabOps_Domain.Entities;
using GG_LabOps_Domain.Exceptions;
using GG_LabOps_Domain.Interfaces;

namespace GG_LabOps_Application.Services
{
    public class EquipamentServices : IEquipamentService
    {
        private readonly IEquipamentRepository _repository;
        private readonly IMapper _mapper;

#pragma warning disable IDE0290 // Use primary constructor
        public EquipamentServices(IEquipamentRepository repository, IMapper mapper)
        {
            _repository = repository;
            _mapper = mapper;
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

        public async Task<ViewEquipamentDTO> RegisterEquipament(CreateEquipamentDTO equipamentDTO)
        {
            var equipament = ConvertInEquipamentEntity(equipamentDTO);
            await _repository.CreateAsync(equipament);
            return ConvertInDto(equipament);
        }

        public async Task<ViewEquipamentDTO> UpdateEquipament(int id, UpdateEquipamentDTO equipamentDTO)
        {
            var equipament = ConvertInEquipamentEntity(equipamentDTO);
            await _repository.UpdateAsync(id, equipament);
            return ConvertInDto(equipament);
        }

        public async Task<DisableEquipamentDTO> DisableEquipament(int id)
        {
            var response = await _repository.DisableById(id);
            if(response.Equals(true))
            {
                return new DisableEquipamentDTO
                {
                    Id = id
                };
            }
            throw new ErroGenericoException();
        }

        private Equipament ConvertInEquipamentEntity(object DTO)
        {
            return _mapper.Map<Equipament>(DTO);
        }

        private ViewEquipamentDTO ConvertInDto(object entidade)
        {
            return _mapper.Map<ViewEquipamentDTO>(entidade); 
        }
    }
}

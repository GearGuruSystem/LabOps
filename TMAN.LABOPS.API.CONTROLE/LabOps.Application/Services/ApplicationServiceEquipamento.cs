using AutoMapper;
using LabOps.Application.DTO.DTO.Equipamentos;
using LabOps.Application.Interfaces;
using LabOps.Domain.Core.Services;
using LabOps.Domain.Entities;


#pragma warning disable IDE0290 // Use primary constructor

namespace LabOps.Application.Service
{
    public class ApplicationServiceEquipamento : IApplicationServiceEquipamento
    {
        private readonly IServiceEquipamento _serviceEquipamento;
        private readonly IMapper _mapper;

        public ApplicationServiceEquipamento(IServiceEquipamento serviceEquipamento, IMapper mapper)
        {
            this._serviceEquipamento = serviceEquipamento;
            _mapper = mapper;
        }

        public async Task<IEnumerable<BuscarTodosEquipamentos>> BuscaTodosEquipamentos()
        {
            var data = await _serviceEquipamento.BuscarTodos();
            if (data.Any())
            {
                return data;
            }
            throw new Exception();
        }

        public async Task<IEnumerable<EquipamentoDTO>> BuscaTodosPorPagina(int pageNumber, int pageSize)
        {
            var objEquipamento = await _serviceEquipamento.BuscarTodosPorPagina(pageNumber, pageSize);
            return _mapper.Map<IEnumerable<EquipamentoDTO>>(objEquipamento);
        }

        public async Task<EquipamentoDTO> BuscaPeloId(int id)
        {
            var objEquipamento = await _serviceEquipamento.BuscarPorId(id);
            return _mapper.Map<EquipamentoDTO>(objEquipamento);
        }

        public void RegistraEquipamento(CriarNovo obj)
        {
            var objEquipamento = _mapper.Map<Equipamento>(obj);
            _serviceEquipamento.Adicionar(objEquipamento);
        }

        public void AtualizaEquipamento(EquipamentoDTO obj)
        {
            var objEquipamento = _mapper.Map<Equipamento>(obj);
            _serviceEquipamento.Atualizar(objEquipamento);
        }

        public void RemoveEquipamento(EquipamentoDTO obj)
        {
            var objEquipamento = _mapper.Map<Equipamento>(obj);
            _serviceEquipamento.Remover(objEquipamento);
        }
    }
}
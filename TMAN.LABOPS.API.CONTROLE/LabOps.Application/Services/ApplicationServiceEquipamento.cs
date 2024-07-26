using AutoMapper;
using LabOps.Application.DTO.DTO.Equipamentos;
using LabOps.Application.DTO.Response;
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

        public async Task<IEnumerable<BuscarEquipamentos>> BuscaTodosEquipamentos()
        {
            var data = await _serviceEquipamento.BuscarTodos();
            if (data.Any())
            {
                return data;
            }
            throw new Exception();
        }

        public async Task<ResponsePaged<IEnumerable<EquipamentoDTO>>> BuscaTodosPorPagina(int pageNumber, int pageSize)
        {
            var objEquipamento = _mapper.Map<IEnumerable<EquipamentoDTO>>(await _serviceEquipamento.BuscarTodosPorPagina(pageNumber, pageSize));
            var responsePaged = new ResponsePaged<IEnumerable<EquipamentoDTO>>(objEquipamento, objEquipamento.Count());
            if (responsePaged.Sucess == true)
            {
                return responsePaged;
            }
            return new ResponsePaged<IEnumerable<EquipamentoDTO>>(false, "Houve um erro.");
        }

        public async Task<BuscarEquipamentos> BuscaPeloId(int id)
        {
            var data = await _serviceEquipamento.BuscarPorId(id);
            if (data.Id > 0)
            {
                return data;
            }
            throw new Exception();
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

        public async Task<EquipamentoDTO> BuscarEquipamentoRetornoId(int id)
        {
            var data = await _serviceEquipamento.BuscarComRetornoId(id);
            if (data.Id < 0)
            {
                throw new Exception();
            }
            var map = _mapper.Map<EquipamentoDTO>(data);
            return map;
        }
    }
}
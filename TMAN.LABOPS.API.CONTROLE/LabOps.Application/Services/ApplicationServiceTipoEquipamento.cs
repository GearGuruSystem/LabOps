using LabOps.Application.DTO.DTO;
using LabOps.Application.Interfaces;
using LabOps.Domain.Core.Services;
using LabOps.Infrastructure.CrossCutting.Adapter.Interfaces;

#pragma warning disable IDE0290 // Use primary constructor

namespace LabOps.Application.Service
{
    public class ApplicationServiceTipoEquipamento : IApplicationServiceTipoEquipamento
    {
        private readonly IServiceTipoEquipamento serviceTipoEquipamento;
        private readonly IMapperTipoEquipamento mapper;

        public ApplicationServiceTipoEquipamento(IServiceTipoEquipamento serviceTipoEquipamento, IMapperTipoEquipamento mapper)
        {
            this.serviceTipoEquipamento = serviceTipoEquipamento;
            this.mapper = mapper;
        }

        public async Task<IEnumerable<TipoEquipamentoDTO>> BuscarTodosTiposDeEquipamentos(int pageNumber, int pageSize)
        {
            var tipoEquipamentos = await serviceTipoEquipamento.BuscarTodos();
            return mapper.MapperListaTipoEquipamentos(tipoEquipamentos);
        }
    }
}
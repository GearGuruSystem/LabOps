using AutoMapper;
using LabOps.Application.DTO.DTO.Fabricantes;
using LabOps.Application.Interfaces;
using LabOps.Domain.Core.Services;
using LabOps.Domain.Entities;

#pragma warning disable IDE0290 // Use primary constructor

namespace LabOps.Application.Service
{
    public class ApplicationServiceFabricante : IApplicationServiceFabricante
    {
        private readonly IServiceFabricante _serviceFabricante;
        private readonly IMapper _mapper;

        public ApplicationServiceFabricante(IServiceFabricante serviceFabricante, IMapper mapper)
        {
            _serviceFabricante = serviceFabricante;
            _mapper = mapper;
        }

        public async Task<IEnumerable<FabricanteDTO>> BuscaTodosFabricantes()
        {
            var objFabricante = await _serviceFabricante.BuscarTodos();
            return _mapper.Map<IEnumerable<FabricanteDTO>>(objFabricante);
        }

        public async Task<FabricanteDTO> BuscaFabricantesPeloId(int id)
        {
            var objFabricante = await _serviceFabricante.BuscarPorId(id);
            return _mapper.Map<FabricanteDTO>(objFabricante);
        }

        public void RegistraFabricante(CriarNovoFabricanteDTO obj)
        {
            var objFabricante = _mapper.Map<Fabricante>(obj);
            _serviceFabricante.Adicionar(objFabricante);
        }

        public void AtualizaFabricante(AtualizarFabricanteDTO obj)
        {
            var objFabricante = _mapper.Map<Fabricante>(obj);
            _serviceFabricante.Atualizar(objFabricante);
        }

        public void RemoveFabricante(FabricanteDTO obj)
        {
            var objFabricante = _mapper.Map<Fabricante>(obj);
            _serviceFabricante.Remover(objFabricante);
        }
    }
}
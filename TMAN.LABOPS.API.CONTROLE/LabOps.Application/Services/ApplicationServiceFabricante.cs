﻿using LabOps.Application.DTO.DTO.Fabricantes;
using LabOps.Application.Interfaces;
using LabOps.Domain.Core.Services;
using LabOps.Infrastructure.CrossCutting.Adapter.Interfaces;

#pragma warning disable IDE0290 // Use primary constructor

namespace LabOps.Application.Service
{
    public class ApplicationServiceFabricante : IApplicationServiceFabricante
    {
        private readonly IServiceFabricante serviceFabricante;
        private readonly IMapperFabricante mapperFabricante;

        public ApplicationServiceFabricante(IServiceFabricante serviceFabricante, IMapperFabricante mapperFabricante)
        {
            this.serviceFabricante = serviceFabricante;
            this.mapperFabricante = mapperFabricante;
        }

        public async Task<IEnumerable<FabricanteDTO>> BuscaTodosFabricantes()
        {
            var objFabricante = await serviceFabricante.BuscarTodos();
            return mapperFabricante.MapperListaFabricantes(objFabricante);
        }

        public async Task<FabricanteDTO> BuscaFabricantesPeloId(int id)
        {
            var objFabricante = await serviceFabricante.BuscarPorId(id);
            return mapperFabricante.MapperToDTO(objFabricante);
        }

        public void RegistraFabricante(CriarNovoFabricanteDTO obj)
        {
            var objFabricante = mapperFabricante.MapperToEntity(obj);
            serviceFabricante.Adicionar(objFabricante);
        }

        public void AtualizaFabricante(AtualizarFabricanteDTO obj)
        {
            var objFabricante = mapperFabricante.MapperToEntity(obj);
            serviceFabricante.Atualizar(objFabricante);
        }

        public void RemoveFabricante(FabricanteDTO obj)
        {
            var objFabricante = mapperFabricante.MapperToEntity(obj);
            serviceFabricante.Remover(objFabricante);
        }
    }
}
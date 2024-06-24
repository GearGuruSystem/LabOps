using LabOps.Application.DTO.DTO.Fabricantes;
using LabOps.Domain.Entities;
using LabOps.Infrastructure.CrossCutting.Adapter.Interfaces;

#pragma warning disable IDE0090 // Use 'new(...)'
#pragma warning disable IDE0028 // Simplify collection initialization

namespace LabOps.Infrastructure.CrossCutting.Adapter.Map
{
    public class MapperFabricante : IMapperFabricante
    {
        #region Properties
        private readonly List<FabricanteDTO> FabricanteDTOs = new List<FabricanteDTO>();
        #endregion

        public IEnumerable<FabricanteDTO> MapperListaFabricantes(IEnumerable<Fabricante> fabricantes)
        {
            foreach (var item in fabricantes)
            {
                FabricanteDTO fabricanteDTO = new FabricanteDTO(
                    item.IDFabricante,
                    item.Nome,
                    item.UsuarioAtualizacao,
                    item.AtualizadoEm);
                FabricanteDTOs.Add(fabricanteDTO);
            }
            return FabricanteDTOs;
        }

        public FabricanteDTO MapperToDTO(Fabricante fabricante)
        {
            FabricanteDTO fabricanteDTO = new FabricanteDTO(
                fabricante.IDFabricante,
                fabricante.Nome,
                fabricante.UsuarioAtualizacao,
                fabricante.AtualizadoEm);
            return fabricanteDTO;
        }

        public FabricanteDTO MapperToDTO(CriarNovoFabricanteDTO cFabricanteDTO)
        {
            FabricanteDTO fabricanteDTO = new FabricanteDTO(
                 cFabricanteDTO.Nome,
                 cFabricanteDTO.UsuarioAtualizacao,
                 cFabricanteDTO.AtualizadoEm);
            return fabricanteDTO;
        }

        public Fabricante MapperToEntity(FabricanteDTO fabricanteDTO)
        {
            Fabricante fabricante = new Fabricante(
                fabricanteDTO.IDFabricante,
                fabricanteDTO.Nome,
                fabricanteDTO.UsuarioAtualizacao);
            return fabricante;
        }

        public Fabricante MapperToEntity(CriarNovoFabricanteDTO cFabricanteDTO)
        {
            Fabricante fabricante = new Fabricante(
                cFabricanteDTO.Nome,
                cFabricanteDTO.UsuarioAtualizacao);
            return fabricante;
        }

        public Fabricante MapperToEntity(AtualizarFabricanteDTO aFabricanteDTO)
        {
            Fabricante fabricante = new Fabricante(
                aFabricanteDTO.IDFabricante,
                aFabricanteDTO.Nome,
                aFabricanteDTO.UsuarioAtualizacao);
            return fabricante;
        }
    }
}
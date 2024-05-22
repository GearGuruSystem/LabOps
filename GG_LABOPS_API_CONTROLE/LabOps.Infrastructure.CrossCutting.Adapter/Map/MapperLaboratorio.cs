using LabOps.Application.DTO.DTO;
using LabOps.Domain.Entities;
using LabOps.Infrastructure.CrossCutting.Adapter.Interfaces;

#pragma warning disable IDE0090 // Use 'new(...)'
#pragma warning disable IDE0028 // Simplify collection initialization

namespace LabOps.Infrastructure.CrossCutting.Adapter.Map
{
    public class MapperLaboratorio : IMapperLaboratorio
    {
        private readonly List<LaboratorioDTO> laboratorioDTOs = new List<LaboratorioDTO>();

        public IEnumerable<LaboratorioDTO> MapperListaLaboratorios(IEnumerable<Laboratorio> laboratorio)
        {
            foreach (var item in laboratorio)
            {
                LaboratorioDTO laboratorioDTO = new LaboratorioDTO
                {
                    IDLaboratorio = item.IDLaboratorio,
                    Nome = item.Nome,
                    IDUsuarioResponsavel = item.IDUsuarioResponsavel,
                    ChaveResponsavel = item.ChaveResponsavel,
                    UsuarioAtualizacao = item.UsuarioAtualizacao,
                    AtualizadoEm = item.AtualizadoEm
                };
                laboratorioDTOs.Add(laboratorioDTO);
            }
            return laboratorioDTOs;
        }

        public LaboratorioDTO MapperToDTO(Laboratorio laboratorio)
        {
            LaboratorioDTO laboratorioDTO = new LaboratorioDTO
            {
                IDLaboratorio = laboratorio.IDLaboratorio,
                Nome = laboratorio.Nome,
                IDUsuarioResponsavel = laboratorio.IDUsuarioResponsavel,
                ChaveResponsavel = laboratorio.ChaveResponsavel,
                UsuarioAtualizacao = laboratorio.UsuarioAtualizacao,
                AtualizadoEm = laboratorio.AtualizadoEm
            };
            return laboratorioDTO;
        }

        public Laboratorio MapperToEntity(LaboratorioDTO laboratorioDTO)
        {
            Laboratorio laboratorio = new Laboratorio
            {
                IDLaboratorio = laboratorioDTO.IDLaboratorio,
                Nome = laboratorioDTO.Nome,
                IDUsuarioResponsavel = laboratorioDTO.IDUsuarioResponsavel,
                ChaveResponsavel = laboratorioDTO.ChaveResponsavel,
                UsuarioAtualizacao = laboratorioDTO.UsuarioAtualizacao,
                AtualizadoEm = laboratorioDTO.AtualizadoEm
            };
            return laboratorio;
        }
    }
}

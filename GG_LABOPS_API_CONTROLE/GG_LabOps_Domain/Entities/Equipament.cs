using System.ComponentModel.DataAnnotations;
#pragma warning disable IDE0290 // Use primary constructor

namespace GG_LabOps_Domain.Entities
{
    public class Equipament : BaseEntity
    {
        public int Id { get; set; }

        [StringLength(120)]
        public string? Nome { get; set; }

        public Situation Situacao { get; private set; }
        public int SituacaoId { get; set; }

        public TypeEquipament TipoEquipamento { get; private set; }
        public int TipoEquipamentoId { get; set; }

        public Manufacturer Fabricante { get; private set; }
        public int FabricanteId { get; set; }

        public Laboratory Laboratorio { get; private set; }
        public int? LaboratorioId { get; set;}

        public Equipament(string? nome, Situation situacao, int situacaoId, TypeEquipament tipoEquipamento,
            Manufacturer fabricante, Laboratory laboratorio)
        {
            Nome = nome;
            Situacao = situacao;
            SituacaoId = situacaoId;
            TipoEquipamento = tipoEquipamento;
            Fabricante = fabricante;
            Laboratorio = laboratorio;
        }
    }
}

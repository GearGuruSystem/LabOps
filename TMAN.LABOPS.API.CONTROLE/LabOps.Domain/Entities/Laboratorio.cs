using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace LabOps.Domain.Entities
{
    public class Laboratorio
    {
        [Key, Required, Column("Cl_IdLaboratorio")]
        public long Id { get; set; }
        /*-------------------------------------------------------------------------------------------------*/
        [Required, StringLength(100), Column("Cl_Nome")]
        public string Nome { get; set; }
        /*-------------------------------------------------------------------------------------------------*/
        [Required, StringLength(40), Column("Cl_UsuarioResponsavel")]
        public string? UsuarioResponsavel { get; set; }
        /*-------------------------------------------------------------------------------------------------*/
        [Required, StringLength(20), Column("Cl_ChaveDoResponsavel")]
        public string ChaveResponsavel { get; set; }
        /*-------------------------------------------------------------------------------------------------*/
        [Required, StringLength(20), Column("Cl_UsuarioAtualizacao")]
        public string UsuarioAtualizacao { get; set; }
        /*-------------------------------------------------------------------------------------------------*/
        [Required, Column("Cl_AtualizadoEm")]
        public DateTime? AtualizadoEm { get; set; }
        /*-------------------------------------------------------------------------------------------------*/
        public ICollection<Equipamento> Equipamentos { get; set; }
        /*-------------------------------------------------------------------------------------------------*/
    }
}
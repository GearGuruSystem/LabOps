using System.ComponentModel.DataAnnotations;

namespace LabOps.Application.DTO.DTO.Equipamentos
{
    public class CriarNovo : ICloneable
    {
        public int IDEquipamento { get; set; }

        [Required(ErrorMessage = "Informe um nome")]
        [MaxLength(120, ErrorMessage = "Nome maximo de até 120 caracteres")]
        public string Nome { get; set; }

        [Required(ErrorMessage = "Informe o ID da Situação.")]
        public int IDSituacao { get; set; }

        [Required(ErrorMessage = "Informe o ID do TipoEquipamento.")]
        public int IDTipoEquipamento { get; set; }

        [Required(ErrorMessage = "Informe o ID do Fabricante.")]
        public int IDFabricante { get; set; }

        [Required(ErrorMessage = "Informe o ID do Laboratorio")]
        public int? IDLaboratorio { get; set; }

        [Required(ErrorMessage = "Informe o ID do usuário")]
        public string UsuarioInsercao { get; set; }
        public string? Hostname { get; set; }
        public string? Inventario { get; set; }
        public string SerialNumber { get; set; }
        public DateTime? AtualizadoEm { get; set; }

        #region Metodos Clone

        public object Clone()
        {
            var equipamento = (CriarNovo)MemberwiseClone();
            return equipamento;
        }

        public CriarNovo CloneTipado()
        {
            return (CriarNovo)Clone();
        }

        #endregion Metodos Clone
    }
}
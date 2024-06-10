using System.ComponentModel.DataAnnotations;

namespace LabOps.Application.DTO.DTO.Equipamentos
{
    public class CriarNovo : ICloneable
    {
        public int IDEquipamento { get; private set; }

        [Required(ErrorMessage = "Informe um nome")]
        [MaxLength(120, ErrorMessage = "Nome maximo de até 120 caracteres")]
        public string Nome { get; private set; }

        [Required(ErrorMessage = "Informe o ID da Situação.")]
        public int IDSituacao { get; private set; }

        [Required(ErrorMessage = "Informe o ID do TipoEquipamento.")]
        public int IDTipoEquipamento { get; private set; }

        [Required(ErrorMessage = "Informe o ID do Fabricante.")]
        public int IDFabricante { get; private set; }

        [Required(ErrorMessage = "Informe o ID do Laboratorio")]
        public int? IDLaboratorio { get; private set; }

        [Required(ErrorMessage = "Informe o ID do usuário")]
        public int UsuarioInsercao { get; private set; }

        public DateTime? AtualizadoEm { get; private set; } = DateTime.Now;

        #region Contrutor vazio

        public CriarNovo()
        {
        }

        #endregion Contrutor vazio

        #region Construtor Completo

        public CriarNovo(string nome, int iDSituacao, int iDTipoEquipamento, int iDFabricante, int? iDLaboratorio,
            int usuarioInsercao, DateTime? atualizadoEm)
        {
            Nome = nome;
            IDSituacao = iDSituacao;
            IDTipoEquipamento = iDTipoEquipamento;
            IDFabricante = iDFabricante;
            IDLaboratorio = iDLaboratorio;
            UsuarioInsercao = usuarioInsercao;
            AtualizadoEm = atualizadoEm;
        }

        #endregion Construtor Completo

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
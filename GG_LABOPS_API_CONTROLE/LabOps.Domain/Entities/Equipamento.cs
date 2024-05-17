using System.ComponentModel.DataAnnotations;

namespace LabOps.Domain.Entities
{
    public class Equipamento
    {
        public int IDEquipamento { get; set; }

        [StringLength(120)]
        public string Nome { get; private set; }

        public int IDSituacao { get; private set; }
        public int IDTipoEquipamento { get; private set; }
        public int IDFabricante { get; private set; }
        public int? IDLaboratorio { get; private set; }
        public int UsuarioInsercao { get; private set; }
        public DateTime? AtualizadoEm { get; private set; }

        #region Navegação de Objetos
        public Situacao Situacao { get; set; }
        public TipoEquipamento TipoEquipamento { get; set; }
        public Fabricante Fabricante { get; set; }
        public Laboratorio Laboratorio { get; set; }
        public ICollection<EquipamentoCaracteristica> EquipamentoCaracteristicas { get; set; }
        #endregion

        #region Construtor vazio
        public Equipamento()
        {
        }
        #endregion

        #region Construtor completo
        public Equipamento(string nome, int iDSituacao, int iDTipoEquipamento, int iDFabricante, int? iDLaboratorio, 
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
        #endregion

        public Equipamento(string Nome)
        {
            if (Nome != "")
            {
                this.Nome = Nome;
            }
        }

        public void AlteraNome(string NovoNome)
        {
            if (Nome != "")
            {
                Nome = NovoNome;
            }
        }
    }
}

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
        public string UsuarioInsercao { get; private set; }
        public DateTime? AtualizadoEm { get; private set; }

        #region Navegação de Objetos

        public Situacao Situacao { get; set; }
        public TipoEquipamento TipoEquipamento { get; set; }
        public Fabricante Fabricante { get; set; }
        public Laboratorio Laboratorio { get; set; }
        public ICollection<EquipamentoCaracteristica> EquipamentoCaracteristicas { get; set; }

        #endregion Navegação de Objetos

        public Equipamento()
        {
        }

        public Equipamento(string nome, int idSituacao, int idTipoEquipamento, int idFabricante, int? idLaboratorio,
            string usuarioInsercao)
        {
            AdicionarEquipamento(nome, idSituacao, idTipoEquipamento, idFabricante, idLaboratorio, usuarioInsercao);
        }

        private void AdicionarEquipamento(string nome, int iDSituacao, int iDTipoEquipamento, int iDFabricante, int? iDLaboratorio,
            string usuarioInsercao)
        {
            Nome = nome;
            IDSituacao = iDSituacao;
            IDTipoEquipamento = iDTipoEquipamento;
            IDFabricante = iDFabricante;
            IDLaboratorio = iDLaboratorio;
            UsuarioInsercao = usuarioInsercao;
            AtualizadoEm = DateTime.Now;
        }
    }
}
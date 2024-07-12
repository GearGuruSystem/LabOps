using System.ComponentModel;

namespace LabOps.WebUI.Models
{
    public class EquipamentosModel
    {
        public int Id { get; set; }

        [DisplayName("Nome cadastrado")]
        public string Nome { get; set; }

        [DisplayName("Inventario")]
        public string Inventario { get; set; }

        [DisplayName("Hostname")]
        public string Hostname { get; set; }

        [DisplayName("Numero de serie")]
        public string SerialNumber { get; set; }

        [DisplayName("Feito cadastro")]
        public string UsuarioInsercao { get; set; }

        [DisplayName("Ultima Atualização")]
        public DateTime AtualizadoEm { get; set; }

        [DisplayName("Situacao")]
        public string SituacaoDescricao { get; set; }

        [DisplayName("Tipo de equipamento")]
        public string TipoEquipamentoDescricao { get; set; }

        [DisplayName("Fabricante")]
        public string FabricanteNome { get; set; }
    }
}
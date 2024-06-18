using System.ComponentModel.DataAnnotations;

namespace LabOps.WebUI.Models
{
    public class EquipamentoModel
    {
        public int IDEquipamento { get; set; }

        [StringLength(120)]
        public string Nome { get; set; }

        public int IDSituacao { get; set; }
        public int IDTipoEquipamento { get; set; }
        public int IDFabricante { get; set; }
        public int? IDLaboratorio { get; set; }
        public int UsuarioInsercao { get; set; }
        public DateTime? AtualizadoEm { get; set; }
    }
}

using System.ComponentModel.DataAnnotations;

namespace GG_LabOps_WebUI.Models
{
    public class EquipamentoModel
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
    }
}

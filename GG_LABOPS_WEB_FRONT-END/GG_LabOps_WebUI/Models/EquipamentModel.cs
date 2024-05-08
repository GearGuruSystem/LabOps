using System.ComponentModel.DataAnnotations;

namespace GG_LabOps_WebUI.Models
{
    public class EquipamentModel
    {
        public long Id { get; set; }
        public string? Inventario { get; set; }
        public string? Hostname { get; set; }
        public string NumeroSerie { get; set; }
        public bool Ativa { get; set; }
        public int MarcaId { get; set; }
        public int TipoId { get; set; }
        public int ModeloId { get; set; }
        public DateTime DataRegistro { get; set; }
    }
}

namespace GG_LabOps_Domain.DTOs
{
    public class CreateEquipamentDTO
    {
        public string? Inventario { get; set; }
        public string? Hostname { get; set; }
        public string NumeroSerie { get; set; }
        public bool Ativa { get; set; }
        public int MarcaId { get; set; }
        public int TipoId { get; set; }
        public int ModeloId { get; set; }
    }
}

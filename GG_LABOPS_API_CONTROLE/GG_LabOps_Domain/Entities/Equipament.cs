namespace GG_LabOps_Domain.Entities
{
    public class Equipament : BaseEntity
    {
        public long Id { get; set; }
        public int LaboratoryId { get; set; }
        public string? Inventario { get; set; }
        public string? Hostname { get; set; }
        public string NumeroSerie { get; set; }
        public bool Ativa { get; set; }
        public DateTime DataRegistro { get; set; }
        public int IdMarca { get; set; }
        public int IdModelo { get; set; }
        public int IdTipo { get; set; }
    }
}

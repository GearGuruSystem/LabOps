namespace GG_LabOps_Domain.DTOs
{
    public class ViewEquipamentDTO
    {
        public long Id { get; set; }
        public string? Inventario { get; set; }
        public string? Hostname { get; set; }
        public string NumeroSerie { get; set; }
        public bool Ativa { get; set; }
        public DateTime DataRegistro { get; set; }
        public string MarcaNome { get; set; }
        public string ModeloNome { get; set; }
        public string TipoNome { get; set; }
        public DateTime UltimaAtualizacao { get; set; }
    }
}

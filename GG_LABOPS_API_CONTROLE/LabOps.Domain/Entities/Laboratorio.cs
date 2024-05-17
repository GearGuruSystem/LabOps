namespace LabOps.Domain.Entities
{
    public class Laboratorio
    {
        public int IDLaboratorio { get; set; }
        public string Nome { get; set; }
        public int? IDUsuarioResponsavel { get; set; }
        public string ChaveResponsavel { get; set; }
        public int UsuarioAtualizacao { get; set; }
        public DateTime? AtualizadoEm { get; set; }

        #region Navegação de Objetos
        public ICollection<Equipamento> Equipamentos { get; set; }
        #endregion
    }
}

namespace Auth.LabOps.Domain.Entities
{
    public class Aplicacao
    {
        public int IDAplicacao { get; set; }
        public string Descricao { get; set; }

        public ICollection<GrupoUsuarioXAplicacoes> GrupoUsuarioXAplicacoes { get; set; }
    }
}

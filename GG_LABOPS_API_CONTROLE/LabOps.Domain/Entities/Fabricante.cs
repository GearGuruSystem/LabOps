namespace LabOps.Domain.Entities
{
    public class Fabricante
    {
        public int IDFabricante { get; private set; }
        public string Nome { get; private set; }
        public int UsuarioAtualizacao { get; private set; }
        public DateTime? AtualizadoEm { get; private set; }

        #region Navegação de Objetos
        public ICollection<Equipamento> Equipamentos { get; set; }
        #endregion

        public Fabricante()
        {
        }

        public Fabricante(int iDFabricante, string nome, int usuarioAtualizacao, 
            DateTime? atualizadoEm)
        {
            IDFabricante = iDFabricante;
            Nome = nome;
            UsuarioAtualizacao = usuarioAtualizacao;
            AtualizadoEm = atualizadoEm;
        }
    }
}

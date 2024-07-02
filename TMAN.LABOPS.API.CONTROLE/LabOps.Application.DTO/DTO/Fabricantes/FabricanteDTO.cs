namespace LabOps.Application.DTO.DTO.Fabricantes
{
    public class FabricanteDTO : ICloneable
    {
        public int IDFabricante { get; set; }
        public string Nome { get; set; }
        public string UsuarioAtualizacao { get; set; }
        public DateTime? AtualizadoEm { get; set; }

        public FabricanteDTO()
        {
        }

        public FabricanteDTO(string nome, string usuarioAtualizacao, DateTime? atualizadoEm)
        {
            Nome = nome;
            UsuarioAtualizacao = usuarioAtualizacao;
            AtualizadoEm = atualizadoEm;
        }

        public FabricanteDTO(int iDFabricante, string nome, string usuarioAtualizacao, DateTime? atualizadoEm)
        {
            IDFabricante = iDFabricante;
            Nome = nome;
            UsuarioAtualizacao = usuarioAtualizacao;
            AtualizadoEm = atualizadoEm;
        }

        #region metodos clone

        public object Clone()
        {
            var fabricante = (FabricanteDTO)MemberwiseClone();
            return fabricante;
        }

        public FabricanteDTO CloneTipado()
        {
            return (FabricanteDTO)Clone();
        }

        #endregion metodos clone
    }
}
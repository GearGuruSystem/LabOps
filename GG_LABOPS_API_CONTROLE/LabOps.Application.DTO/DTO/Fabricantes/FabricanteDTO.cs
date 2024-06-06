namespace LabOps.Application.DTO.DTO.Fabricantes
{
    public class FabricanteDTO : ICloneable
    {

        public int IDFabricante { get; private set; }
        public string Nome { get; private set; }
        public int UsuarioAtualizacao { get; private set; }
        public DateTime? AtualizadoEm { get; private set; }

        public FabricanteDTO()
        {
        }

        public FabricanteDTO(int iDFabricante, string nome, int usuarioAtualizacao, DateTime? atualizadoEm)
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
        #endregion
    }
}

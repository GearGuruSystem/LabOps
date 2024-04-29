namespace GG_labOps_Domain.Exceptions
{
    public class BancoDeDadosExceptions : Exception
    {
        public string Information { get; private set; }

        public BancoDeDadosExceptions() : base("Ocorreu um problema")
        {

        }

        public BancoDeDadosExceptions(string Information)
        {
            this.Information = Information;
        }
    }
}

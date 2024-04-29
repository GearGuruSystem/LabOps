namespace GG_labOps_Domain.Exceptions
{
    public class ErroGenericoExceptions : Exception
    {
        public string Information { get; private set; }

        public ErroGenericoExceptions() : base("Ocorreu um problema")
        {

        }

        public ErroGenericoExceptions(string Information)
        {
            this.Information = Information;
        }
    }
}

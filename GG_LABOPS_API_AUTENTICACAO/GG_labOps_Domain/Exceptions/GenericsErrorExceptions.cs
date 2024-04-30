namespace GG_labOps_Domain.Exceptions
{
    public class GenericsErrorExceptions : Exception
    {
        public string Information { get; private set; }

        public GenericsErrorExceptions() : base("Ocorreu um problema")
        {
        }

        public GenericsErrorExceptions(string Information)
        {
            this.Information = Information;
        }
    }
}

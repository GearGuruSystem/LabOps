namespace GG_labOps_Domain.Exceptions
{
    public class DataBaseExceptions : Exception
    {
        public string Information { get; private set; }

        public DataBaseExceptions() : base("Ocorreu um problema")
        {
        }

        public DataBaseExceptions(string Information)
        {
            this.Information = Information;
        }
    }
}

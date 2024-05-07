namespace GG_labOps_Domain.Exceptions
{
    public class DataBaseExceptions : Exception
    {
        public string Information { get; private set; }

        public DataBaseExceptions() : base("Ocorreu um problema ao consultar o banco de dados")
        {
        }

        public DataBaseExceptions(string Information)
        {
            this.Information = Information;
        }
    }
}
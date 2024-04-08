namespace GG_LabOps_Domain.Exceptions
{
    public class ConsultaNoBancoException : Exception
    {
        public ConsultaNoBancoException() : base("Erro ao consultar o banco de dados")
        { }
    }
}

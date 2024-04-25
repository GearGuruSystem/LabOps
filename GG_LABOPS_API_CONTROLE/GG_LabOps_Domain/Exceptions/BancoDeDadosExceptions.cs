namespace GG_LabOps_Domain.Exceptions
{
    public class BancoDeDadosExceptions : Exception
    {
        public string ErroMsg {  get; set; }

        public BancoDeDadosExceptions() : base("Ocorreu um erro relacionado ao Banco de dados")
        { }
        public BancoDeDadosExceptions(string erroMsg) : base("Ocorreu um erro relacionado ao Banco de dados")
        {
            ErroMsg = erroMsg;
        } 
    }
}

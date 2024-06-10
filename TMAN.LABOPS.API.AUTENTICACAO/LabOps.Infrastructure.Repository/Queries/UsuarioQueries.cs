using Auth.LabOps.Infrastructure.Repository.Queries.Records;

namespace Auth.LabOps.Infrastructure.Repository.Queries
{
    public static class UsuarioQueries
    {
        public static SqlModel BuscarUsuarioPelaChave(string chave)
        {
            var consultaSql = $@"
                SELECT [IDUsuario], [Login], [Senha], [InseridoEm], [AtualizadoEm]
                FROM [LabOpsAutenticacao].[dbo].[Usuario]
                WHERE [Login] = '{chave.ToUpper()}'";
            var parametros = new { };
            return new SqlModel(consultaSql, parametros);
        }
    }
}

using Auth.LabOps.Infrastructure.Repository.Queries.Records;

namespace Auth.LabOps.Infrastructure.Repository.Queries
{
    public static class UsuarioQueries
    {
        public static SqlModel BuscarUsuarioPelaChave(string chave)
        {
            var consultaSql = $@"
                SELECT [IDUsuario], [Login], [Senha]
                FROM [dbo].[Usuario]
                WHERE [Login] = '{chave}'";
            return new SqlModel(consultaSql);
        }
    }
}

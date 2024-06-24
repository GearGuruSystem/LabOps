using Auth.LabOps.Infrastructure.Repository.Queries.Records;
using System;

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

        public static SqlModel BuscarUsuarioPeloId(int id)
        {
            var consultaSql = $@"
                SELECT [IDUsuario], [Login], [Senha]
                FROM [dbo].[Usuario]
                WHERE [Login] = '{id}'";
            return new SqlModel(consultaSql);
        }
    }
}

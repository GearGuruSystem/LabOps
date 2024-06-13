using Auth.LabOps.Domain.Core.Interfaces;
using Auth.LabOps.Domain.Entities;
using Auth.LabOps.Infrastructure.Data.DataAcess;
using Auth.LabOps.Infrastructure.Repository.Queries;
using Dapper;
using System.Data;

#pragma warning disable IDE0290 // Use primary constructor

namespace Auth.LabOps.Infrastructure.Repository.Repository
{
    public class RepositoryUsuario : RepositoryBase<Usuario>, IRepositoryUsuario
    {
        private readonly ISqlData sqlData;
        private readonly IDbConnection connection;

        public RepositoryUsuario(ISqlData sqlData, SqlFactory sqlFactory)
        {
            this.sqlData = sqlData;
            connection = sqlFactory.CreateConnection();
        }

        public async override Task<IEnumerable<Usuario>> BuscarTodos()
        {
            var resultadoSql = await sqlData.LoadDataAsync<Usuario, dynamic>("[dbo].[LoSp_BuscaTodosUsuarios]", new { });
            return resultadoSql.ToList();
        }

        public override async Task<Usuario> Buscar(int id)
        {
            var resultadoSql = await sqlData.LoadDataAsync<Usuario, dynamic>("", new { @Id = id });
            return resultadoSql.FirstOrDefault();
        }

        public async Task<Usuario> Buscar(string chave)
        {
            var query = UsuarioQueries.BuscarUsuarioPelaChave(chave);
            var resultadoSql = await connection.QueryAsync<Usuario>(query.CodigoSql);
            return resultadoSql.FirstOrDefault();
        }

        public override async Task<Task> Registrar(Usuario entity)
        {
            var response = await sqlData.SaveDataAsync("[dbo].[LoSp_InserirUsuario]", new 
            { 
                @Login = entity.Login.ToLower(),
                @Senha = entity.Senha 
            });
            if (response.IsCompleted)
            {
                return Task.CompletedTask;
            }
            throw new Exception("Erro");
        }

        public Task<Usuario> Atualizar(Usuario entity)
        {
            throw new NotImplementedException();
        }
    }
}

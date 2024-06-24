using Auth.LabOps.Domain.Core.Interfaces;
using Auth.LabOps.Domain.Entities;
using Auth.LabOps.Infrastructure.Data.DataAcess;
using Auth.LabOps.Infrastructure.Data.DataContex;
using Microsoft.EntityFrameworkCore;
using System.Data;

#pragma warning disable IDE0290 // Use primary constructor

namespace Auth.LabOps.Infrastructure.Repository.Repository
{
    public class RepositoryUsuario : RepositoryBase<Usuario>, IRepositoryUsuario
    {
        private readonly ISqlData sqlData;
        private readonly IDbConnection connection;
        private readonly AppDbContext context;

        public RepositoryUsuario(ISqlData sqlData, SqlFactory sqlFactory, AppDbContext context) : base(context)
        {
            this.sqlData = sqlData;
            connection = sqlFactory.CreateConnection();
        }

        public async override Task<List<Usuario>> BuscarTodos()
        {
            var resultadoSql = await sqlData.LoadDataAsync<Usuario, dynamic>("[dbo].[LoSp_BuscaTodosUsuarios]");
            return resultadoSql.ToList();
        }

        public override async Task<Usuario> Buscar(int id)
        {
            return await base.Buscar(id);
        }

        public async Task<Usuario> Buscar(string chave)
        {
            return await context.Usuarios.FirstOrDefaultAsync(u => u.Login == chave);
        }

        public override async Task<Task> Registrar(Usuario entity)
        {
            return await base.Registrar(entity);
        }

        public Task<Usuario> Atualizar(Usuario entity)
        {
            throw new NotImplementedException();
        }
    }
}

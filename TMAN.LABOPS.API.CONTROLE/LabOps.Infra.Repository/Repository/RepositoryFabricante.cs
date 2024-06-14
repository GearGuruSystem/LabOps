using LabOps.Domain.Core.Interfaces;
using LabOps.Domain.Entities;
using LabOps.Infra.Data.DataAcess;
using LabOps.Infra.Data.DataContext;
using Microsoft.IdentityModel.Tokens;

#pragma warning disable IDE0290 // Use primary constructor

namespace LabOps.Infra.Repository.Repository
{
    public class RepositoryFabricante : RepositoryBase<Fabricante>, IRepositoryFabricante
    {
        private readonly SqlFactory sqlFactory;

        public RepositoryFabricante(SqlFactory sqlFactory, AppDbContext context) : base(context)
        {
            this.sqlFactory = sqlFactory;
        }

        public override async Task<IEnumerable<Fabricante>> BuscarTodos()
        {
            var resultSql = await sqlFactory.LoadDataAsync<Fabricante, dynamic>("[dbo].[LoSp_BuscarTodosFabricantes]", new { });
            if (resultSql.IsNullOrEmpty())
            {
                throw new Exception("Não foi encontrando nenhum registro no banco.");
            }
            return resultSql;
        }

        public override async Task<IEnumerable<Fabricante>> BuscarPorParametro(Fabricante obj)
        {
            var resultadoSql = await sqlFactory.LoadDataAsync<Fabricante, dynamic>("", new { });
            if (resultadoSql.IsNullOrEmpty())
            {
                throw new Exception("Não foi encontrando nenhum registro no banco.");
            }
            return resultadoSql;
        }

        public override async Task<Fabricante> BuscarPorId(int id)
        {
            var result = await sqlFactory.LoadDataAsync<Fabricante, dynamic>("[dbo].[LoSp_SelecionarFabricante]", new 
            { 
                @IDFabricante = id
            });
            if (result.IsNullOrEmpty())
            {
                throw new Exception("Não foi encontrando nenhum registro no banco.");
            }
            return result.FirstOrDefault();
        }

        public override async void Registrar(Fabricante obj)
        {
            try
            {
                await sqlFactory.SaveDataAsync("dbo.LoSp_InserirFabricante", new
                {
                    @NomeParam = obj.Nome,
                    @UsuarioAtualizacaoParam = obj.UsuarioAtualizacao
                });
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                throw new Exception(ex.Message);
            }
        }

        public override async void Atualizar(Fabricante obj)
        {
            await sqlFactory.SaveDataAsync("[dbo].[LoSp_AtualizarFabricante]", new
            {
                obj.IDFabricante,
                @NomeParam = obj.Nome.ToString(),
                @UsuarioAtualizacaoParam = obj.UsuarioAtualizacao.ToString()
            });
        }

        public override async void Remove(Fabricante obj)
        {
            var result = await sqlFactory.SaveDataAsync("", new
            {
            });
            if (!result.IsCompleted)
            {
                throw new Exception($"Falha ao inserir o {obj.Nome} no banco!");
            }
        }
    }
}
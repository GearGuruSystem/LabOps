using LabOps.Domain.Core.Interfaces;
using LabOps.Domain.Entities;
using LabOps.Infrastructure.Data.DataAcess;
using Microsoft.IdentityModel.Tokens;

#pragma warning disable IDE0290 // Use primary constructor

namespace LabOps.Infrastructure.Repository.Repository
{
    public class RepositoryFabricante : RepositoryBase<Fabricante>, IRepositoryFabricante
    {
        private readonly SqlFactory sqlFactory;

        public RepositoryFabricante(SqlFactory sqlFactory)
        {
            this.sqlFactory = sqlFactory;
        }

        public override async Task<IEnumerable<Fabricante>> BuscarTodos()
        {
            var result = await sqlFactory.LoadDataAsync<Fabricante, dynamic>("", new { });
            if (result.IsNullOrEmpty())
            {
                throw new Exception("Não foi encontrando nenhum registro no banco.");
            }
            return result;
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
            var result = await sqlFactory.LoadDataAsync<Fabricante, dynamic>("", new { });
            if (result.IsNullOrEmpty())
            {
                throw new Exception("Não foi encontrando nenhum registro no banco.");
            }
            return result.FirstOrDefault();
        }

        public override async void Atualizar(Fabricante obj)
        {
            var result = await sqlFactory.SaveDataAsync("", new
            {

            });
            if (!result.IsCompleted)
            {
                throw new Exception($"Falha ao inserir o {obj.Nome} no banco!");
            }
        }

        public override async void Registrar(Fabricante obj)
        {
            var result = await sqlFactory.SaveDataAsync("", new
            {
                @IdParam = obj.IDFabricante
            });
            if (!result.IsCompleted)
            {
                throw new Exception($"Falha ao inserir o {obj.Nome} no banco!");
            }
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

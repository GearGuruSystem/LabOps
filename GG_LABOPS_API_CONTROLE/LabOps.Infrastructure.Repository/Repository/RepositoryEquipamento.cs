using LabOps.Domain.Core.Interfaces;
using LabOps.Domain.Entities;
using LabOps.Infrastructure.Data.DataAcess;

#pragma warning disable IDE0290 // Use primary constructor

namespace LabOps.Infrastructure.Repository.Repository
{
    public class RepositoryEquipamento : IRepositoryEquipamento
    {
        private readonly SqlFactory sqlFactory;

        public RepositoryEquipamento(SqlFactory sqlFactory)
        {
            this.sqlFactory = sqlFactory;
        }
        public async Task<IEnumerable<Equipamento>> BuscarTodos()
        {
            var result = await sqlFactory.LoadDataAsync<Equipamento, dynamic>("[dbo].[LABOPS_CONSULTA_TODAS_MAQUINAS]", new { });
            if (result.Any())
            {
                return result;
            }
            throw new Exception("Não foi encontrando nenhum registro no banco.");
        }

        public async Task<Equipamento> BuscarPorId(int id)
        {
            var result = await sqlFactory.LoadDataAsync<Equipamento, dynamic>("[dbo].[LABOPS_CONSULTA_MAQUINA_POR_ID]", new
            {
                @idParam = id
            });
            if (result.Any())
            {
                return result.FirstOrDefault();
            }
            throw new Exception("Não foi encontrando nenhum registro no banco.");
        }

        public async void Registrar(Equipamento obj)
        {
            var result = await sqlFactory.SaveDataAsync("[dbo].[LABOPS_CADASTRA_MAQUINATESTE]", new
            {

            });
            if (!result.IsCompleted)
            {
                throw new Exception($"Falha ao inserir o {obj.Nome} no banco!");
            }
        }

        public async void Atualizar(Equipamento obj)
        {
            var result = await sqlFactory.SaveDataAsync("", new
            {

            });
            if (!result.IsCompleted)
            {
                throw new Exception();
            }
        }

        public async void Remove(Equipamento obj)
        {
            var result = await sqlFactory.SaveDataAsync("", new
            {

            });
            if (!result.IsCompleted)
            {
                throw new Exception();
            }
        }
    }
}

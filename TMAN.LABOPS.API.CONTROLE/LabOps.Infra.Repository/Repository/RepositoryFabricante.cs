using LabOps.Domain.Core.Interfaces;
using LabOps.Domain.Entities;
using LabOps.Infra.Data.DataContext;

#pragma warning disable IDE0290

namespace LabOps.Infra.Repository.Repository
{
    public class RepositoryFabricante : RepositoryBase<Fabricante>, IRepositoryFabricante
    {
        public RepositoryFabricante(AppDbContext context) : base(context)
        {
        }

        public override async Task<IEnumerable<Fabricante>> BuscarTodos()
        {
            var result = await base.BuscarTodos();
            if(!result.Any())
            {
                throw new Exception("Não foi encontrado nenhum registro no banco de dados");
            }
            return result.ToList();
        }

        public override async Task<Fabricante> BuscarPorId(int id)
        {
            return await base.BuscarPorId(id);
        }

        public override async Task Registrar(Fabricante obj)
        {
            await base.Registrar(obj);
        }

        public override async Task Atualizar(Fabricante obj)
        {
            await base.Atualizar(obj);
        }

        public override async Task Deletar(Fabricante obj)
        {
            await base.Deletar(obj);
        }
    }
}
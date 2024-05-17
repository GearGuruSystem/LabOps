using LabOps.Domain.Core.Interfaces;
using LabOps.Domain.Core.Services;
using LabOps.Domain.Entities;

#pragma warning disable IDE0290 // Use primary constructor

namespace LabOps.Domain.Services.Services
{
    public class ServiceFabricante : ServiceBase<Fabricante>, IServiceFabricante
    {
        public readonly IRepositoryFabricante repositoryFabricante;

        public ServiceFabricante(IRepositoryFabricante repositoryFabricante)
            : base(repositoryFabricante)
        {
            this.repositoryFabricante = repositoryFabricante;
        }

        public override Task<IEnumerable<Fabricante>> BuscarTodos()
        {
            return base.BuscarTodos();
        }

        public override Task<Fabricante> BuscarPorId(int id)
        {
            return base.BuscarPorId(id);
        }

        public override void Adicionar(Fabricante obj)
        {
            base.Adicionar(obj);
        }

        public override void Atualiza(Fabricante obj)
        {
            base.Atualiza(obj);
        }

        public override void Remove(Fabricante obj)
        {
            base.Remove(obj);
        }
    }
}

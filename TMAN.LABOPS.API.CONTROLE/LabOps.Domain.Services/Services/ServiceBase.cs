using LabOps.Domain.Core.Interfaces;
using LabOps.Domain.Core.Services;

#pragma warning disable IDE0290 // Use primary constructor

namespace LabOps.Domain.Services.Services
{
    public abstract class ServiceBase<TEntity> : IServiceBase<TEntity> where TEntity : class
    {
        private readonly IRepositoryBase<TEntity> _repository;

        public ServiceBase(IRepositoryBase<TEntity> Repository)
        {
            _repository = Repository;
        }

        public virtual async Task<IEnumerable<TEntity>> BuscarTodos()
        {
            return await _repository.BuscarTodos();
        }

        public virtual async Task<TEntity> BuscarPorId(int id)
        {
            return await _repository.BuscarPorId(id);
        }

        public virtual void Adicionar(TEntity obj)
        {
             _repository.Registrar(obj);
        }

        public virtual void Atualizar(TEntity obj)
        {
            _repository.Atualizar(obj);
        }

        public virtual void Remover(TEntity obj)
        {
            _repository.Deletar(obj);
        }
    }
}
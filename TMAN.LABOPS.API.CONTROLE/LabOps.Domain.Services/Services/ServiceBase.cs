﻿using LabOps.Domain.Core.Interfaces;
using LabOps.Domain.Core.Services;

#pragma warning disable IDE0290 // Use primary constructor

namespace LabOps.Domain.Services.Services
{
    public abstract class ServiceBase<TEntity> : IServiceBase<TEntity> where TEntity : class
    {
        private readonly IRepositoryBase<TEntity> repository;

        public ServiceBase(IRepositoryBase<TEntity> repository)
        {
            this.repository = repository;
        }

        public virtual async Task<IEnumerable<TEntity>> BuscarTodos()
        {
            return await repository.BuscarTodos();
        }

        public virtual async Task<TEntity> BuscarPorId(int id)
        {
            return await repository.BuscarPorId(id);
        }

        public virtual void Adicionar(TEntity obj)
        {
             repository.Registrar(obj);
        }

        public virtual void Atualizar(TEntity obj)
        {
            repository.Atualizar(obj);
        }

        public virtual void Remover(TEntity obj)
        {
            repository.Deletar(obj);
        }
    }
}
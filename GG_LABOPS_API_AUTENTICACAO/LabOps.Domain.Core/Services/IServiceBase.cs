﻿namespace Auth.LabOps.Domain.Core.Services
{
    public interface IServiceBase<TEntity> where TEntity : class
    {
        public Task<IEnumerable<TEntity>> BuscarTodos();
        public Task<TEntity> Buscar();
        public void Registrar(TEntity entity);
    }
}

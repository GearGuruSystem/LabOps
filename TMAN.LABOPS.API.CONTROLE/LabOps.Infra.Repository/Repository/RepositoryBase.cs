using LabOps.Domain.Core.Interfaces;
using LabOps.Infra.Data.DataContext;
using Microsoft.EntityFrameworkCore;

#pragma warning disable IDE0290 // Use primary constructor

namespace LabOps.Infra.Repository.Repository
{
    public abstract class RepositoryBase<TEntity> : IRepositoryBase<TEntity> where TEntity : class
    {
        private readonly AppDbContext _context;
        private readonly DbSet<TEntity> _dbSet;

        public RepositoryBase(AppDbContext context)
        {
            _context = context;
            _dbSet = context.Set<TEntity>();
        }

        public virtual async Task<IEnumerable<TEntity>> BuscarTodos()
        {
            var result = await _context.Set<TEntity>().ToListAsync();
            if (result.Count < 1)
            {
                return Enumerable.Empty<TEntity>();
            }
            return result;
        }

        public virtual async Task<TEntity> BuscarPorId(int id)
        {
            return await _context.Set<TEntity>().FindAsync(id);
        }

        public virtual async Task Registrar(TEntity obj)
        {
            await _dbSet.AddAsync(obj);
            await _context.SaveChangesAsync();
        }

        public virtual async Task Atualizar(TEntity obj)
        {
            _dbSet.Update(obj);
            await _context.SaveChangesAsync();
        }

        public virtual async Task Deletar(TEntity obj)
        {
            _dbSet.Remove(obj);
            await _context.SaveChangesAsync();
        }
    }
}
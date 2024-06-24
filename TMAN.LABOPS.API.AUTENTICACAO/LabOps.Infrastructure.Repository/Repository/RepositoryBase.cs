using Auth.LabOps.Infrastructure.Data.DataContex;
using Microsoft.EntityFrameworkCore;

namespace Auth.LabOps.Infrastructure.Repository.Repository
{
    public abstract class RepositoryBase<TEntity> where TEntity : class
    {
        private readonly AppDbContext context;

        public RepositoryBase(AppDbContext context)
        {
            this.context = context;
        }
        
        public virtual async Task<List<TEntity>> BuscarTodos()
        {
            return await context.Set<TEntity>().ToListAsync();
        }
        public virtual async Task<TEntity> Buscar(int id)
        {
            return await context.Set<TEntity>().FindAsync(id);
        }
        public virtual async Task<Task> Registrar(TEntity entity)
        {
            await context.Set<TEntity>().AddAsync(entity);
            var result = await context.SaveChangesAsync();
            if (result < 1)
            {
                throw new Exception("Houve um problema ao adicionar no banco");
            }
            return Task.CompletedTask;
        }
    }
}

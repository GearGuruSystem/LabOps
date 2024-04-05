namespace GG_LabOps_Domain.Interfaces.Generics
{
    public interface IGenericRepository<T> where T : class
    {
        public Task<IEnumerable<T>> GetAllAsync();
        public Task<T> GetByIdAsync(int id);
        public Task<T> CreateAsync(T entity);
        public Task<T> UpdateAsync(int id, T entity);
        public bool DeleteById(int id);
    }
}

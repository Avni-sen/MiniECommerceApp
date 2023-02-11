using ETicaretAPI.Domain.Entities.Common;

namespace ETicaretAPI.Application.Repositories
{
    public interface IWriteRepository<T> : IRepository<T> where T : BaseEntity
    {
        Task<bool> AddAsync(T entity);
        Task<bool> AddRangeAsync(List<T> entities);
        bool Delete(T entity);
        bool DeleteRange(List<T> entities);
        Task<bool> DeleteAsyncById(string id);
        bool Update(T entity);
        Task<int> SaveAsync();
    }
}

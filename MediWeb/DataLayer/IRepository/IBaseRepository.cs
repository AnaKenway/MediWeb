
namespace DataLayer.Repository;

public interface IBaseRepository<T> where T : class
{
    IEnumerable<T> GetAll();
    Task<IEnumerable<T>> GetAllAsync();
    T GetById(long id);
    Task<T> GetByIdAsync(long name);
    T Insert(T entity);
    Task<T> InsertAsync(T entity);
    IEnumerable<T> BulkInsert(IEnumerable<T> entities);
    Task<IEnumerable<T>> BulkInsertAsync(IEnumerable<T> entities);
    T Update(T entity);
    Task<T> UpdateAsync(T entity);
    IEnumerable<T> BulkUpdate(IEnumerable<T> entities);
    Task<IEnumerable<T>> BulkUpdateAsync(IEnumerable<T> entities);
    void Delete(T entity);
    Task DeleteAsync(T entities);
    void BulkDelete(IEnumerable<T> entities);
    Task BulkDeleteAsync(IEnumerable<T> entities);
    void Save();
    Task SaveAsync();
}

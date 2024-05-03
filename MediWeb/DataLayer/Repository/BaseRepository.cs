
namespace DataLayer.Repository
{
    public class BaseRepository<T> : IBaseRepository<T> where T : class
    {
        protected readonly MediWebContext _context;

        public BaseRepository(MediWebContext context) 
        {
            _context = context;
        }

        public virtual IEnumerable<T> GetAll()
        {
            throw new NotImplementedException();
        }

        public virtual async Task<IEnumerable<T>> GetAllAsync()
        {
            throw new NotImplementedException();
        }

        public virtual T GetById(long id)
        {
            throw new NotImplementedException();
        }

        public virtual async Task<T> GetByIdAsync(long name)
        {
            throw new NotImplementedException();
        }

        public virtual T Insert(T entity)
        {
            throw new NotImplementedException();
        }

        public virtual async Task<T> InsertAsync(T entity)
        {
            throw new NotImplementedException();
        }

        public virtual IEnumerable<T> BulkInsert(IEnumerable<T> entities)
        {
            throw new NotImplementedException();
        }

        public virtual async Task<IEnumerable<T>> BulkInsertAsync(IEnumerable<T> entities)
        {
            throw new NotImplementedException();
        }

        public virtual T Update(T entity)
        {
            throw new NotImplementedException();
        }

        public virtual async Task<T> UpdateAsync(T entity)
        {
            throw new NotImplementedException();
        }
        public virtual IEnumerable<T> BulkUpdate(IEnumerable<T> entities)
        {
            throw new NotImplementedException();
        }

        public virtual async Task<IEnumerable<T>> BulkUpdateAsync(IEnumerable<T> entities)
        {
            throw new NotImplementedException();
        }
        public virtual void Delete(long id)
        {
            throw new NotImplementedException();
        }

        public virtual async Task DeleteAsync(long id)
        {
            throw new NotImplementedException();
        }

        public virtual void BulkDelete(IEnumerable<T> entities)
        {
            throw new NotImplementedException();
        }

        public virtual async Task BulkDeleteAsync(IEnumerable<T> entities)
        {
            throw new NotImplementedException();
        }             

        public virtual void Save()
        {
            throw new NotImplementedException();
        }

        public virtual async Task SaveAsync()
        {
            throw new NotImplementedException();
        }
    }
}

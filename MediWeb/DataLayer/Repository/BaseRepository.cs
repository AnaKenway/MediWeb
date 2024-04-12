
namespace DataLayer.Repository
{
    public class BaseRepository<T> : IBaseRepository<T> where T : class
    {
        protected readonly MediwebContext _context;

        public BaseRepository(MediwebContext context) 
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

        public virtual T GetById(int id)
        {
            throw new NotImplementedException();
        }

        public virtual async Task<T> GetByIdAsync(string name)
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
        public virtual void Delete(int id)
        {
            throw new NotImplementedException();
        }

        public virtual async void DeleteAsync(int id)
        {
            throw new NotImplementedException();
        }

        public virtual void BulkDelete(IEnumerable<T> entities)
        {
            throw new NotImplementedException();
        }

        public virtual async void BulkDeleteAsync(IEnumerable<T> entities)
        {
            throw new NotImplementedException();
        }             

        public virtual void Save()
        {
            throw new NotImplementedException();
        }
    }
}

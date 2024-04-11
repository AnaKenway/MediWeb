
namespace DataLayer.Repository
{
    public interface IBaseRepository<T> where T : class
    {
        public IEnumerable<T> GetAll();
        public T GetByID(int id);
        public T Insert(T entity);
        public void Delete(int id);
        public T Update(T entity);
        public void Save();
    }
}

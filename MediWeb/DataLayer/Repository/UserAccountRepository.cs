using Data;
using Data.EntityModels;

namespace DataLayer.Repository
{
    public class UserAccountRepository : IUserAccountRepository
    {
        private MediwebContext _context;

        public UserAccountRepository(MediwebContext context)
        {
            _context = context;
        }

        public void Delete(int id)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<UserAccount> GetAll()
        {
            throw new NotImplementedException();
        }

        public UserAccount GetByID(int id)
        {
            throw new NotImplementedException();
        }

        public UserAccount Insert(UserAccount entity)
        {
            throw new NotImplementedException();
        }

        public void Save()
        {
            throw new NotImplementedException();
        }

        public UserAccount Update(UserAccount entity)
        {
            throw new NotImplementedException();
        }
    }
}

using DataLayer;
using DataLayer.EntityModels;

namespace DataLayer.Repository
{
    public class UserAccountRepository : BaseRepository<UserAccount>, IUserAccountRepository
    {
        public UserAccountRepository(MediWebContext context)
            : base(context)
        {
        }
      
    }
}

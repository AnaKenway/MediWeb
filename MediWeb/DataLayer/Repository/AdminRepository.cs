using DataLayer.EntityModels;

namespace DataLayer.Repository
{
    public class AdminRepository : BaseRepository<Admin>, IAdminRepository
    {
        public AdminRepository(MediWebContext context)
            :base(context)
        {
        }          
    }
}

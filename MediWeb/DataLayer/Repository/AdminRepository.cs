using Common;
using DataLayer;
using DataLayer.EntityModels;

namespace DataLayer.Repository
{
    public class AdminRepository : BaseRepository<Admin>, IAdminRepository
    {
        public AdminRepository(MediWebContext context)
            :base(context)
        {
        }

        public void ChangeAdminType(long adminId, AdminType newAdminTyoe)
        {
            throw new NotImplementedException();
        }       
    }
}

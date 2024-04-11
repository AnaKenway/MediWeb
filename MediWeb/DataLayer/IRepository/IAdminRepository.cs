using static Common.Enums;
using Data.EntityModels;

namespace DataLayer.Repository
{
    public interface IAdminRepository : IBaseRepository<Admin>
    {
        public void ChangeAdminType(long adminId, AdminType newAdminTyoe);
    }
}

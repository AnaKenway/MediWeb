using Common;
using Data;
using Data.EntityModels;

namespace DataLayer.Repository
{
    public class AdminRepository : IAdminRepository
    {
        private MediwebContext _context;

        public AdminRepository(MediwebContext context)
        {
            _context = context;
        }

        public void ChangeAdminType(long adminId, Enums.AdminType newAdminTyoe)
        {
            throw new NotImplementedException();
        }

        public void Delete(int id)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Admin> GetAll()
        {
            throw new NotImplementedException();
        }

        public Admin GetByID(int id)
        {
            throw new NotImplementedException();
        }

        public Admin Insert(Admin entity)
        {
            throw new NotImplementedException();
        }

        public void Save()
        {
            throw new NotImplementedException();
        }

        public Admin Update(Admin entity)
        {
            throw new NotImplementedException();
        }      
    }
}

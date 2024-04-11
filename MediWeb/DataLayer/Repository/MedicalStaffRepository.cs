using Data;
using Data.EntityModels;

namespace DataLayer.Repository
{
    public class MedicalStaffRepository : IMedicalStaffRepository
    {
        private MediwebContext _context;

        public MedicalStaffRepository(MediwebContext context)
        {
            _context = context;
        }

        public void Delete(int id)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<MedicalStaff> GetAll()
        {
            throw new NotImplementedException();
        }

        public MedicalStaff GetByID(int id)
        {
            throw new NotImplementedException();
        }

        public MedicalStaff Insert(MedicalStaff entity)
        {
            throw new NotImplementedException();
        }

        public void Save()
        {
            throw new NotImplementedException();
        }

        public MedicalStaff Update(MedicalStaff entity)
        {
            throw new NotImplementedException();
        }
    }
}

using Data;
using Data.EntityModels;

namespace DataLayer.Repository
{
    public class DoctorWorksAtClinicRepository : IDoctorWorksAtClinicRepository
    {
        private MediwebContext _context;

        public DoctorWorksAtClinicRepository(MediwebContext context)
        {
            _context = context;
        }

        public void Delete(int id)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<DoctorWorksAtClinic> GetAll()
        {
            throw new NotImplementedException();
        }

        public DoctorWorksAtClinic GetByID(int id)
        {
            throw new NotImplementedException();
        }

        public DoctorWorksAtClinic Insert(DoctorWorksAtClinic entity)
        {
            throw new NotImplementedException();
        }

        public void Save()
        {
            throw new NotImplementedException();
        }

        public DoctorWorksAtClinic Update(DoctorWorksAtClinic entity)
        {
            throw new NotImplementedException();
        }
    }
}

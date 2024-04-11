using Data;
using Data.EntityModels;

namespace DataLayer.Repository
{
    public class DoctorRepository : IDoctorRepository
    {
        private MediwebContext _context;

        public DoctorRepository(MediwebContext context)
        {
            _context = context;
        }

        public void Delete(int id)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Doctor> GetAll()
        {
            throw new NotImplementedException();
        }

        public Doctor GetByID(int id)
        {
            throw new NotImplementedException();
        }

        public Doctor Insert(Doctor entity)
        {
            throw new NotImplementedException();
        }

        public void Save()
        {
            throw new NotImplementedException();
        }

        public Doctor Update(Doctor entity)
        {
            throw new NotImplementedException();
        }
    }
}

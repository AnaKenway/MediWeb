using Data;
using Data.EntityModels;

namespace DataLayer.Repository
{
    public class PatientRepository : IPatientRepository
    {
        private MediwebContext _context;

        public PatientRepository(MediwebContext context)
        {
            _context = context;
        }

        public void Delete(int id)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Patient> GetAll()
        {
            throw new NotImplementedException();
        }

        public Patient GetByID(int id)
        {
            throw new NotImplementedException();
        }

        public Patient Insert(Patient entity)
        {
            throw new NotImplementedException();
        }

        public void Save()
        {
            throw new NotImplementedException();
        }

        public Patient Update(Patient entity)
        {
            throw new NotImplementedException();
        }
    }
}

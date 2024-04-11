using Data;
using Data.EntityModels;

namespace DataLayer.Repository
{
    public class ClinicRepository : IClinicRepository
    {
        private MediwebContext _context;

        public ClinicRepository(MediwebContext context)
        {
            _context = context;
        }

        public void Delete(int id)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Clinic> GetAll()
        {
            throw new NotImplementedException();
        }

        public Clinic GetByID(int id)
        {
            throw new NotImplementedException();
        }

        public Clinic Insert(Clinic entity)
        {
            throw new NotImplementedException();
        }

        public void Save()
        {
            throw new NotImplementedException();
        }

        public Clinic Update(Clinic entity)
        {
            throw new NotImplementedException();
        }
    }
}

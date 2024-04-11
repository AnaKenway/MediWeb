using Data;
using Data.EntityModels;

namespace DataLayer.Repository
{
    public class SpecializationRepository : ISpecializationRepository
    {
        private MediwebContext _context;

        public SpecializationRepository(MediwebContext context)
        {
            _context = context;
        }

        public void Delete(int id)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Specialization> GetAll()
        {
            throw new NotImplementedException();
        }

        public Specialization GetByID(int id)
        {
            throw new NotImplementedException();
        }

        public Specialization Insert(Specialization entity)
        {
            throw new NotImplementedException();
        }

        public void Save()
        {
            throw new NotImplementedException();
        }

        public Specialization Update(Specialization entity)
        {
            throw new NotImplementedException();
        }
    }
}

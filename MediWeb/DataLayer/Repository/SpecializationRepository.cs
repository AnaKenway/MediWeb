using DataLayer;
using DataLayer.EntityModels;

namespace DataLayer.Repository
{
    public class SpecializationRepository : BaseRepository<Specialization>, ISpecializationRepository
    {
        public SpecializationRepository(MediWebContext context)
            :base(context)
        {
        }
    }
}

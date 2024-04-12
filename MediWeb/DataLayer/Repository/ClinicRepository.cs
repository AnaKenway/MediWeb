using DataLayer;
using DataLayer.EntityModels;

namespace DataLayer.Repository
{
    public class ClinicRepository : BaseRepository<Clinic>, IClinicRepository
    {
        public ClinicRepository(MediwebContext context)
            :base(context)
        {
        }
    }
}

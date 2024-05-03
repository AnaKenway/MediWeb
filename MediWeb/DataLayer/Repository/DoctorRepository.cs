using DataLayer;
using DataLayer.EntityModels;

namespace DataLayer.Repository
{
    public class DoctorRepository : BaseRepository<Doctor>, IDoctorRepository
    {
        public DoctorRepository(MediWebContext context)
            :base(context)
        {
        }    
    }
}

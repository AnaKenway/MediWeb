using DataLayer;
using DataLayer.EntityModels;

namespace DataLayer.Repository
{
    public class DoctorRepository : BaseRepository<Doctor>, IDoctorRepository
    {
        public DoctorRepository(MediwebContext context)
            :base(context)
        {
        }    
    }
}

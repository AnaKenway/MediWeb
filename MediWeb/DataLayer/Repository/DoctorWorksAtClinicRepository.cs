using DataLayer;
using DataLayer.EntityModels;

namespace DataLayer.Repository
{
    public class DoctorWorksAtClinicRepository : BaseRepository<DoctorWorksAtClinic>, IDoctorWorksAtClinicRepository
    {
        public DoctorWorksAtClinicRepository(MediwebContext context)
            :base(context)
        {
        }
    }
}

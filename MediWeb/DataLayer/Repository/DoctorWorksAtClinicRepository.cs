using DataLayer.EntityModels;

namespace DataLayer.Repository
{
    public class DoctorWorksAtClinicRepository : BaseRepository<DoctorWorksAtClinic>, IDoctorWorksAtClinicRepository
    {
        public DoctorWorksAtClinicRepository(MediWebContext context)
            :base(context)
        {
        }

        public Task DeleteAsync(long doctorId, long clinicId)
        {
            throw new NotImplementedException();
        }
    }
}

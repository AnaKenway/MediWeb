using DataLayer;
using DataLayer.EntityModels;

namespace DataLayer.Repository
{
    public class PatientRepository : BaseRepository<Patient>, IPatientRepository
    {
        public PatientRepository(MediwebContext context)
            :base(context)
        {
        }
    }
}

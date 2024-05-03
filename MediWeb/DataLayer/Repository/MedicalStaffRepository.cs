using DataLayer;
using DataLayer.EntityModels;

namespace DataLayer.Repository
{
    public class MedicalStaffRepository : BaseRepository<MedicalStaff>, IMedicalStaffRepository
    {
        public MedicalStaffRepository(MediWebContext context)
            :base(context)
        {
        }
    }
}

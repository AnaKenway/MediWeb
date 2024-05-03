using DataLayer.EntityModels;

namespace DataLayer.Repository
{
    public class AppointmentSlotRepository :BaseRepository<AppointmentSlot>, IAppointmentSlotRepository
    {
        public AppointmentSlotRepository(MediWebContext context)
            :base(context)
        {
        }    
    }
}

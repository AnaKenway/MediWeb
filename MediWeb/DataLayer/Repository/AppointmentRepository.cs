using DataLayer.EntityModels;

namespace DataLayer.Repository
{
    public class AppointmentRepository : BaseRepository<Appointment>, IAppointmentRepository
    {
        public AppointmentRepository(MediwebContext context)
            :base(context)
        {
        }

        public async Task<bool> ApproveAppointment(long appointmentId)
        {
            throw new NotImplementedException();
        }

        public async Task<bool> RejectAppointment(long appointmentId)
        {
            throw new NotImplementedException();
        }
    }
}

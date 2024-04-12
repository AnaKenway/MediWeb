using DataLayer.EntityModels;

namespace DataLayer.Repository
{
    public interface IAppointmentRepository :IBaseRepository<Appointment>
    {
        public Task<bool> ApproveAppointment(long appointmentId);
        public Task<bool> RejectAppointment(long appointmentId);
    }
}

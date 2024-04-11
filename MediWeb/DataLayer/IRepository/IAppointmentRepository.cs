using Data.EntityModels;

namespace DataLayer.Repository
{
    public interface IAppointmentRepository :IBaseRepository<Appointment>
    {
        public bool ApproveAppointment(long appointmentId);
        public bool RejectAppointment(long appointmentId);
    }
}

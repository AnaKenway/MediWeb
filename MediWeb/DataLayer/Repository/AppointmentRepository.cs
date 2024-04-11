using Data;
using Data.EntityModels;

namespace DataLayer.Repository
{
    public class AppointmentRepository : IAppointmentRepository
    {
        private MediwebContext _context;

        public AppointmentRepository(MediwebContext context)
        {
            _context = context;
        }

        public bool ApproveAppointment(long appointmentId)
        {
            throw new NotImplementedException();
        }

        public void Delete(int id)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Appointment> GetAll()
        {
            throw new NotImplementedException();
        }

        public Appointment GetByID(int id)
        {
            throw new NotImplementedException();
        }

        public Appointment Insert(Appointment entity)
        {
            throw new NotImplementedException();
        }

        public bool RejectAppointment(long appointmentId)
        {
            throw new NotImplementedException();
        }

        public void Save()
        {
            throw new NotImplementedException();
        }

        public Appointment Update(Appointment entity)
        {
            throw new NotImplementedException();
        }
    }
}

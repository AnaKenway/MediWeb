using Data;
using Data.EntityModels;

namespace DataLayer.Repository
{
    public class AppointmentSlotRepository :IAppointmentSlotRepository
    {
        private MediwebContext _context;

        public AppointmentSlotRepository(MediwebContext context)
        {
            _context = context;
        }

        public void Delete(int id)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<AppointmentSlot> GetAll()
        {
            throw new NotImplementedException();
        }

        public AppointmentSlot GetByID(int id)
        {
            throw new NotImplementedException();
        }

        public AppointmentSlot Insert(AppointmentSlot entity)
        {
            throw new NotImplementedException();
        }

        public void Save()
        {
            throw new NotImplementedException();
        }

        public AppointmentSlot Update(AppointmentSlot entity)
        {
            throw new NotImplementedException();
        }
    }
}

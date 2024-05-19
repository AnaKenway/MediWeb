using DataLayer.EntityModels;
using Microsoft.EntityFrameworkCore;

namespace DataLayer.Repository
{
    public class DoctorWorksAtClinicRepository : BaseRepository<DoctorWorksAtClinic>, IDoctorWorksAtClinicRepository
    {
        public DoctorWorksAtClinicRepository(MediWebContext context)
            :base(context)
        {
        }

        public async Task<DoctorWorksAtClinic> GetByIdAsync(long doctorId, long clinicId)
        {
            return await _context.DoctorWorksAtClinics.SingleOrDefaultAsync(dwc => dwc.DoctorId == doctorId && dwc.ClinicId == clinicId);
        }

        public async Task DeleteAsync(long doctorId, long clinicId)
        {
            var dwcToRemove = await this.GetByIdAsync(doctorId, clinicId);
            _context.DoctorWorksAtClinics.Remove(dwcToRemove);
            await _context.SaveChangesAsync();
        }

        public async Task<IList<Clinic>> GetAllClinicWhereDoctorWorksByIdAsync(long doctorId)
        {
           return await _context.DoctorWorksAtClinics.Where(dwc => dwc.DoctorId == doctorId).Select(dwc => dwc.Clinic).ToListAsync();
        }

        public async Task<IList<Doctor>> GetAllDoctorsWhoWorkAtClinicByIdAsync(long clinicId)
        {
            return await _context.DoctorWorksAtClinics.Where(dwc => dwc.ClinicId == clinicId).Select(dwc => dwc.Doctor).ToListAsync();
        }

        public IList<Doctor> GetAllDoctorsWhoWorkAtClinicById(long clinicId)
        {
            return _context.DoctorWorksAtClinics.Where(dwc => dwc.ClinicId == clinicId).Select(dwc => dwc.Doctor).ToList();
        }

        public IList<Clinic> GetAllClinicWhereDoctorWorksById(long doctorId)
        {
            return _context.DoctorWorksAtClinics.Where(dwc => dwc.DoctorId == doctorId).Select(dwc => dwc.Clinic).ToList();
        }
    }
}

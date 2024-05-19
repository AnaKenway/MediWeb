using DataLayer.EntityModels;

namespace DataLayer.Repository;

public interface IDoctorWorksAtClinicRepository : IBaseRepository<DoctorWorksAtClinic>
{
    Task<DoctorWorksAtClinic> GetByIdAsync(long doctorId, long clinicId);
    Task DeleteAsync(long doctorId, long clinicId);
    IList<Doctor> GetAllDoctorsWhoWorkAtClinicById(long clinicId);
    IList<Clinic> GetAllClinicWhereDoctorWorksById(long doctorId);
    Task<IList<Doctor>> GetAllDoctorsWhoWorkAtClinicByIdAsync(long clinicId);
    Task<IList<Clinic>> GetAllClinicWhereDoctorWorksByIdAsync(long doctorId);
}

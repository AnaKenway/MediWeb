using DataLayer.EntityModels;

namespace DataLayer.Repository;

public interface IDoctorWorksAtClinicRepository : IBaseRepository<DoctorWorksAtClinic>
{
    Task DeleteAsync(long doctorId, long clinicId);
}

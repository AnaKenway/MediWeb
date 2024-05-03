using DataLayer;
using DataLayer.EntityModels;

namespace MediWeb.Services;

public class DoctorWorksAtClinicService
{
    private readonly UnitOfWork _unitOfWork;

    public DoctorWorksAtClinicService(UnitOfWork unitOfWork)
    {
        _unitOfWork = unitOfWork;
    }

    public async Task<IEnumerable<DoctorWorksAtClinic>> GetAllDoctorWorksAtClinicAsync()
    {
        return await _unitOfWork.DoctorWorksAtClinicRepository.GetAllAsync();
    }

    public async Task AddDoctorWorksAtClinicAsync(DoctorWorksAtClinic doctorWorksAtClinic)
    {
        await _unitOfWork.DoctorWorksAtClinicRepository.InsertAsync(doctorWorksAtClinic);
        await _unitOfWork.SaveAsync();
    }

    public async Task UpdateDoctorWorksAtClinicAsync(DoctorWorksAtClinic doctorWorksAtClinic)
    {
        await _unitOfWork.DoctorWorksAtClinicRepository.UpdateAsync(doctorWorksAtClinic);
        await _unitOfWork.SaveAsync();
    }

    public async Task DeleteDoctorWorksAtClinicAsync(long doctorId, long clinicId)
    {
        await _unitOfWork.DoctorWorksAtClinicRepository.DeleteAsync(doctorId, clinicId);
        await _unitOfWork.SaveAsync();
    }

    /// <summary>
    /// Returns all doctors that work at the Clinic with the specific Id.
    /// </summary>
    /// <param name="clinicId"></param>
    /// <returns></returns>
    /// <exception cref="NotImplementedException"></exception>
    public async Task<IEnumerable<Doctor>> GetAllDoctorsFromClinicByIdAsync(long clinicId)
    {
        throw new NotImplementedException();
    }

    /// <summary>
    /// Returns all Clinics at which the Doctor with the desired Id works at.
    /// A Doctor can work at multiple Clinics.
    /// </summary>
    /// <param name="doctorId"></param>
    /// <returns></returns>
    public async Task<IEnumerable<Clinic>> GetAllClinicsWithDoctorByIdAsync(long doctorId)
    {
        throw new NotImplementedException();
    }
}

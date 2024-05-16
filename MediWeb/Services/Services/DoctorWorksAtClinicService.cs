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

    public async Task<DoctorWorksAtClinic> AddDoctorWorksAtClinicAsync(DoctorWorksAtClinic doctorWorksAtClinic)
    {
        return await _unitOfWork.DoctorWorksAtClinicRepository.InsertAsync(doctorWorksAtClinic);
    }

    public async Task<DoctorWorksAtClinic> UpdateDoctorWorksAtClinicAsync(DoctorWorksAtClinic doctorWorksAtClinic)
    {
        return await _unitOfWork.DoctorWorksAtClinicRepository.UpdateAsync(doctorWorksAtClinic);
    }

    public async Task DeleteDoctorWorksAtClinicAsync(long doctorId, long clinicId)
    {
        await _unitOfWork.DoctorWorksAtClinicRepository.DeleteAsync(doctorId, clinicId);
    }

    /// <summary>
    /// Returns all doctors that work at the Clinic with the specific Id.
    /// </summary>
    /// <param name="clinicId"></param>
    /// <returns></returns>
    /// <exception cref="NotImplementedException"></exception>
    public async Task<IEnumerable<Doctor>> GetAllDoctorsFromClinicByIdAsync(long clinicId)
    {
        return await _unitOfWork.DoctorWorksAtClinicRepository.GetAllDoctorsWhoWorkAtClinicByIdAsync(clinicId);
    }

    /// <summary>
    /// Returns all Clinics at which the Doctor with the desired Id works at.
    /// A Doctor can work at multiple Clinics.
    /// </summary>
    /// <param name="doctorId"></param>
    /// <returns></returns>
    public async Task<IEnumerable<Clinic>> GetAllClinicsWithDoctorByIdAsync(long doctorId)
    {
        return await _unitOfWork.DoctorWorksAtClinicRepository.GetAllClinicWhereDoctorWorksByIdAsync(doctorId);
    }
}

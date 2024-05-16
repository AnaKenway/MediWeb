using DataLayer;
using DataLayer.EntityModels;

namespace MediWeb.Services;

public class DoctorService
{
    private readonly UnitOfWork _unitOfWork;

    public DoctorService(UnitOfWork unitOfWork)
    {
        _unitOfWork = unitOfWork;
    }

    public async Task<IEnumerable<Doctor>> GetAllDoctorsAsync()
    {
        return await _unitOfWork.DoctorRepository.GetAllAsync();
    }

    public async Task<Doctor> GetDoctorByIdAsync(long id)
    {
        return await _unitOfWork.DoctorRepository.GetByIdAsync(id);
    }

    public async Task<Doctor> AddDoctorAsync(Doctor doctor)
    {
        return await _unitOfWork.DoctorRepository.InsertAsync(doctor);
    }

    public async Task<Doctor> UpdateDoctorAsync(Doctor doctor)
    {
        return await _unitOfWork.DoctorRepository.UpdateAsync(doctor);
    }

    public async Task DeleteDoctorAsync(Doctor doctor)
    {
        await _unitOfWork.DoctorRepository.DeleteAsync(doctor);
        await _unitOfWork.SaveAsync();

    }
}

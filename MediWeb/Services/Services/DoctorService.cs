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

    public async Task AddDoctorAsync(Doctor doctor)
    {
        await _unitOfWork.DoctorRepository.InsertAsync(doctor);
        await _unitOfWork.SaveAsync();
    }

    public async Task UpdateDoctorAsync(Doctor doctor)
    {
        await _unitOfWork.DoctorRepository.UpdateAsync(doctor);
        await _unitOfWork.SaveAsync();
    }

    public async Task DeleteDoctorAsync(Doctor doctor)
    {
        await _unitOfWork.DoctorRepository.DeleteAsync(doctor);
        await _unitOfWork.SaveAsync();

    }
}

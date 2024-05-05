using DataLayer;
using DataLayer.EntityModels;

namespace MediWeb.Services;

public class ClinicService
{
    private readonly UnitOfWork _unitOfWork;

    public ClinicService(UnitOfWork unitOfWork)
    {
        _unitOfWork = unitOfWork;
    }

    public async Task<IEnumerable<Clinic>> GetAllClinicsAsync()
    {
        return await _unitOfWork.ClinicRepository.GetAllAsync();
    }

    public async Task<Clinic> GetClinicByIdAsync(long id)
    {
        return await _unitOfWork.ClinicRepository.GetByIdAsync(id);
    }

    public async Task AddClincAsync(Clinic clinic)
    {
        await _unitOfWork.ClinicRepository.InsertAsync(clinic);
        await _unitOfWork.SaveAsync();
    }

    public async Task UpdateClinicAsync(Clinic clinic)
    {
        await _unitOfWork.ClinicRepository.UpdateAsync(clinic);
        await _unitOfWork.SaveAsync();
    }

    public async Task DeleteClinicAsync(Clinic clinic)
    {
        await _unitOfWork.ClinicRepository.DeleteAsync(clinic);
        await _unitOfWork.SaveAsync();

    }
}

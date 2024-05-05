using DataLayer;
using DataLayer.EntityModels;

namespace MediWeb.Services;

public class SpecializationService
{
    private readonly UnitOfWork _unitOfWork;

    public SpecializationService(UnitOfWork unitOfWork)
    {
        _unitOfWork = unitOfWork;
    }

    public async Task<IEnumerable<Specialization>> GetAllSpecializationsAsync()
    {
        return await _unitOfWork.SpecializationRepository.GetAllAsync();
    }

    public async Task<Specialization> GetSpecializationByIdAsync(long id)
    {
        return await _unitOfWork.SpecializationRepository.GetByIdAsync(id);
    }

    public async Task AddSpecializationAsync(Specialization specialization)
    {
        await _unitOfWork.SpecializationRepository.InsertAsync(specialization);
        await _unitOfWork.SaveAsync();
    }

    public async Task UpdateSpecializationAsync(Specialization specialization)
    {
        await _unitOfWork.SpecializationRepository.UpdateAsync(specialization);
        await _unitOfWork.SaveAsync();
    }

    public async Task DeleteSpecializationAsync(Specialization specialization)
    {
        await _unitOfWork.SpecializationRepository.DeleteAsync(specialization);
        await _unitOfWork.SaveAsync();

    }
}

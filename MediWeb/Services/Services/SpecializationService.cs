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

    public async Task<Specialization> AddSpecializationAsync(Specialization specialization)
    {
        return await _unitOfWork.SpecializationRepository.InsertAsync(specialization);
    }

    public async Task<Specialization> UpdateSpecializationAsync(Specialization specialization)
    {
        return await _unitOfWork.SpecializationRepository.UpdateAsync(specialization);
    }

    public async Task DeleteSpecializationAsync(Specialization specialization)
    {
        await _unitOfWork.SpecializationRepository.DeleteAsync(specialization);
    }
}

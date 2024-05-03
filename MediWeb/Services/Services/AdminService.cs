using DataLayer;
using DataLayer.EntityModels;

namespace MediWeb.Services;

public class AdminService
{
    private readonly UnitOfWork _unitOfWork;

    public AdminService(UnitOfWork unitOfWork)
    {
        _unitOfWork = unitOfWork;
    }

    public async Task<IEnumerable<Admin>> GetAllAdminsAsync()
    {
        return await _unitOfWork.AdminRepository.GetAllAsync();
    }

    public async Task<Admin> GetAdminByIdAsync(long id)
    {
        return await _unitOfWork.AdminRepository.GetByIdAsync(id);
    }

    public async Task AddAdminAsync(Admin admin)
    {
        await _unitOfWork.AdminRepository.InsertAsync(admin);
        await _unitOfWork.SaveAsync();
    }

    public async Task UpdateAdminAsync(Admin admin)
    {
        await _unitOfWork.AdminRepository.UpdateAsync(admin);
        await _unitOfWork.SaveAsync();
    }

    public async Task DeleteAdminAsync(long id)
    {
        await _unitOfWork.AdminRepository.DeleteAsync(id);
        await _unitOfWork.SaveAsync();

    }
}

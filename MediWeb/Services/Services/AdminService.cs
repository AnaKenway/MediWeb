using Common;
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

    public async Task<Admin> AddAdminAsync(Admin admin)
    {
        return await _unitOfWork.AdminRepository.InsertAsync(admin);
    }

    public async Task<Admin> UpdateAdminAsync(Admin admin)
    {
        return await _unitOfWork.AdminRepository.UpdateAsync(admin);      
    }


    public async Task DeleteAdminAsync(Admin admin)
    {
        await _unitOfWork.AdminRepository.DeleteAsync(admin);
    }

    public async Task<Admin> ChangeAdminTypeAsync(long adminId, AdminType newAdminType)
    {
        var admin = await _unitOfWork.AdminRepository.GetByIdAsync(adminId) ??
            throw new MediWebClientException(MediWebFeature.Administration, "Cannot change type of Admin because the Admin with Id " + adminId + " doesn't exist!");
        admin.AdminType = newAdminType;
        return await _unitOfWork.AdminRepository.UpdateAsync(admin);
    }
}

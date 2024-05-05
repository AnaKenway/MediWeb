using DataLayer;
using DataLayer.EntityModels;

namespace MediWeb.Services;

public class UserAccountService
{
    private readonly UnitOfWork _unitOfWork;

    public UserAccountService(UnitOfWork unitOfWork)
    {
        _unitOfWork = unitOfWork;
    }

    public async Task<IEnumerable<UserAccount>> GetAllUserAccountsAsync()
    {
        return await _unitOfWork.UserAccountRepository.GetAllAsync();
    }

    public async Task<UserAccount> GetUserAccountByIdAsync(long id)
    {
        return await _unitOfWork.UserAccountRepository.GetByIdAsync(id);
    }

    public async Task AddUserAccountAsync(UserAccount userAccount)
    {
        await _unitOfWork.UserAccountRepository.InsertAsync(userAccount);
        await _unitOfWork.SaveAsync();
    }

    public async Task UpdateUserAccountAsync(UserAccount userAccount)
    {
        await _unitOfWork.UserAccountRepository.UpdateAsync(userAccount);
        await _unitOfWork.SaveAsync();
    }

    public async Task DeleteUserAccountAsync(UserAccount userAccount)
    {
        await _unitOfWork.UserAccountRepository.DeleteAsync(userAccount);
        await _unitOfWork.SaveAsync();

    }
}

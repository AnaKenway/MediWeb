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

    public async Task<UserAccount> AddUserAccountAsync(UserAccount userAccount)
    {
        return await _unitOfWork.UserAccountRepository.InsertAsync(userAccount);
    }

    public async Task<UserAccount> UpdateUserAccountAsync(UserAccount userAccount)
    {
        return await _unitOfWork.UserAccountRepository.UpdateAsync(userAccount);
    }

    public async Task DeleteUserAccountAsync(UserAccount userAccount)
    {
        await _unitOfWork.UserAccountRepository.DeleteAsync(userAccount);
    }
}

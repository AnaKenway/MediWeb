using DataLayer.EntityModels;
using MediWeb.Models;
using Common;

namespace MediWeb.Model;

public static class RegisterViewModelExtension
{
    public static UserAccount CreateUserAccount(this RegisterViewModel viewModel)
    {
        return new UserAccount
        {
            Email = viewModel.Email,
            FirstName = viewModel.FirstName,
            LastName = viewModel.LastName,
            Password = viewModel.Password,
            CreatedDate = DateTime.UtcNow,
            UserType = UserType.Patient
        };
    }

    public static Patient CreatePatient(this RegisterViewModel viewModel, UserAccount userAccount)
    {
        return new Patient
        {
            Jmbg = viewModel.Jmbg,
            DateOfBirth = viewModel.DateOfBirth,
            Gender = viewModel.Gender,
            PhoneNumber = viewModel.PhoneNumber,
            UserAccount = userAccount,
            UserAccountId = viewModel.UserAccountId
        };
    }
}

public static class LoginViewModelExtension
{

}
namespace MediWeb.Models;

public class UserAccountViewModel
{
    public UserAccountViewModel() 
    { 
        Email = string.Empty;
        FirstName = string.Empty;
        LastName = string.Empty;
        Password = string.Empty;
        ConfirmPassword = string.Empty;
    }

    public long UserAccountId { get; set; }
    public string Email { get; set; }
    public string FirstName { get; set; }
    public string LastName { get; set; }
    public string Password { get; set; }
    public string ConfirmPassword { get; set; }

}

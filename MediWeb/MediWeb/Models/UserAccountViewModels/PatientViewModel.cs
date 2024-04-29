using Common;

namespace MediWeb.Models;

public class PatientViewModel : UserAccountViewModel
{
    public long PatientId { get; set; }
    public string Jmbg { get; set; } = null!;
    public Gender Gender {  get; set; }
    public DateTime DateOfBirth { get; set; }
    public string PhoneNumber { get; set; } = null!;

}

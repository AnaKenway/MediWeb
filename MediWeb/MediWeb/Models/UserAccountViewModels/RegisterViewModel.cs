using Common;
using System.ComponentModel.DataAnnotations;

namespace MediWeb.Models;

public class RegisterViewModel : UserAccountViewModel
{
    public long PatientId { get; set; }
    [Required]
    public string Jmbg { get; set; } = null!;
    [Required]
    public Gender Gender {  get; set; }
    [Required]
    public DateTime DateOfBirth { get; set; }
    [Required]
    public string PhoneNumber { get; set; } = null!;

}

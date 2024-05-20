using Common;
using DataLayer.EntityModels;
using System.ComponentModel.DataAnnotations;
using System.Runtime.CompilerServices;

namespace MediWeb.Models;

public class RegisterViewModel : UserAccountViewModel
{
    public long PatientId { get; set; }
    [Required]
    public string Jmbg { get; set; } = null!;
    [Required]
    public Gender Gender {  get; set; }
    [Required]
    [DataType(DataType.Date)]
    public DateTime DateOfBirth { get; set; }
    [Required]
    public string PhoneNumber { get; set; } = null!;
    [Required]
    public string ConfirmPassword { get; set; } = null!;
}

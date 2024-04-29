﻿using System.ComponentModel.DataAnnotations;

namespace MediWeb.Models;

public class UserAccountViewModel
{
    public long UserAccountId { get; set; }
    [Required]
    public string Email { get; set; } = null!;
    [Required]
    public string FirstName { get; set; } = null!;
    [Required]
    public string LastName { get; set; } = null!;
    [Required]
    public string Password { get; set; } = null!;
    [Required]
    public string ConfirmPassword { get; set; } = null!;

}
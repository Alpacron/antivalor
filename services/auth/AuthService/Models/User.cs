using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;

namespace AuthService.Models;

[Index(nameof(Email), IsUnique = true)]
public class User
{
    [Required]
    public int Id { get; set; }

    [Required]
    public string Username { get; set; } = default!;

    [Required]
    public string PasswordHash { get; set; } = default!;

    [Required]
    public string Email { get; set; } = default!;
}

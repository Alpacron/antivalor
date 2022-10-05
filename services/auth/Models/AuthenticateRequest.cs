using System.ComponentModel.DataAnnotations;

namespace AuthService.Models;

public class AuthenticateRequest
{
    [Required]
    public string Username { get; set; } = null!;

    [Required]
    public string Password { get; set; } = null!;
}

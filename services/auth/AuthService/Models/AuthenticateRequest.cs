﻿using System.ComponentModel.DataAnnotations;

namespace AuthService.Models;

public class AuthenticateRequest
{
    [Required, EmailAddress]
    public string Email { get; set; }

    [Required, MinLength(4)]
    public string Password { get; set; }
}
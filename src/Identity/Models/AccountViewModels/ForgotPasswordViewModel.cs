using System.ComponentModel.DataAnnotations;

namespace Identity.Models.AccountViewModels;

public record ForgotPasswordViewModel
{
    [Required]
    [EmailAddress]
    public string Email { get; init; }
}
using System.ComponentModel.DataAnnotations;

namespace Identity.Models.ManageViewModels;

public record AddPhoneNumberViewModel
{
    [Required]
    [Phone]
    [Display(Name = "Phone number")]
    public string PhoneNumber { get; init; }
}
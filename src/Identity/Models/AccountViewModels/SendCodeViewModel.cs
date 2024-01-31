using Microsoft.AspNetCore.Mvc.Rendering;

namespace Identity.Models.AccountViewModels;

public record SendCodeViewModel
{
    public string SelectedProvider { get; init; }

    public ICollection<SelectListItem> Providers { get; init; }

    public string ReturnUrl { get; init; }

    public bool RememberMe { get; init; }
}
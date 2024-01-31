using Microsoft.AspNetCore.Mvc.Rendering;

namespace Identity.Models.ManageViewModels;

public record ConfigureTwoFactorViewModel
{
    public string SelectedProvider { get; init; }

    public ICollection<SelectListItem> Providers { get; init; }
}
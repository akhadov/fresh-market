using Domain.Categories;
using MediatR;
using Microsoft.AspNetCore.Mvc;

namespace Web.Controllers;


[Route("[controller]/[action]")]
public class CategoriesController : Controller
{
    private readonly ISender sender;

    public CategoriesController(ISender sender)
    {
        this.sender = sender;
    }

    [HttpGet("{categoryId}")]
    public async Task<IActionResult> GetCategory(CategoryId categoryId)
    {
        return Ok(categoryId);
    }
}

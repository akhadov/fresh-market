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

    //[HttpGet("{categoryId}")]
    //public async Task<IActionResult> GetCategoryById(Guid categoryId, CancellationToken cancellationToken)
    //{
    //    var query = new GetCategoryByIdQuery(new CategoryId(categoryId));

    //    Result<CategoryResponse> result = await sender.Send(query, cancellationToken);

    //    return View(result);
    //}
}

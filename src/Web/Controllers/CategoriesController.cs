using Application.Categories.Queries.GetById;
using Domain.Categories;
using MediatR;
using Microsoft.AspNetCore.Mvc;
using SharedKernel;
using System.Threading;
using Web.Extensions;
using Web.Infrastructure;

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

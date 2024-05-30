using Application.Abstractions.Models;
using Application.Products.Queries.GetById;
using Application.Products.Queries.GetProducts;
using MediatR;
using Microsoft.AspNetCore.Mvc;
using SharedKernel;

namespace Web.Controllers;

[Route("[controller]/[action]")]
public class ProductsController : Controller
{
    private readonly ISender sender;
    public ProductsController(ISender sender)
    {
        this.sender = sender;
    }

    [HttpGet]
    public async Task<IActionResult> Index(int page, int pageSize, CancellationToken cancellationToken = default)
    {
        var query = new GetProductsQuery(page, pageSize);
        Result<PagedList<ProductResponse>> result = await sender.Send(query, cancellationToken);

        return View("Index", result);
    }
}

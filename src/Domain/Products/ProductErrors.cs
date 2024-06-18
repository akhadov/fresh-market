using SharedKernel;

namespace Domain.Products;

public static class ProductErrors
{
    public static Error NotFound(Guid productId) => Error.NotFound(
        "Products.NotFound",
        $"The product with id: '{productId}' was not found");
}

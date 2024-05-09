using SharedKernel;

namespace Domain.Categories;

public static class CategoryErrors
{
    public static Error NotFound(CategoryId categoryId) => Error.NotFound(
        "Categories.NotFound",
        $"Category with id: {categoryId} was not found.");

}

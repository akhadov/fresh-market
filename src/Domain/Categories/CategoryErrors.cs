using SharedKernel.Errors;

namespace Domain.Categories;

public static class CategoryErrors
{
    public static readonly Error CategoryAlreadyExists = Error.Conflict("Categorys.CategoryAlreadyExists", "Category already exists");
}

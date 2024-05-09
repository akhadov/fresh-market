using SharedKernel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Categories;

public static class CategoryErrors
{
    public static Error NotFound(CategoryId categoryId) => Error.NotFound(
        "Categories.NotFound", 
        $"Category with id: {categoryId} was not found.");
}

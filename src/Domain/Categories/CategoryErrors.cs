using SharedKernel.Errors;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Categories;

public static class CategoryErrors
{
    public static readonly Error CategoryAlreadyExists = Error.Conflict("Categorys.CategoryAlreadyExists", "Category already exists");
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Categories.Commands.UpdateCategory;

public sealed record UpdateCategoryRequest(string Name, string ImagePath);

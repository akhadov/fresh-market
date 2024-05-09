using Domain.Categories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Categories.Queries.GetById;

public record CategoryResponse
{
    public CategoryId CategoryId { get; init; }
    public string Name { get; init; }
    public string ImagePath { get; init; }

}

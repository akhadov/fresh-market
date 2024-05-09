using Application.Abstractions.Messaging;
using Domain.Categories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Categories.Queries.GetById;

public sealed record GetCategoryByIdQuery(CategoryId CategoryId) : IQuery<CategoryResponse>;

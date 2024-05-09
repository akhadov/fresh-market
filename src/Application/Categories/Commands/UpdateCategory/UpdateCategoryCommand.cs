using Application.Abstractions.Messaging;
using Domain.Categories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace Application.Categories.Commands.UpdateCategory;

public sealed record UpdateCategoryCommand(CategoryId CategoryId, string Name, string ImagePath) : ICommand<Guid>;

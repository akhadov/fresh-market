using Domain.Common.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Categories;

public record CategoryCreatedDomainEvent(CategoryId CategoryId, string Name) : DomainEvent
{
}

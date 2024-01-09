using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Domain.Entities.Catalog;

namespace Application.Common.Interfaces.Persistence
{
    public interface ICategoryRepository : IRepository<Category>
    {
    }
}

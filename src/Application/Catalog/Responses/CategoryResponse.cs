using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Catalog.Responses;

public class CategoryResponse
{
    public long Id { get; set; }
    public string Name { get; set; }

    public string ImagePath { get; set; }
}

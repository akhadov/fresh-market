using Application.DTOs.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.DTOs;

public class ProductDto : BaseDto
{
    public string Name { get; set; }

    public string PictureId { get; set; }

    public string Title { get; set; }

    public decimal Price { get; set; }

    public long? CategoryId { get; set; }
    public virtual CategoryDto? Category { get; set; }
}

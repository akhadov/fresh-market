using Domain.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Entities.Blogs;

public  class BlogPostTag : BaseEntity
{
    public string Name { get; set; }

    public int BlogPostCount { get; set; }
}

using Domain.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Entities.Blogs;

public class BlogPost : BaseAuditableEntity
{
    public string Title { get; set; } = string.Empty;

    public string ImagePath { get; set; }

    public string Body { get; set; } = string.Empty;

    public string BodyOverview { get; set; } = string.Empty;

    public long BlogPostTagId { get; set; }
    public virtual BlogPostTag? BlogPostTag { get; set; }

}

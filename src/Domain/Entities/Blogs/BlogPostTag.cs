using Domain.Common;

namespace Domain.Entities.Blogs;

public class BlogPostTag : BaseEntity
{
    public string Name { get; set; }

    public int BlogPostCount { get; set; }
}

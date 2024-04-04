namespace Domain.Entities.Blogs;

public class BlogPost
{
    public string Title { get; set; } = string.Empty;

    public string ImagePath { get; set; }

    public string Body { get; set; } = string.Empty;

    public string BodyOverview { get; set; } = string.Empty;

    public long BlogPostTagId { get; set; }
    public virtual BlogPostTag? BlogPostTag { get; set; }

}

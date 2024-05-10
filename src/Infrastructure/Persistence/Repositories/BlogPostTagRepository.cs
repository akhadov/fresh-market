using Domain.Blogs;

namespace Infrastructure.Persistence.Repositories;

public class BlogPostTagRepository : Repository<BlogPostTag, BlogPostTagId>, IBlogPostTagRepository
{
    private readonly ApplicationDbContext context;

    public BlogPostTagRepository(ApplicationDbContext context) : base(context)
    {
        this.context = context;
    }
}

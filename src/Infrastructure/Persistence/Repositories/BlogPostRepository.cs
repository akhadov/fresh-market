using Domain.Blogs;

namespace Infrastructure.Persistence.Repositories;

public class BlogPostRepository : Repository<BlogPost, BlogPostId>, IBlogPostRepository
{
    private readonly ApplicationDbContext context;

    public BlogPostRepository(ApplicationDbContext context) : base(context)
    {
        this.context = context;
    }
}

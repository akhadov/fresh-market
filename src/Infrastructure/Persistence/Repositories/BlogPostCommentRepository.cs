using Domain.Blogs;

namespace Infrastructure.Persistence.Repositories;

public class BlogPostCommentRepository : Repository<BlogPostComment, BlogPostCommentId>, IBlogPostCommentRepository
{
    private readonly ApplicationDbContext context;

    public BlogPostCommentRepository(ApplicationDbContext context) : base(context)
    {
        this.context = context;
    }
}

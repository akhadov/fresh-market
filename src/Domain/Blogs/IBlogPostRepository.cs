using SharedKernel.Interfaces;

namespace Domain.Blogs;

public interface IBlogPostRepository : IRepository<BlogPost, BlogPostId>
{
}

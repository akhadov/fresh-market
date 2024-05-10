using SharedKernel.Interfaces;

namespace Domain.Blogs;

public interface IBlogPostCommentRepository : IRepository<BlogPostComment, BlogPostCommentId>
{
}

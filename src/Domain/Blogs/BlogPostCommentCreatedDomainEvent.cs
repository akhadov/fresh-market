using SharedKernel.Base;

namespace Domain.Blogs;

public record BlogPostCommentCreatedDomainEvent(BlogPostCommentId Id, string CommentText) : DomainEvent
{
    public static BlogPostCommentCreatedDomainEvent Create(BlogPostComment blogPostComment) => new(blogPostComment.Id, blogPostComment.CommentText);
}

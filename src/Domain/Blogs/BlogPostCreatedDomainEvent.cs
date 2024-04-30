using SharedKernel.Base;

namespace Domain.Blogs;

public record BlogPostCreatedDomainEvent(BlogPostId BlogPostId, string Title) : DomainEvent
{
    public static BlogPostCreatedDomainEvent Create(BlogPost blogPost) => new(blogPost.Id, blogPost.Title);
}

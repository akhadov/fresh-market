using SharedKernel.Base;

namespace Domain.Blogs;

public record BlogPostCreatedEvent(BlogPostId BlogPostId, string Title) : DomainEvent
{
    public static BlogPostCreatedEvent Create(BlogPost blogPost) => new(blogPost.Id, blogPost.Title);
}


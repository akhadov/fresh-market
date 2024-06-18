using Domain.Customers;
using SharedKernel.Base;

namespace Domain.Blogs;

public record BlogPostId(Guid Value);

public class BlogPost : AggregateRoot<BlogPostId>
{
    private readonly List<BlogPostComment> _blogPostComments = new();

    public IReadOnlyList<BlogPostComment> BlogPostComments => _blogPostComments;

    public CustomerId CustomerId { get; private set; }

    public string Title { get; private set; } = string.Empty;

    public string ImagePath { get; private set; }

    public string Body { get; private set; } = string.Empty;

    public string BodyOverview { get; private set; } = string.Empty;

    private BlogPost() { }

    public static BlogPost Create(CustomerId customerId, string title, string imagePath, string body, string bodyOverview)
    {
        var blogPost = new BlogPost
        {
            Id = new BlogPostId(Guid.NewGuid()),
            CustomerId = customerId,
            Title = title,
            ImagePath = imagePath,
            Body = body,
            BodyOverview = bodyOverview
        };

        blogPost.AddDomainEvent(BlogPostCreatedEvent.Create(blogPost));

        return blogPost;
    }

    public void Update(string title, string imagePath, string body, string bodyOverview)
    {
        Title = title;
        ImagePath = imagePath;
        Body = body;
        BodyOverview = bodyOverview;
    }
}
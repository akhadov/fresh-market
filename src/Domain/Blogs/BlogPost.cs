using Domain.Customers;
using SharedKernel.Base;

namespace Domain.Blogs;

public class BlogPost : AggregateRoot<BlogPostId>
{
    public List<BlogPostComment> BlogPostComments { get; private set; } = new();

    public List<BlogPostTag> BlogPostTags { get; private set; } = new();

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

        blogPost.UpdateTitle(title);
        blogPost.UpdateImagePath(imagePath);
        blogPost.UpdateBody(body);
        blogPost.UpdateBodyOverview(bodyOverview);

        blogPost.AddDomainEvent(BlogPostCreatedDomainEvent.Create(blogPost));

        return blogPost;
    }

    public void UpdateTitle(string title)
    {
        Title = title;
    }

    public void UpdateImagePath(string imagePath)
    {
        ImagePath = imagePath;
    }

    public void UpdateBody(string body)
    {
        Body = body;
    }

    public void UpdateBodyOverview(string bodyOverview)
    {
        BodyOverview = bodyOverview;
    }
}

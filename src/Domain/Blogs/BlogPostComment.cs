using Domain.Customers;
using SharedKernel.Base;

namespace Domain.Blogs;

public class BlogPostComment : AggregateRoot<BlogPostCommentId>
{
    public CustomerId CustomerId { get; private set; }

    public BlogPostId BlogPostId { get; private set; }

    public string CommentText { get; private set; } = string.Empty;

    private BlogPostComment() { }

    public static BlogPostComment Create(CustomerId customerId, string commentText)
    {
        var blogPostComment = new BlogPostComment
        {
            Id = new BlogPostCommentId(Guid.NewGuid()),
            CustomerId = customerId,
            CommentText = commentText
        };

        blogPostComment.UpdateText(commentText);

        blogPostComment.AddDomainEvent(BlogPostCommentCreatedEvent.Create(blogPostComment));

        return blogPostComment;
    }

    public void UpdateText(string commentText)
    {
        CommentText = commentText;
    }
}

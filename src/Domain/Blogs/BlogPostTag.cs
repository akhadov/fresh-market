using SharedKernel.Base;

namespace Domain.Blogs;

public class BlogPostTag : AggregateRoot<BlogPostTagId>
{
    public string Name { get; private set; }

    public int BlogPostCount { get; set; }

    private BlogPostTag() { }

    public static BlogPostTag Create(string name, int blogPostCount)
    {
        var blogPostTag = new BlogPostTag
        {
            Id = new BlogPostTagId(Guid.NewGuid()),
            Name = name,
            BlogPostCount = blogPostCount
        };

        blogPostTag.UpdateName(name);

        return blogPostTag;
    }

    public void UpdateName(string name)
    {
        Name = name;
    }
}

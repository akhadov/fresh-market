using Domain.Blogs;
using Domain.Customers;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Infrastructure.Persistence.Configurations;

internal sealed class BlogPostCommentConfiguration : IEntityTypeConfiguration<BlogPostComment>
{
    public void Configure(EntityTypeBuilder<BlogPostComment> builder)
    {
        builder.HasKey(c => c.Id);

        builder.Property(c => c.Id).HasConversion(
            blogPostCommentId => blogPostCommentId.Value,
            value => new BlogPostCommentId(value));

        builder.HasOne<BlogPost>()
            .WithMany()
            .HasForeignKey(x => x.BlogPostId);

        builder.HasOne<Customer>()
            .WithMany()
            .HasForeignKey(x => x.CustomerId);

        builder.Property(x => x.CommentText)
            .IsRequired();

    }
}

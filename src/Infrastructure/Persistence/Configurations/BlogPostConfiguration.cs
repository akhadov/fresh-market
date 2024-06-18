using Domain.Blogs;
using Domain.Customers;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Infrastructure.Persistence.Configurations;

internal sealed class BlogPostConfiguration : IEntityTypeConfiguration<BlogPost>
{
    public void Configure(EntityTypeBuilder<BlogPost> builder)
    {
        builder.HasKey(b => b.Id);

        builder.Property(b => b.Id).HasConversion(
            blogPostId => blogPostId.Value,
            value => new BlogPostId(value));

        builder.HasOne<Customer>()
            .WithMany()
            .HasForeignKey(x => x.CustomerId);

        builder.HasMany(x => x.BlogPostComments)
            .WithOne()
            .HasForeignKey(x => x.BlogPostId);
    }
}

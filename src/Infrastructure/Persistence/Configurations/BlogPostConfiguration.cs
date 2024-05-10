using Domain.Blogs;
using Domain.Customers;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Infrastructure.Persistence.Configurations;

internal sealed class BlogPostConfiguration : IEntityTypeConfiguration<BlogPost>
{
    public void Configure(EntityTypeBuilder<BlogPost> builder)
    {
        builder.HasKey(p => p.Id);

        builder.Property(p => p.Id)
            .IsRequired()
            .HasConversion(
                id => id.Value,
                value => new BlogPostId(value));

        builder.Property(p => p.Title);
        builder.Property(p => p.ImagePath);
        builder.Property(p => p.Body);
        builder.Property(p => p.BodyOverview);

        builder.HasOne<Customer>()
            .WithMany()
            .HasForeignKey(p => p.CustomerId)
            .IsRequired();

        builder.HasOne<BlogPostTag>()
            .WithMany()
            .HasForeignKey(p => p.CustomerId)
            .IsRequired();

        builder.HasMany(p => p.BlogPostComments)
            .WithOne()
            .HasForeignKey(p => p.BlogPostId);
    }
}

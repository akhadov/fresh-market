using Domain.Blogs;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Infrastructure.Persistence.Configurations;

internal sealed class BlogPostTagConfiguration : IEntityTypeConfiguration<BlogPostTag>
{
    public void Configure(EntityTypeBuilder<BlogPostTag> builder)
    {
        builder.HasKey(o => o.Id);

        builder.Property(o => o.Id)
            .IsRequired()
            .HasConversion(o => o.Value, o => new BlogPostTagId(o));

        builder.Property(o => o.Name)
            .HasMaxLength(50);
    }
}

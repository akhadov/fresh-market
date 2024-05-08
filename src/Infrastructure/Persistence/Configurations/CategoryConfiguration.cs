using Domain.Categories;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Infrastructure.Persistence.Configurations;

internal sealed class CategoryConfiguration : IEntityTypeConfiguration<Category>
{
    public void Configure(EntityTypeBuilder<Category> builder)
    {
        builder.HasKey(p => p.Id);

        builder.Property(p => p.Id)
            .IsRequired()
            .HasConversion(categoryId => categoryId.Value, value => new CategoryId(value));

        builder.Property(p => p.Name)
            .HasMaxLength(50);

        builder.Property(p => p.ImagePath);
    }
}

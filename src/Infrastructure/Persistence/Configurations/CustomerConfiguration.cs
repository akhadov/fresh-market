using Domain.Customers;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Infrastructure.Persistence.Configurations;

internal class CustomerConfiguration : IEntityTypeConfiguration<Customer>
{
    public void Configure(EntityTypeBuilder<Customer> builder)
    {
        builder.HasKey(c => c.Id);

        builder.Property(c => c.Id).HasConversion(
            customerId => customerId.Value,
            value => new CustomerId(value));

        builder.ComplexProperty(
            u => u.Email,
            b => b.Property(e => e.Value).HasColumnName("email"));

        builder.ComplexProperty(
            u => u.FirstName,
            b => b.Property(e => e.Value).HasColumnName("firstName"));

        builder.ComplexProperty(
            u => u.LastName,
            b => b.Property(e => e.Value).HasColumnName("lastName"));

        builder.OwnsOne(c => c.Address);
    }
}
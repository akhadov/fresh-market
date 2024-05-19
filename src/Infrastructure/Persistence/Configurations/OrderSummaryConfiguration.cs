using Domain.Orders;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infrastructure.Persistence.Configurations;

internal sealed class OrderSummaryConfiguration : IEntityTypeConfiguration<OrderSummary>
{
    public void Configure(EntityTypeBuilder<OrderSummary> builder)
    {
        builder.HasKey(os => os.Id);

        builder.Property(os => os.LineItems).HasColumnType("jsonb");
    }
}

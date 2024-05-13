using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Infrastructure.Migrations
{
    /// <inheritdoc />
    public partial class SecondCreate : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "fk_orders_customers_customer_id1",
                table: "orders");

            migrationBuilder.DropIndex(
                name: "ix_orders_customer_id1",
                table: "orders");

            migrationBuilder.DropColumn(
                name: "customer_id1",
                table: "orders");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<Guid>(
                name: "customer_id1",
                table: "orders",
                type: "uuid",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "ix_orders_customer_id1",
                table: "orders",
                column: "customer_id1");

            migrationBuilder.AddForeignKey(
                name: "fk_orders_customers_customer_id1",
                table: "orders",
                column: "customer_id1",
                principalTable: "customers",
                principalColumn: "id");
        }
    }
}

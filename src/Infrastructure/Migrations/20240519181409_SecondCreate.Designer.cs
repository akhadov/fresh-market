﻿// <auto-generated />
using System;
using System.Collections.Generic;
using Domain.Orders;
using Infrastructure.Persistence;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

#nullable disable

namespace Infrastructure.Migrations
{
    [DbContext(typeof(ApplicationDbContext))]
    [Migration("20240519181409_SecondCreate")]
    partial class SecondCreate
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "8.0.4")
                .HasAnnotation("Relational:MaxIdentifierLength", 63);

            NpgsqlModelBuilderExtensions.UseIdentityByDefaultColumns(modelBuilder);

            modelBuilder.Entity("Domain.Blogs.BlogPost", b =>
                {
                    b.Property<Guid>("Id")
                        .HasColumnType("uuid")
                        .HasColumnName("id");

                    b.Property<string>("Body")
                        .IsRequired()
                        .HasColumnType("text")
                        .HasColumnName("body");

                    b.Property<string>("BodyOverview")
                        .IsRequired()
                        .HasColumnType("text")
                        .HasColumnName("body_overview");

                    b.Property<DateTimeOffset>("CreatedAt")
                        .HasColumnType("timestamp with time zone")
                        .HasColumnName("created_at");

                    b.Property<string>("CreatedBy")
                        .HasColumnType("text")
                        .HasColumnName("created_by");

                    b.Property<Guid>("CustomerId")
                        .HasColumnType("uuid")
                        .HasColumnName("customer_id");

                    b.Property<string>("ImagePath")
                        .IsRequired()
                        .HasColumnType("text")
                        .HasColumnName("image_path");

                    b.Property<string>("Title")
                        .IsRequired()
                        .HasColumnType("text")
                        .HasColumnName("title");

                    b.Property<DateTimeOffset?>("UpdatedAt")
                        .HasColumnType("timestamp with time zone")
                        .HasColumnName("updated_at");

                    b.Property<string>("UpdatedBy")
                        .HasColumnType("text")
                        .HasColumnName("updated_by");

                    b.HasKey("Id")
                        .HasName("pk_blog_posts");

                    b.HasIndex("CustomerId")
                        .HasDatabaseName("ix_blog_posts_customer_id");

                    b.ToTable("blog_posts", (string)null);
                });

            modelBuilder.Entity("Domain.Blogs.BlogPostComment", b =>
                {
                    b.Property<Guid>("Id")
                        .HasColumnType("uuid")
                        .HasColumnName("id");

                    b.Property<Guid>("BlogPostId")
                        .HasColumnType("uuid")
                        .HasColumnName("blog_post_id");

                    b.Property<string>("CommentText")
                        .IsRequired()
                        .HasColumnType("text")
                        .HasColumnName("comment_text");

                    b.Property<DateTimeOffset>("CreatedAt")
                        .HasColumnType("timestamp with time zone")
                        .HasColumnName("created_at");

                    b.Property<string>("CreatedBy")
                        .HasColumnType("text")
                        .HasColumnName("created_by");

                    b.Property<Guid>("CustomerId")
                        .HasColumnType("uuid")
                        .HasColumnName("customer_id");

                    b.Property<DateTimeOffset?>("UpdatedAt")
                        .HasColumnType("timestamp with time zone")
                        .HasColumnName("updated_at");

                    b.Property<string>("UpdatedBy")
                        .HasColumnType("text")
                        .HasColumnName("updated_by");

                    b.HasKey("Id")
                        .HasName("pk_blog_post_comments");

                    b.HasIndex("BlogPostId")
                        .HasDatabaseName("ix_blog_post_comments_blog_post_id");

                    b.HasIndex("CustomerId")
                        .HasDatabaseName("ix_blog_post_comments_customer_id");

                    b.ToTable("blog_post_comments", (string)null);
                });

            modelBuilder.Entity("Domain.Categories.Category", b =>
                {
                    b.Property<Guid>("Id")
                        .HasColumnType("uuid")
                        .HasColumnName("id");

                    b.Property<DateTimeOffset>("CreatedAt")
                        .HasColumnType("timestamp with time zone")
                        .HasColumnName("created_at");

                    b.Property<string>("CreatedBy")
                        .HasColumnType("text")
                        .HasColumnName("created_by");

                    b.Property<string>("ImagePath")
                        .IsRequired()
                        .HasColumnType("text")
                        .HasColumnName("image_path");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("character varying(50)")
                        .HasColumnName("name");

                    b.Property<DateTimeOffset?>("UpdatedAt")
                        .HasColumnType("timestamp with time zone")
                        .HasColumnName("updated_at");

                    b.Property<string>("UpdatedBy")
                        .HasColumnType("text")
                        .HasColumnName("updated_by");

                    b.HasKey("Id")
                        .HasName("pk_categories");

                    b.ToTable("categories", (string)null);
                });

            modelBuilder.Entity("Domain.Customers.Customer", b =>
                {
                    b.Property<Guid>("Id")
                        .HasColumnType("uuid")
                        .HasColumnName("id");

                    b.Property<DateTimeOffset>("CreatedAt")
                        .HasColumnType("timestamp with time zone")
                        .HasColumnName("created_at");

                    b.Property<string>("CreatedBy")
                        .HasColumnType("text")
                        .HasColumnName("created_by");

                    b.Property<DateTimeOffset?>("UpdatedAt")
                        .HasColumnType("timestamp with time zone")
                        .HasColumnName("updated_at");

                    b.Property<string>("UpdatedBy")
                        .HasColumnType("text")
                        .HasColumnName("updated_by");

                    b.ComplexProperty<Dictionary<string, object>>("Email", "Domain.Customers.Customer.Email#Email", b1 =>
                        {
                            b1.IsRequired();

                            b1.Property<string>("Value")
                                .IsRequired()
                                .HasColumnType("text")
                                .HasColumnName("email");
                        });

                    b.ComplexProperty<Dictionary<string, object>>("FirstName", "Domain.Customers.Customer.FirstName#FirstName", b1 =>
                        {
                            b1.IsRequired();

                            b1.Property<string>("Value")
                                .IsRequired()
                                .HasColumnType("text")
                                .HasColumnName("firstName");
                        });

                    b.ComplexProperty<Dictionary<string, object>>("LastName", "Domain.Customers.Customer.LastName#LastName", b1 =>
                        {
                            b1.IsRequired();

                            b1.Property<string>("Value")
                                .IsRequired()
                                .HasColumnType("text")
                                .HasColumnName("lastName");
                        });

                    b.HasKey("Id")
                        .HasName("pk_customers");

                    b.ToTable("customers", (string)null);
                });

            modelBuilder.Entity("Domain.Orders.LineItem", b =>
                {
                    b.Property<Guid>("Id")
                        .HasColumnType("uuid")
                        .HasColumnName("id");

                    b.Property<DateTimeOffset>("CreatedAt")
                        .HasColumnType("timestamp with time zone")
                        .HasColumnName("created_at");

                    b.Property<string>("CreatedBy")
                        .HasColumnType("text")
                        .HasColumnName("created_by");

                    b.Property<Guid>("OrderId")
                        .HasColumnType("uuid")
                        .HasColumnName("order_id");

                    b.Property<Guid>("ProductId")
                        .HasColumnType("uuid")
                        .HasColumnName("product_id");

                    b.Property<DateTimeOffset?>("UpdatedAt")
                        .HasColumnType("timestamp with time zone")
                        .HasColumnName("updated_at");

                    b.Property<string>("UpdatedBy")
                        .HasColumnType("text")
                        .HasColumnName("updated_by");

                    b.HasKey("Id")
                        .HasName("pk_line_items");

                    b.HasIndex("OrderId")
                        .HasDatabaseName("ix_line_items_order_id");

                    b.HasIndex("ProductId")
                        .HasDatabaseName("ix_line_items_product_id");

                    b.ToTable("line_items", (string)null);
                });

            modelBuilder.Entity("Domain.Orders.Order", b =>
                {
                    b.Property<Guid>("Id")
                        .HasColumnType("uuid")
                        .HasColumnName("id");

                    b.Property<DateTimeOffset>("CreatedAt")
                        .HasColumnType("timestamp with time zone")
                        .HasColumnName("created_at");

                    b.Property<string>("CreatedBy")
                        .HasColumnType("text")
                        .HasColumnName("created_by");

                    b.Property<Guid>("CustomerId")
                        .HasColumnType("uuid")
                        .HasColumnName("customer_id");

                    b.Property<DateTimeOffset?>("UpdatedAt")
                        .HasColumnType("timestamp with time zone")
                        .HasColumnName("updated_at");

                    b.Property<string>("UpdatedBy")
                        .HasColumnType("text")
                        .HasColumnName("updated_by");

                    b.HasKey("Id")
                        .HasName("pk_orders");

                    b.HasIndex("CustomerId")
                        .HasDatabaseName("ix_orders_customer_id");

                    b.ToTable("orders", (string)null);
                });

            modelBuilder.Entity("Domain.Orders.OrderSummary", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uuid")
                        .HasColumnName("id");

                    b.Property<string>("CustomerFirstName")
                        .IsRequired()
                        .HasColumnType("text")
                        .HasColumnName("customer_first_name");

                    b.Property<Guid>("CustomerId")
                        .HasColumnType("uuid")
                        .HasColumnName("customer_id");

                    b.Property<List<OrderSummary.LineItem>>("LineItems")
                        .IsRequired()
                        .HasColumnType("jsonb")
                        .HasColumnName("line_items");

                    b.Property<decimal>("TotalPrice")
                        .HasColumnType("numeric")
                        .HasColumnName("total_price");

                    b.HasKey("Id")
                        .HasName("pk_order_summaries");

                    b.ToTable("order_summaries", (string)null);
                });

            modelBuilder.Entity("Domain.Products.Product", b =>
                {
                    b.Property<Guid>("Id")
                        .HasColumnType("uuid")
                        .HasColumnName("id");

                    b.Property<Guid>("CategoryId")
                        .HasColumnType("uuid")
                        .HasColumnName("category_id");

                    b.Property<DateTimeOffset>("CreatedAt")
                        .HasColumnType("timestamp with time zone")
                        .HasColumnName("created_at");

                    b.Property<string>("CreatedBy")
                        .HasColumnType("text")
                        .HasColumnName("created_by");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("text")
                        .HasColumnName("name");

                    b.Property<string>("Sku")
                        .IsRequired()
                        .HasColumnType("text")
                        .HasColumnName("sku");

                    b.Property<DateTimeOffset?>("UpdatedAt")
                        .HasColumnType("timestamp with time zone")
                        .HasColumnName("updated_at");

                    b.Property<string>("UpdatedBy")
                        .HasColumnType("text")
                        .HasColumnName("updated_by");

                    b.HasKey("Id")
                        .HasName("pk_products");

                    b.HasIndex("CategoryId")
                        .HasDatabaseName("ix_products_category_id");

                    b.ToTable("products", (string)null);
                });

            modelBuilder.Entity("Domain.Blogs.BlogPost", b =>
                {
                    b.HasOne("Domain.Customers.Customer", null)
                        .WithMany()
                        .HasForeignKey("CustomerId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired()
                        .HasConstraintName("fk_blog_posts_customers_customer_id");
                });

            modelBuilder.Entity("Domain.Blogs.BlogPostComment", b =>
                {
                    b.HasOne("Domain.Blogs.BlogPost", null)
                        .WithMany("BlogPostComments")
                        .HasForeignKey("BlogPostId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired()
                        .HasConstraintName("fk_blog_post_comments_blog_posts_blog_post_id");

                    b.HasOne("Domain.Customers.Customer", null)
                        .WithMany()
                        .HasForeignKey("CustomerId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired()
                        .HasConstraintName("fk_blog_post_comments_customers_customer_id");
                });

            modelBuilder.Entity("Domain.Customers.Customer", b =>
                {
                    b.OwnsOne("Domain.Customers.Address", "Address", b1 =>
                        {
                            b1.Property<Guid>("CustomerId")
                                .HasColumnType("uuid")
                                .HasColumnName("id");

                            b1.HasKey("CustomerId");

                            b1.ToTable("customers");

                            b1.WithOwner()
                                .HasForeignKey("CustomerId")
                                .HasConstraintName("fk_customers_customers_id");
                        });

                    b.Navigation("Address");
                });

            modelBuilder.Entity("Domain.Orders.LineItem", b =>
                {
                    b.HasOne("Domain.Orders.Order", null)
                        .WithMany("LineItems")
                        .HasForeignKey("OrderId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired()
                        .HasConstraintName("fk_line_items_orders_order_id");

                    b.HasOne("Domain.Products.Product", null)
                        .WithMany()
                        .HasForeignKey("ProductId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired()
                        .HasConstraintName("fk_line_items_products_product_id");

                    b.OwnsOne("Domain.Products.Money", "Price", b1 =>
                        {
                            b1.Property<Guid>("LineItemId")
                                .HasColumnType("uuid")
                                .HasColumnName("id");

                            b1.Property<decimal>("Amount")
                                .HasColumnType("numeric")
                                .HasColumnName("price_amount");

                            b1.Property<string>("Currency")
                                .IsRequired()
                                .HasColumnType("text")
                                .HasColumnName("price_currency");

                            b1.HasKey("LineItemId");

                            b1.ToTable("line_items");

                            b1.WithOwner()
                                .HasForeignKey("LineItemId")
                                .HasConstraintName("fk_line_items_line_items_id");
                        });

                    b.Navigation("Price")
                        .IsRequired();
                });

            modelBuilder.Entity("Domain.Orders.Order", b =>
                {
                    b.HasOne("Domain.Customers.Customer", null)
                        .WithMany()
                        .HasForeignKey("CustomerId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired()
                        .HasConstraintName("fk_orders_customers_customer_id");
                });

            modelBuilder.Entity("Domain.Products.Product", b =>
                {
                    b.HasOne("Domain.Categories.Category", null)
                        .WithMany()
                        .HasForeignKey("CategoryId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired()
                        .HasConstraintName("fk_products_categories_category_id");

                    b.OwnsOne("Domain.Products.Money", "Price", b1 =>
                        {
                            b1.Property<Guid>("ProductId")
                                .HasColumnType("uuid")
                                .HasColumnName("id");

                            b1.Property<decimal>("Amount")
                                .HasColumnType("numeric")
                                .HasColumnName("price_amount");

                            b1.Property<string>("Currency")
                                .IsRequired()
                                .HasMaxLength(3)
                                .HasColumnType("character varying(3)")
                                .HasColumnName("price_currency");

                            b1.HasKey("ProductId");

                            b1.ToTable("products");

                            b1.WithOwner()
                                .HasForeignKey("ProductId")
                                .HasConstraintName("fk_products_products_id");
                        });

                    b.Navigation("Price")
                        .IsRequired();
                });

            modelBuilder.Entity("Domain.Blogs.BlogPost", b =>
                {
                    b.Navigation("BlogPostComments");
                });

            modelBuilder.Entity("Domain.Orders.Order", b =>
                {
                    b.Navigation("LineItems");
                });
#pragma warning restore 612, 618
        }
    }
}

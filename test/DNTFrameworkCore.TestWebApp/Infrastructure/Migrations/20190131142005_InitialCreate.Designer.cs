﻿// <auto-generated />
using System;
using DNTFrameworkCore.TestWebApp.Infrastructure.Context;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace DNTFrameworkCore.TestWebApp.Infrastructure.Migrations
{
    [DbContext(typeof(ProjectDbContext))]
    [Migration("20190131142005_InitialCreate")]
    partial class InitialCreate
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.2.1-servicing-10028")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("DNTFrameworkCore.TestWebApp.Domain.Blog", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<DateTimeOffset>("CreationDateTime");

                    b.Property<string>("CreatorBrowserName")
                        .HasMaxLength(1024);

                    b.Property<string>("CreatorIp")
                        .HasMaxLength(256);

                    b.Property<long?>("CreatorUserId");

                    b.Property<DateTimeOffset?>("LastModificationDateTime");

                    b.Property<string>("LastModifierBrowserName")
                        .HasMaxLength(1024);

                    b.Property<string>("LastModifierIp")
                        .HasMaxLength(256);

                    b.Property<long?>("LastModifierUserId");

                    b.Property<string>("NormalizedTitle")
                        .IsRequired()
                        .HasMaxLength(50);

                    b.Property<byte[]>("RowVersion")
                        .IsConcurrencyToken()
                        .ValueGeneratedOnAddOrUpdate();

                    b.Property<string>("Title")
                        .IsRequired()
                        .HasMaxLength(50);

                    b.Property<string>("Url")
                        .IsRequired()
                        .HasMaxLength(50);

                    b.HasKey("Id");

                    b.HasIndex("NormalizedTitle")
                        .IsUnique()
                        .HasName("Blog_NormalizedTitle");

                    b.ToTable("Blog");
                });
#pragma warning restore 612, 618
        }
    }
}

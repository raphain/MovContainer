﻿// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using MovContainer.Models;

namespace MovContainer.Migrations
{
    [DbContext(typeof(Context))]
    [Migration("20210331160854_fix3103211308")]
    partial class fix3103211308
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("ProductVersion", "5.0.4")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("MovContainer.Models.Container", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Client")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("ContainerCategoryId")
                        .HasColumnType("int");

                    b.Property<int>("ContainerStatusId")
                        .HasColumnType("int");

                    b.Property<int>("ContainerTypeId")
                        .HasColumnType("int");

                    b.Property<string>("Number")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("ContainerCategoryId");

                    b.HasIndex("ContainerStatusId");

                    b.HasIndex("ContainerTypeId");

                    b.ToTable("Container");
                });

            modelBuilder.Entity("MovContainer.Models.ContainerCategory", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Description")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("ContainerCategory");
                });

            modelBuilder.Entity("MovContainer.Models.ContainerStatus", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Description")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("ContainerStatus");
                });

            modelBuilder.Entity("MovContainer.Models.ContainerType", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Description")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("ContainerTypes");
                });

            modelBuilder.Entity("MovContainer.Models.Container", b =>
                {
                    b.HasOne("MovContainer.Models.ContainerCategory", "Category")
                        .WithMany("Containers")
                        .HasForeignKey("ContainerCategoryId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("MovContainer.Models.ContainerStatus", "Status")
                        .WithMany("Containers")
                        .HasForeignKey("ContainerStatusId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("MovContainer.Models.ContainerType", "ContainerType")
                        .WithMany("Containers")
                        .HasForeignKey("ContainerTypeId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Category");

                    b.Navigation("ContainerType");

                    b.Navigation("Status");
                });

            modelBuilder.Entity("MovContainer.Models.ContainerCategory", b =>
                {
                    b.Navigation("Containers");
                });

            modelBuilder.Entity("MovContainer.Models.ContainerStatus", b =>
                {
                    b.Navigation("Containers");
                });

            modelBuilder.Entity("MovContainer.Models.ContainerType", b =>
                {
                    b.Navigation("Containers");
                });
#pragma warning restore 612, 618
        }
    }
}
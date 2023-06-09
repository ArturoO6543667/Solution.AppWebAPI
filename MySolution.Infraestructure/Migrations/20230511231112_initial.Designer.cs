﻿// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using MySolution.Infraestructure;

#nullable disable

namespace MySolution.Infraestructure.Migrations
{
    [DbContext(typeof(MySolutionDataContext))]
    [Migration("20230511231112_initial")]
    partial class initial
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.5")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("MySolution.Infraestructure.Entities.MusicEntity", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Genre")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<bool>("IsDeleted")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bit")
                        .HasDefaultValue(false);

                    b.Property<string>("Title")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.HasKey("Id");

                    b.ToTable("Music", "dbo");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Genre = "Rock",
                            Title = "Do I Wanna Know"
                        },
                        new
                        {
                            Id = 2,
                            Genre = "Rock",
                            Title = "Shape of My Heart"
                        },
                        new
                        {
                            Id = 3,
                            Genre = "Rock",
                            Title = "Still loving you"
                        },
                        new
                        {
                            Id = 4,
                            Genre = "Rock",
                            Title = "Dream on"
                        });
                });
#pragma warning restore 612, 618
        }
    }
}

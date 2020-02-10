﻿// <auto-generated />
using CRUDLivros.Database;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace CRUDLivros.Migrations
{
    [DbContext(typeof(ApplicationDbContext))]
    partial class ApplicationDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "3.1.1")
                .HasAnnotation("Relational:MaxIdentifierLength", 64);

            modelBuilder.Entity("CRUDLivros.Models.Livro", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<int>("Ano")
                        .HasColumnType("int");

                    b.Property<string>("Autor")
                        .HasColumnType("longtext CHARACTER SET utf8mb4");

                    b.Property<string>("Editora")
                        .HasColumnType("longtext CHARACTER SET utf8mb4");

                    b.Property<string>("Genero")
                        .HasColumnType("longtext CHARACTER SET utf8mb4");

                    b.Property<string>("Titulo")
                        .HasColumnType("longtext CHARACTER SET utf8mb4");

                    b.HasKey("Id");

                    b.ToTable("Livros");
                });
#pragma warning restore 612, 618
        }
    }
}

﻿// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using ModuloConsultas.Connection;

namespace ModuloConsultas.Migrations
{
    [DbContext(typeof(Conn))]
    [Migration("20211114040955_Migra2")]
    partial class Migra2
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("ProductVersion", "5.0.8")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("ModuloConsultas.Models.ProductoModel", b =>
                {
                    b.Property<int>("CodigoProducto")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("CantidadProducto")
                        .HasColumnType("int");

                    b.Property<int>("CodigoProveedor")
                        .HasColumnType("int");

                    b.Property<string>("EstadoProducto")
                        .HasColumnType("varchar(5)");

                    b.Property<string>("FechaIngreso")
                        .IsRequired()
                        .HasColumnType("varchar(35)");

                    b.Property<string>("FechaVencimiento")
                        .IsRequired()
                        .HasColumnType("varchar(35)");

                    b.Property<string>("NombreProducto")
                        .IsRequired()
                        .HasColumnType("varchar(35)");

                    b.Property<string>("NombreProveedor")
                        .IsRequired()
                        .HasColumnType("varchar(35)");

                    b.HasKey("CodigoProducto");

                    b.ToTable("Productos");
                });
#pragma warning restore 612, 618
        }
    }
}
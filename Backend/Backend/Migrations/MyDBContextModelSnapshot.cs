﻿// <auto-generated />
using System;
using Backend.Context;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace Backend.Migrations
{
    [DbContext(typeof(MyDBContext))]
    partial class MyDBContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Relational:MaxIdentifierLength", 64)
                .HasAnnotation("ProductVersion", "5.0.17");

            modelBuilder.Entity("Backend.Modelo.OrdenProduccion", b =>
                {
                    b.Property<int>("NroOrden")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<DateTime>("FechaFin")
                        .HasColumnType("datetime");

                    b.Property<DateTime>("FechaInicio")
                        .HasColumnType("datetime");

                    b.HasKey("NroOrden");

                    b.ToTable("OrdenesProduccion");
                });

            modelBuilder.Entity("Backend.Modelo.User", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<DateTime>("CreationDateTime")
                        .HasColumnType("datetime");

                    b.Property<string>("FirstName")
                        .IsRequired()
                        .HasColumnType("nvarchar(50)");

                    b.Property<string>("LastName")
                        .IsRequired()
                        .HasColumnType("nvarchar(50)");

                    b.Property<DateTime?>("LastUpdateDateTime")
                        .HasColumnType("datetime");

                    b.Property<int>("UserGroupId")
                        .HasColumnType("int");

                    b.HasKey("Id")
                        .HasName("PK_Users");

                    b.HasIndex("FirstName")
                        .HasDatabaseName("Idx_FirstName");

                    b.HasIndex("LastName")
                        .HasDatabaseName("Idx_LastName");

                    b.ToTable("Users");
                });
#pragma warning restore 612, 618
        }
    }
}
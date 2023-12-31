﻿// <auto-generated />
using System;
using FullStackNET.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace FullStackNET.Migrations
{
    [DbContext(typeof(FullStackDbContext))]
    [Migration("20230813002519_Initial Migration")]
    partial class InitialMigration
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.10")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("FullStackNET.Models.Employee", b =>
                {
                    b.Property<string>("Area")
                        .HasColumnType("nvarchar(max)");

                    b.Property<Guid>("Codigo")
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Correo")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Nombre")
                        .HasColumnType("nvarchar(max)");

                    b.Property<long>("Salario")
                        .HasColumnType("bigint");

                    b.Property<long>("Telefono")
                        .HasColumnType("bigint");

                    b.ToTable("Employees");
                });
#pragma warning restore 612, 618
        }
    }
}

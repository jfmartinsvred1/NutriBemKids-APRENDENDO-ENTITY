﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using NutriBemKids.Contexto;

#nullable disable

namespace NutriBemKids.Migrations
{
    [DbContext(typeof(NutribemContext))]
    [Migration("20230802195904_Inicial")]
    partial class Inicial
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.9")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("NutriBemKids.Negocios.Alunos", b =>
                {
                    b.Property<Guid>("CodigoID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier")
                        .HasColumnName("CodigoID");

                    b.Property<decimal>("Mensalidade")
                        .HasColumnType("decimal(18,2)")
                        .HasColumnName("Preco");

                    b.Property<string>("Nome")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)")
                        .HasColumnName("Nome");

                    b.Property<string>("NomeMae")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)")
                        .HasColumnName("NomeMae");

                    b.HasKey("CodigoID");

                    b.ToTable("AssinaturaNutribem", (string)null);
                });
#pragma warning restore 612, 618
        }
    }
}

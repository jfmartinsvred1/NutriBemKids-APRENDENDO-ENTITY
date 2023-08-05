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
    [Migration("20230805022813_QntdFilhos")]
    partial class QntdFilhos
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.9")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("NutriBemKids.Mae", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<Guid>("FilhoCodigoID")
                        .HasColumnType("uniqueidentifier");

                    b.Property<double>("Mensalidade")
                        .HasColumnType("float");

                    b.Property<string>("Nome")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("QuantidadeFilhos")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("FilhoCodigoID");

                    b.ToTable("Maes");
                });

            modelBuilder.Entity("NutriBemKids.Negocios.Alunos", b =>
                {
                    b.Property<Guid>("CodigoID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier")
                        .HasColumnName("CodigoID");

                    b.Property<string>("Nome")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)")
                        .HasColumnName("Nome");

                    b.HasKey("CodigoID");

                    b.ToTable("AssinaturaNutribem", (string)null);
                });

            modelBuilder.Entity("NutriBemKids.Negocios.Estoque", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier")
                        .HasColumnName("Id");

                    b.Property<DateTime>("Data")
                        .HasColumnType("datetime2")
                        .HasColumnName("Data");

                    b.Property<string>("Nome")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)")
                        .HasColumnName("Nome");

                    b.Property<int>("Quantidade")
                        .HasColumnType("int")
                        .HasColumnName("Quantidade");

                    b.Property<string>("Tipo")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)")
                        .HasColumnName("Tipo");

                    b.Property<double>("ValorUnitario")
                        .HasColumnType("float")
                        .HasColumnName("ValorUnitario");

                    b.HasKey("Id");

                    b.ToTable("EstoqueNutribem", (string)null);
                });

            modelBuilder.Entity("NutriBemKids.Mae", b =>
                {
                    b.HasOne("NutriBemKids.Negocios.Alunos", "Filho")
                        .WithMany()
                        .HasForeignKey("FilhoCodigoID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Filho");
                });
#pragma warning restore 612, 618
        }
    }
}

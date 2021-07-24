﻿// <auto-generated />
using DesafioTecnicoSTi3.data.Context;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace DesafioTecnicoSTi3.data.Migrations
{
    [DbContext(typeof(DesafioTecnicoSTi3Context))]
    [Migration("20210723190140_Inicio")]
    partial class Inicio
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Relational:MaxIdentifierLength", 64)
                .HasAnnotation("ProductVersion", "5.0.8");

            modelBuilder.Entity("DesafioTecnicoSTi3.data.Entidades.Clientes", b =>
                {
                    b.Property<long>("id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint");

                    b.Property<string>("cnpj")
                        .HasColumnType("varchar(100)");

                    b.Property<string>("cpf")
                        .HasColumnType("varchar(100)");

                    b.Property<string>("dataNascimento")
                        .IsRequired()
                        .HasColumnType("varchar(100)");

                    b.Property<string>("email")
                        .HasColumnType("varchar(100)");

                    b.Property<string>("nome")
                        .HasColumnType("varchar(100)");

                    b.Property<string>("razaoSocial")
                        .HasColumnType("varchar(100)");

                    b.HasKey("id");

                    b.ToTable("Clientes");
                });

            modelBuilder.Entity("DesafioTecnicoSTi3.data.Entidades.Configuracoes", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<string>("UrlAPI")
                        .HasColumnType("varchar(100)");

                    b.HasKey("Id");

                    b.ToTable("Configuracoes");
                });
#pragma warning restore 612, 618
        }
    }
}
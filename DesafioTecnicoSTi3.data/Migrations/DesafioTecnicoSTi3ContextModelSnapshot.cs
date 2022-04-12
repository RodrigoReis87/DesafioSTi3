﻿// <auto-generated />
using System;
using DesafioTecnicoSTi3.data.Context;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace DesafioTecnicoSTi3.data.Migrations
{
    [DbContext(typeof(DesafioTecnicoSTi3Context))]
    partial class DesafioTecnicoSTi3ContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Relational:MaxIdentifierLength", 64)
                .HasAnnotation("ProductVersion", "5.0.8");

            modelBuilder.Entity("DesafioTecnicoSTi3.data.Entidades.Clientes", b =>
                {
                    b.Property<string>("id")
                        .HasColumnType("varchar(200)");

                    b.Property<string>("cnpj")
                        .HasColumnType("varchar (20)");

                    b.Property<string>("cpf")
                        .HasColumnType("varchar (20)");

                    b.Property<DateTime>("dataNascimento")
                        .HasColumnType("datetime");

                    b.Property<string>("email")
                        .HasColumnType("varchar (70)");

                    b.Property<string>("nome")
                        .HasColumnType("varchar (100)");

                    b.Property<string>("razaoSocial")
                        .HasColumnType("varchar (100)");

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

            modelBuilder.Entity("DesafioTecnicoSTi3.data.Entidades.EnderecoEntrega", b =>
                {
                    b.Property<long>("codigo")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint");

                    b.Property<string>("bairro")
                        .HasColumnType("varchar(150)");

                    b.Property<string>("cep")
                        .HasColumnType("varchar(15)");

                    b.Property<string>("cidade")
                        .HasColumnType("varchar(70)");

                    b.Property<string>("complemento")
                        .HasColumnType("varchar(150)");

                    b.Property<string>("endereco")
                        .HasColumnType("varchar(150)");

                    b.Property<string>("estado")
                        .HasColumnType("varchar(30)");

                    b.Property<string>("id")
                        .HasColumnType("varchar(20)");

                    b.Property<string>("numero")
                        .HasColumnType("varchar(20)");

                    b.Property<string>("referencia")
                        .HasColumnType("varchar(150)");

                    b.HasKey("codigo");

                    b.ToTable("EnderecoEntregas");
                });

            modelBuilder.Entity("DesafioTecnicoSTi3.data.Entidades.Item", b =>
                {
                    b.Property<long>("codigo_item")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint");

                    b.Property<string>("id")
                        .HasColumnType("text");

                    b.Property<string>("idPedido")
                        .HasColumnType("text");

                    b.Property<string>("idProduto")
                        .HasColumnType("text");

                    b.Property<string>("nome")
                        .HasColumnType("text");

                    b.Property<long?>("pedidocod_pedido")
                        .HasColumnType("bigint");

                    b.Property<int>("quantidade")
                        .HasColumnType("int");

                    b.Property<double>("valorUnitario")
                        .HasColumnType("double");

                    b.HasKey("codigo_item");

                    b.HasIndex("pedidocod_pedido");

                    b.ToTable("Itens");
                });

            modelBuilder.Entity("DesafioTecnicoSTi3.data.Entidades.Pagamento", b =>
                {
                    b.Property<long>("cod_pgto")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint");

                    b.Property<long>("IdPedido")
                        .HasColumnType("bigint");

                    b.Property<string>("codigo")
                        .HasColumnType("text");

                    b.Property<string>("id")
                        .HasColumnType("text");

                    b.Property<string>("nome")
                        .HasColumnType("text");

                    b.Property<int>("parcela")
                        .HasColumnType("int");

                    b.Property<long?>("pedidocod_pedido")
                        .HasColumnType("bigint");

                    b.Property<double>("valor")
                        .HasColumnType("double");

                    b.HasKey("cod_pgto");

                    b.HasIndex("pedidocod_pedido");

                    b.ToTable("Pagamento");
                });

            modelBuilder.Entity("DesafioTecnicoSTi3.data.Entidades.Pedido", b =>
                {
                    b.Property<long>("cod_pedido")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint");

                    b.Property<string>("clienteid")
                        .HasColumnType("varchar(200)");

                    b.Property<DateTime>("dataAlteracao")
                        .HasColumnType("datetime");

                    b.Property<DateTime>("dataCriacao")
                        .HasColumnType("datetime");

                    b.Property<double>("desconto")
                        .HasColumnType("double(6,2)");

                    b.Property<long?>("enderecoEntregacodigo")
                        .HasColumnType("bigint");

                    b.Property<double>("frete")
                        .HasColumnType("double(6,2)");

                    b.Property<string>("id")
                        .HasColumnType("varchar(100)");

                    b.Property<string>("numero")
                        .HasColumnType("varchar(30)");

                    b.Property<string>("status")
                        .HasColumnType("varchar(30)");

                    b.Property<double>("subTotal")
                        .HasColumnType("double(6,2)");

                    b.Property<double>("valorTotal")
                        .HasColumnType("double(6,2)");

                    b.HasKey("cod_pedido");

                    b.HasIndex("clienteid");

                    b.HasIndex("enderecoEntregacodigo");

                    b.ToTable("Pedidos");
                });

            modelBuilder.Entity("DesafioTecnicoSTi3.data.Entidades.Item", b =>
                {
                    b.HasOne("DesafioTecnicoSTi3.data.Entidades.Pedido", "pedido")
                        .WithMany("itens")
                        .HasForeignKey("pedidocod_pedido");

                    b.Navigation("pedido");
                });

            modelBuilder.Entity("DesafioTecnicoSTi3.data.Entidades.Pagamento", b =>
                {
                    b.HasOne("DesafioTecnicoSTi3.data.Entidades.Pedido", "pedido")
                        .WithMany("pagamento")
                        .HasForeignKey("pedidocod_pedido");

                    b.Navigation("pedido");
                });

            modelBuilder.Entity("DesafioTecnicoSTi3.data.Entidades.Pedido", b =>
                {
                    b.HasOne("DesafioTecnicoSTi3.data.Entidades.Clientes", "cliente")
                        .WithMany("pedido")
                        .HasForeignKey("clienteid");

                    b.HasOne("DesafioTecnicoSTi3.data.Entidades.EnderecoEntrega", "enderecoEntrega")
                        .WithMany()
                        .HasForeignKey("enderecoEntregacodigo");

                    b.Navigation("cliente");

                    b.Navigation("enderecoEntrega");
                });

            modelBuilder.Entity("DesafioTecnicoSTi3.data.Entidades.Clientes", b =>
                {
                    b.Navigation("pedido");
                });

            modelBuilder.Entity("DesafioTecnicoSTi3.data.Entidades.Pedido", b =>
                {
                    b.Navigation("itens");

                    b.Navigation("pagamento");
                });
#pragma warning restore 612, 618
        }
    }
}

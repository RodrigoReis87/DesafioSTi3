using Microsoft.EntityFrameworkCore.Migrations;
using MySql.EntityFrameworkCore.Metadata;
using System;

namespace DesafioTecnicoSTi3.data.Migrations
{
    public partial class Inicio : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Clientes",
                columns: table => new
                {
                    codigo_cliente = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("MySQL:ValueGenerationStrategy", MySQLValueGenerationStrategy.IdentityColumn),
                    id = table.Column<string>(type: "text", nullable: true),
                    cnpj = table.Column<string>(type: "text", nullable: true),
                    cpf = table.Column<string>(type: "text", nullable: true),
                    nome = table.Column<string>(type: "text", nullable: true),
                    razaoSocial = table.Column<string>(type: "text", nullable: true),
                    email = table.Column<string>(type: "text", nullable: true),
                    dataNascimento = table.Column<DateTime>(type: "datetime", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Clientes", x => x.codigo_cliente);
                });

            migrationBuilder.CreateTable(
                name: "Configuracoes",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySQL:ValueGenerationStrategy", MySQLValueGenerationStrategy.IdentityColumn),
                    UrlAPI = table.Column<string>(type: "varchar(100)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Configuracoes", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "EnderecoEntregas",
                columns: table => new
                {
                    codigo = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("MySQL:ValueGenerationStrategy", MySQLValueGenerationStrategy.IdentityColumn),
                    id = table.Column<string>(type: "text", nullable: true),
                    endereco = table.Column<string>(type: "text", nullable: true),
                    numero = table.Column<string>(type: "text", nullable: true),
                    cep = table.Column<string>(type: "text", nullable: true),
                    bairro = table.Column<string>(type: "text", nullable: true),
                    cidade = table.Column<string>(type: "text", nullable: true),
                    estado = table.Column<string>(type: "text", nullable: true),
                    complemento = table.Column<string>(type: "text", nullable: true),
                    referencia = table.Column<string>(type: "text", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_EnderecoEntregas", x => x.codigo);
                });

            migrationBuilder.CreateTable(
                name: "Pedidos",
                columns: table => new
                {
                    cod_pedido = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("MySQL:ValueGenerationStrategy", MySQLValueGenerationStrategy.IdentityColumn),
                    id = table.Column<string>(type: "text", nullable: true),
                    numero = table.Column<string>(type: "text", nullable: true),
                    dataCriacao = table.Column<DateTime>(type: "datetime", nullable: false),
                    dataAlteracao = table.Column<DateTime>(type: "datetime", nullable: false),
                    status = table.Column<string>(type: "text", nullable: true),
                    desconto = table.Column<double>(type: "double", nullable: false),
                    frete = table.Column<double>(type: "double", nullable: false),
                    subTotal = table.Column<double>(type: "double", nullable: false),
                    valorTotal = table.Column<double>(type: "double", nullable: false),
                    clientecodigo_cliente = table.Column<long>(type: "bigint", nullable: true),
                    enderecoEntregacodigo = table.Column<long>(type: "bigint", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Pedidos", x => x.cod_pedido);
                    table.ForeignKey(
                        name: "FK_Pedidos_Clientes_clientecodigo_cliente",
                        column: x => x.clientecodigo_cliente,
                        principalTable: "Clientes",
                        principalColumn: "codigo_cliente",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Pedidos_EnderecoEntregas_enderecoEntregacodigo",
                        column: x => x.enderecoEntregacodigo,
                        principalTable: "EnderecoEntregas",
                        principalColumn: "codigo",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Itens",
                columns: table => new
                {
                    codigo_item = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("MySQL:ValueGenerationStrategy", MySQLValueGenerationStrategy.IdentityColumn),
                    id = table.Column<string>(type: "text", nullable: true),
                    idProduto = table.Column<string>(type: "text", nullable: true),
                    idPedido = table.Column<string>(type: "text", nullable: true),
                    nome = table.Column<string>(type: "text", nullable: true),
                    quantidade = table.Column<int>(type: "int", nullable: false),
                    valorUnitario = table.Column<double>(type: "double", nullable: false),
                    pedidocod_pedido = table.Column<long>(type: "bigint", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Itens", x => x.codigo_item);
                    table.ForeignKey(
                        name: "FK_Itens_Pedidos_pedidocod_pedido",
                        column: x => x.pedidocod_pedido,
                        principalTable: "Pedidos",
                        principalColumn: "cod_pedido",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Pagamento",
                columns: table => new
                {
                    cod_pgto = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("MySQL:ValueGenerationStrategy", MySQLValueGenerationStrategy.IdentityColumn),
                    id = table.Column<string>(type: "text", nullable: true),
                    parcela = table.Column<int>(type: "int", nullable: false),
                    valor = table.Column<double>(type: "double", nullable: false),
                    codigo = table.Column<string>(type: "text", nullable: true),
                    nome = table.Column<string>(type: "text", nullable: true),
                    IdPedido = table.Column<long>(type: "bigint", nullable: false),
                    pedidocod_pedido = table.Column<long>(type: "bigint", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Pagamento", x => x.cod_pgto);
                    table.ForeignKey(
                        name: "FK_Pagamento_Pedidos_pedidocod_pedido",
                        column: x => x.pedidocod_pedido,
                        principalTable: "Pedidos",
                        principalColumn: "cod_pedido",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Itens_pedidocod_pedido",
                table: "Itens",
                column: "pedidocod_pedido");

            migrationBuilder.CreateIndex(
                name: "IX_Pagamento_pedidocod_pedido",
                table: "Pagamento",
                column: "pedidocod_pedido");

            migrationBuilder.CreateIndex(
                name: "IX_Pedidos_clientecodigo_cliente",
                table: "Pedidos",
                column: "clientecodigo_cliente");

            migrationBuilder.CreateIndex(
                name: "IX_Pedidos_enderecoEntregacodigo",
                table: "Pedidos",
                column: "enderecoEntregacodigo");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Configuracoes");

            migrationBuilder.DropTable(
                name: "Itens");

            migrationBuilder.DropTable(
                name: "Pagamento");

            migrationBuilder.DropTable(
                name: "Pedidos");

            migrationBuilder.DropTable(
                name: "Clientes");

            migrationBuilder.DropTable(
                name: "EnderecoEntregas");
        }
    }
}

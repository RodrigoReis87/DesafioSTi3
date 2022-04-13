using System;
using Microsoft.EntityFrameworkCore.Migrations;
using MySql.EntityFrameworkCore.Metadata;

namespace DesafioTecnicoSTi3.data.Migrations
{
    public partial class Teste : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Clientes",
                columns: table => new
                {
                    id = table.Column<string>(type: "varchar(200)", nullable: false),
                    cnpj = table.Column<string>(type: "varchar (20)", nullable: true),
                    cpf = table.Column<string>(type: "varchar (20)", nullable: true),
                    nome = table.Column<string>(type: "varchar (100)", nullable: true),
                    razaoSocial = table.Column<string>(type: "varchar (100)", nullable: true),
                    email = table.Column<string>(type: "varchar (70)", nullable: true),
                    dataNascimento = table.Column<DateTime>(type: "datetime", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Clientes", x => x.id);
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
                    id = table.Column<string>(type: "varchar(50)", nullable: true),
                    endereco = table.Column<string>(type: "varchar(150)", nullable: true),
                    numero = table.Column<string>(type: "varchar(20)", nullable: true),
                    cep = table.Column<string>(type: "varchar(15)", nullable: true),
                    bairro = table.Column<string>(type: "varchar(150)", nullable: true),
                    cidade = table.Column<string>(type: "varchar(70)", nullable: true),
                    estado = table.Column<string>(type: "varchar(30)", nullable: true),
                    complemento = table.Column<string>(type: "varchar(150)", nullable: true),
                    referencia = table.Column<string>(type: "varchar(150)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_EnderecoEntregas", x => x.codigo);
                });

            migrationBuilder.CreateTable(
                name: "Formas_Pagto",
                columns: table => new
                {
                    cod_pgto = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("MySQL:ValueGenerationStrategy", MySQLValueGenerationStrategy.IdentityColumn),
                    id = table.Column<string>(type: "text", nullable: true),
                    parcela = table.Column<int>(type: "int", nullable: false),
                    valor = table.Column<double>(type: "double", nullable: false),
                    codigo = table.Column<string>(type: "text", nullable: true),
                    nome = table.Column<string>(type: "text", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Formas_Pagto", x => x.cod_pgto);
                });

            migrationBuilder.CreateTable(
                name: "Itens",
                columns: table => new
                {
                    idProduto = table.Column<string>(type: "varchar(767)", nullable: false),
                    codigo_item = table.Column<long>(type: "bigint", nullable: false),
                    id = table.Column<string>(type: "text", nullable: true),
                    idPedido = table.Column<string>(type: "text", nullable: true),
                    nome = table.Column<string>(type: "text", nullable: true),
                    quantidade = table.Column<int>(type: "int", nullable: false),
                    valorUnitario = table.Column<double>(type: "double", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Itens", x => x.idProduto);
                });

            migrationBuilder.CreateTable(
                name: "Pedidos",
                columns: table => new
                {
                    cod_pedido = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("MySQL:ValueGenerationStrategy", MySQLValueGenerationStrategy.IdentityColumn),
                    id = table.Column<string>(type: "varchar(100)", nullable: true),
                    numero = table.Column<string>(type: "varchar(30)", nullable: true),
                    dataCriacao = table.Column<DateTime>(type: "datetime", nullable: false),
                    dataAlteracao = table.Column<DateTime>(type: "datetime", nullable: false),
                    status = table.Column<string>(type: "varchar(30)", nullable: true),
                    desconto = table.Column<double>(type: "double(6,2)", nullable: false),
                    frete = table.Column<double>(type: "double(6,2)", nullable: false),
                    subTotal = table.Column<double>(type: "double(6,2)", nullable: false),
                    valorTotal = table.Column<double>(type: "double(6,2)", nullable: false),
                    clienteid = table.Column<string>(type: "varchar(200)", nullable: true),
                    enderecoEntregacodigo = table.Column<long>(type: "bigint", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Pedidos", x => x.cod_pedido);
                    table.ForeignKey(
                        name: "FK_Pedido_Cliente",
                        column: x => x.clienteid,
                        principalTable: "Clientes",
                        principalColumn: "id");
                    table.ForeignKey(
                        name: "FK_Pedidos_EnderecoEntregas_enderecoEntregacodigo",
                        column: x => x.enderecoEntregacodigo,
                        principalTable: "EnderecoEntregas",
                        principalColumn: "codigo",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Itens_pedido",
                columns: table => new
                {
                    ItemId = table.Column<long>(type: "bigint", nullable: false),
                    PedidoId = table.Column<string>(type: "varchar(767)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Itens_pedido", x => new { x.ItemId, x.PedidoId });
                    table.ForeignKey(
                        name: "FK_Itens_pedido_ItemId",
                        column: x => x.ItemId,
                        principalTable: "Pedidos",
                        principalColumn: "cod_pedido",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Itens_pedido_PedidoId",
                        column: x => x.PedidoId,
                        principalTable: "Itens",
                        principalColumn: "idProduto",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Pagamento_pedido",
                columns: table => new
                {
                    PagtoId = table.Column<long>(type: "bigint", nullable: false),
                    PedidoId = table.Column<long>(type: "bigint", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Pagamento_pedido", x => new { x.PagtoId, x.PedidoId });
                    table.ForeignKey(
                        name: "FK_Pagamento_pedido_PagtoId",
                        column: x => x.PagtoId,
                        principalTable: "Formas_Pagto",
                        principalColumn: "cod_pgto",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Pagamento_pedido_PedidoId",
                        column: x => x.PedidoId,
                        principalTable: "Pedidos",
                        principalColumn: "cod_pedido",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Itens_pedido_PedidoId",
                table: "Itens_pedido",
                column: "PedidoId");

            migrationBuilder.CreateIndex(
                name: "IX_Pagamento_pedido_PedidoId",
                table: "Pagamento_pedido",
                column: "PedidoId");

            migrationBuilder.CreateIndex(
                name: "IX_Pedidos_clienteid",
                table: "Pedidos",
                column: "clienteid");

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
                name: "Itens_pedido");

            migrationBuilder.DropTable(
                name: "Pagamento_pedido");

            migrationBuilder.DropTable(
                name: "Itens");

            migrationBuilder.DropTable(
                name: "Formas_Pagto");

            migrationBuilder.DropTable(
                name: "Pedidos");

            migrationBuilder.DropTable(
                name: "Clientes");

            migrationBuilder.DropTable(
                name: "EnderecoEntregas");
        }
    }
}

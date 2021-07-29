using System;
using Microsoft.EntityFrameworkCore.Migrations;
using MySql.EntityFrameworkCore.Metadata;

namespace DesafioTecnicoSTi3.data.Migrations
{
    public partial class Pedido : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<long>(
                name: "IdPedido",
                table: "Pagamento",
                type: "bigint",
                nullable: false,
                defaultValue: 0L);

            migrationBuilder.AlterColumn<string>(
                name: "idProduto",
                table: "Itens",
                type: "varchar(100)",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "varchar(100)",
                oldNullable: true);

            migrationBuilder.AddColumn<long>(
                name: "idPedido",
                table: "Itens",
                type: "bigint",
                nullable: false,
                defaultValue: 0L);

            migrationBuilder.AlterColumn<string>(
                name: "id",
                table: "Clientes",
                type: "varchar(767)",
                nullable: false,
                oldClrType: typeof(long),
                oldType: "bigint")
                .OldAnnotation("MySQL:ValueGenerationStrategy", MySQLValueGenerationStrategy.IdentityColumn);

            migrationBuilder.AddColumn<long>(
                name: "codigo_cliente",
                table: "Clientes",
                type: "bigint",
                nullable: false,
                defaultValue: 0L);

            migrationBuilder.CreateTable(
                name: "Pedidos",
                columns: table => new
                {
                    cod_pedido = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("MySQL:ValueGenerationStrategy", MySQLValueGenerationStrategy.IdentityColumn),
                    id = table.Column<string>(type: "varchar(100)", nullable: true),
                    numero = table.Column<string>(type: "varchar(100)", nullable: false),
                    dataCriacao = table.Column<DateTime>(type: "datetime", nullable: false),
                    dataAlteracao = table.Column<DateTime>(type: "datetime", nullable: false),
                    status = table.Column<string>(type: "varchar(20)", nullable: true),
                    desconto = table.Column<double>(type: "double", nullable: false),
                    frete = table.Column<double>(type: "double", nullable: false),
                    subTotal = table.Column<double>(type: "double", nullable: false),
                    valorTotal = table.Column<double>(type: "double", nullable: false),
                    clienteid = table.Column<string>(type: "varchar(767)", nullable: true),
                    enderecoEntregacodigo = table.Column<long>(type: "bigint", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Pedidos", x => x.cod_pedido);
                    table.ForeignKey(
                        name: "FK_Pedidos_Clientes_clienteid",
                        column: x => x.clienteid,
                        principalTable: "Clientes",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Pedidos_EnderecoEntregas_enderecoEntregacodigo",
                        column: x => x.enderecoEntregacodigo,
                        principalTable: "EnderecoEntregas",
                        principalColumn: "codigo",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Pagamento_IdPedido",
                table: "Pagamento",
                column: "IdPedido");

            migrationBuilder.CreateIndex(
                name: "IX_Itens_idPedido",
                table: "Itens",
                column: "idPedido");

            migrationBuilder.CreateIndex(
                name: "IX_Pedidos_clienteid",
                table: "Pedidos",
                column: "clienteid");

            migrationBuilder.CreateIndex(
                name: "IX_Pedidos_enderecoEntregacodigo",
                table: "Pedidos",
                column: "enderecoEntregacodigo");

            migrationBuilder.AddForeignKey(
                name: "FK_Itens_Pedidos_idPedido",
                table: "Itens",
                column: "idPedido",
                principalTable: "Pedidos",
                principalColumn: "cod_pedido",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Pagamento_Pedidos_IdPedido",
                table: "Pagamento",
                column: "IdPedido",
                principalTable: "Pedidos",
                principalColumn: "cod_pedido",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Itens_Pedidos_idPedido",
                table: "Itens");

            migrationBuilder.DropForeignKey(
                name: "FK_Pagamento_Pedidos_IdPedido",
                table: "Pagamento");

            migrationBuilder.DropTable(
                name: "Pedidos");

            migrationBuilder.DropIndex(
                name: "IX_Pagamento_IdPedido",
                table: "Pagamento");

            migrationBuilder.DropIndex(
                name: "IX_Itens_idPedido",
                table: "Itens");

            migrationBuilder.DropColumn(
                name: "IdPedido",
                table: "Pagamento");

            migrationBuilder.DropColumn(
                name: "idPedido",
                table: "Itens");

            migrationBuilder.DropColumn(
                name: "codigo_cliente",
                table: "Clientes");

            migrationBuilder.AlterColumn<string>(
                name: "idProduto",
                table: "Itens",
                type: "varchar(100)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "varchar(100)");

            migrationBuilder.AlterColumn<long>(
                name: "id",
                table: "Clientes",
                type: "bigint",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "varchar(767)")
                .Annotation("MySQL:ValueGenerationStrategy", MySQLValueGenerationStrategy.IdentityColumn);
        }
    }
}

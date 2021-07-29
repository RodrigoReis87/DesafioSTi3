using Microsoft.EntityFrameworkCore.Migrations;
using MySql.EntityFrameworkCore.Metadata;

namespace DesafioTecnicoSTi3.data.Migrations
{
    public partial class Teste : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "EnderecoEntregas",
                columns: table => new
                {
                    codigo = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("MySQL:ValueGenerationStrategy", MySQLValueGenerationStrategy.IdentityColumn),
                    id = table.Column<string>(type: "varchar(100)", nullable: true),
                    endereco = table.Column<string>(type: "varchar(100)", nullable: true),
                    numero = table.Column<string>(type: "varchar(100)", nullable: true),
                    cep = table.Column<string>(type: "varchar(100)", nullable: true),
                    bairro = table.Column<string>(type: "varchar(100)", nullable: true),
                    cidade = table.Column<string>(type: "varchar(100)", nullable: true),
                    estado = table.Column<string>(type: "varchar(100)", nullable: true),
                    complemento = table.Column<string>(type: "varchar(100)", nullable: true),
                    referencia = table.Column<string>(type: "varchar(100)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_EnderecoEntregas", x => x.codigo);
                });

            migrationBuilder.CreateTable(
                name: "Itens",
                columns: table => new
                {
                    codigo_item = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("MySQL:ValueGenerationStrategy", MySQLValueGenerationStrategy.IdentityColumn),
                    id = table.Column<string>(type: "varchar(100)", nullable: true),
                    idProduto = table.Column<string>(type: "varchar(100)", nullable: true),
                    nome = table.Column<string>(type: "varchar(100)", nullable: true),
                    quantidade = table.Column<string>(type: "varchar(100)", nullable: false),
                    valorUnitario = table.Column<decimal>(type: "decimal(15,2)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Itens", x => x.codigo_item);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "EnderecoEntregas");

            migrationBuilder.DropTable(
                name: "Itens");
        }
    }
}

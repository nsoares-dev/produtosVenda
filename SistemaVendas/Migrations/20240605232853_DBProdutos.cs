﻿using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace SistemaVendas.Migrations
{
    /// <inheritdoc />
    public partial class DBProdutos : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Produto",
                columns: table => new
                {
                    ProdutoId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    TituloProduto = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    DescricaoProduto = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    AvaliacaoProduto = table.Column<int>(type: "int", nullable: false),
                    PrecoProduto = table.Column<double>(type: "float", nullable: false),
                    statusEntrega = table.Column<bool>(type: "bit", nullable: false),
                    ExibirAnuncio = table.Column<bool>(type: "bit", nullable: false),
                    UrlImagem = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Produto", x => x.ProdutoId);
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Produto");
        }
    }
}

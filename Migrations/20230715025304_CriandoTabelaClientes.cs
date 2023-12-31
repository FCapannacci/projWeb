﻿using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ControleDeContatos.Migrations
{
    /// <inheritdoc />
    public partial class CriandoTabelaClientes : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Clientes",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    nome = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    email = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    data = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    tipoDePessoa = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    cpfCnpj = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    dataInscricao = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    isento = table.Column<bool>(type: "bit", nullable: false),
                    genero = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    nascimento = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    bloqueado = table.Column<bool>(type: "bit", nullable: false),
                    senha = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Clientes", x => x.Id);
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Clientes");
        }
    }
}

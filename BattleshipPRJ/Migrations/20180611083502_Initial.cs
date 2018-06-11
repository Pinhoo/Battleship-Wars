using Microsoft.EntityFrameworkCore.Migrations;
using System;
using System.Collections.Generic;

namespace BattleshipPRJ.Migrations
{
    public partial class Initial : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "HiScoresDb",
                columns: table => new
                {
                    ID = table.Column<string>(nullable: false),
                    NomeJogador = table.Column<string>(nullable: true),
                    PercentagemAfundado = table.Column<double>(nullable: false),
                    PercentagemAlvo = table.Column<double>(nullable: false),
                    Resultado = table.Column<string>(nullable: true),
                    Score = table.Column<int>(nullable: false),
                    TirosAgua = table.Column<int>(nullable: false),
                    TirosAlvo = table.Column<int>(nullable: false),
                    TirosRepetido = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_HiScoresDb", x => x.ID);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "HiScoresDb");
        }
    }
}

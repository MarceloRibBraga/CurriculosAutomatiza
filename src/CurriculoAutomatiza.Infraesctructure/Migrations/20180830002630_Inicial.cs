using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using System;
using System.Collections.Generic;

namespace CurriculoAutomatiza.Infraesctructure.Migrations
{
    public partial class Inicial : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Profissional",
                columns: table => new
                {
                    ProfissionalId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Cpf = table.Column<string>(type: "varchar(11)", nullable: true),
                    Email = table.Column<string>(type: "varchar(200)", nullable: false),
                    Nome = table.Column<string>(type: "varchar(200)", nullable: false),
                    Senha = table.Column<string>(type: "varchar(10)", nullable: false),
                    Telefone = table.Column<string>(type: "varchar(20)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Profissional", x => x.ProfissionalId);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Profissional");
        }
    }
}

using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using System;
using System.Collections.Generic;

namespace Onecore_API.Migrations
{
    public partial class newdatabase : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Company",
                columns: table => new
                {
                    CPY_ID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Company", x => x.CPY_ID);
                });

            migrationBuilder.CreateTable(
                name: "Emissores",
                columns: table => new
                {
                    EM_ID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Desc_Emissor = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Emissores", x => x.EM_ID);
                });

            migrationBuilder.CreateTable(
                name: "Employee",
                columns: table => new
                {
                    EMP_ID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    CPY_ID = table.Column<int>(nullable: false),
                    EMP_CPF = table.Column<string>(nullable: true),
                    EMP_DATEADMISSION = table.Column<DateTime>(nullable: false),
                    EMP_DATEBORN = table.Column<DateTime>(nullable: false),
                    EMP_EMAIL = table.Column<string>(nullable: true),
                    EMP_FULLNAME = table.Column<string>(nullable: true),
                    EMP_GENRE = table.Column<string>(nullable: true),
                    EMP_PHONE = table.Column<string>(nullable: true),
                    EMP_PICTURE = table.Column<byte>(nullable: false),
                    EMP_REGISTER = table.Column<int>(nullable: false),
                    EMP_RG = table.Column<string>(nullable: true),
                    EMP_ROLE = table.Column<string>(nullable: true),
                    EMP_SCHOOLING = table.Column<string>(nullable: true),
                    EMP_TELEPHONE = table.Column<string>(nullable: true),
                    EM_ID = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Employee", x => x.EMP_ID);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Company");

            migrationBuilder.DropTable(
                name: "Emissores");

            migrationBuilder.DropTable(
                name: "Employee");
        }
    }
}

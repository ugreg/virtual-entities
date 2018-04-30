using Microsoft.EntityFrameworkCore.Migrations;
using System;
using System.Collections.Generic;

namespace VirutalEntityDemo.Migrations
{
    public partial class Initial : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "WebOrder",
                columns: table => new
                {
                    Id = table.Column<Guid>(nullable: false),
                    CusomterId = table.Column<Guid>(nullable: false),
                    DateTime = table.Column<string>(nullable: false),
                    Name = table.Column<string>(nullable: false),
                    Status = table.Column<string>(nullable: false),
                    Tax = table.Column<float>(nullable: false),
                    Total = table.Column<float>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_WebOrder", x => x.Id);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "WebOrder");
        }
    }
}

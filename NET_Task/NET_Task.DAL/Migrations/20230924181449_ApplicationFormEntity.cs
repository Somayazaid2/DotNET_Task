using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace NET_Task.DAL.Migrations
{
    /// <inheritdoc />
    public partial class ApplicationFormEntity : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "ApplicationForms",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    FirstName = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: false),
                    LastName = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: false),
                    Email = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: false),
                    Phone = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: false),
                    Nationality = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: false),
                    CurrentResidence = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: false),
                    IDNumber = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: false),
                    DateOfBirth = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Gender = table.Column<int>(type: "int", nullable: false),
                    CoverImage = table.Column<byte[]>(type: "varbinary(max)", nullable: true),
                    Education = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: false),
                    Experience = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: false),
                    Resume = table.Column<byte[]>(type: "varbinary(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ApplicationForms", x => x.ID);
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "ApplicationForms");
        }
    }
}

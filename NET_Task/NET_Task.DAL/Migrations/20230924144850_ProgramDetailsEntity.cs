using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace NET_Task.DAL.Migrations
{
    /// <inheritdoc />
    public partial class ProgramDetailsEntity : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "ProgramDetails",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Title = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: false),
                    Summary = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: false),
                    Description = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: false),
                    keySkills = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: false),
                    ProgramBenfits = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: false),
                    ProgramCriteria = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: false),
                    ProgramType = table.Column<int>(type: "int", nullable: false),
                    ProgramStart = table.Column<DateTime>(type: "datetime2", nullable: false),
                    AppOpen = table.Column<DateTime>(type: "datetime2", nullable: false),
                    AppClose = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Duration = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: false),
                    ProgramLocation = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: false),
                    Qualification = table.Column<int>(type: "int", nullable: false),
                    MaxNumberOfApp = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ProgramDetails", x => x.ID);
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "ProgramDetails");
        }
    }
}

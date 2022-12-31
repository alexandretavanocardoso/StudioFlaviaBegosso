using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace studioFlaviaBegosso.Infra.Migrations
{
    /// <inheritdoc />
    public partial class AddEmailModel : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Emails",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    NameClient = table.Column<int>(type: "int", nullable: false),
                    PhoneClient = table.Column<int>(type: "int", nullable: false),
                    DescriptionClient = table.Column<int>(type: "int", nullable: false),
                    CreatedBy = table.Column<string>(type: "nvarchar(1000)", maxLength: 1000, nullable: true),
                    DateCreation = table.Column<DateTime>(type: "datetime2", nullable: true),
                    EditBy = table.Column<string>(type: "nvarchar(1000)", maxLength: 1000, nullable: true),
                    DateUpdate = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Emails", x => x.Id);
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Emails");
        }
    }
}

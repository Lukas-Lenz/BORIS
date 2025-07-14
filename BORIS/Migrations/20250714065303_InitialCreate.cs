using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace BORIS.Migrations
{
    /// <inheritdoc />
    public partial class InitialCreate : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Specialisation",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Title = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Specialisation", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "Contacts",
                columns: table => new
                {
                    ID = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    EMail = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    PreferredLocation = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    PreferredSpecialisationID = table.Column<int>(type: "int", nullable: true),
                    DataConsent = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Contacts", x => x.ID);
                    table.ForeignKey(
                        name: "FK_Contacts_Specialisation_PreferredSpecialisationID",
                        column: x => x.PreferredSpecialisationID,
                        principalTable: "Specialisation",
                        principalColumn: "ID");
                });

            migrationBuilder.CreateIndex(
                name: "IX_Contacts_PreferredSpecialisationID",
                table: "Contacts",
                column: "PreferredSpecialisationID");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Contacts");

            migrationBuilder.DropTable(
                name: "Specialisation");
        }
    }
}

using Microsoft.EntityFrameworkCore.Migrations;

namespace Rocky.Migrations
{
    public partial class ApplicationTypeUpdate : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "name",
                table: "ApplicationType",
                newName: "Name");

            migrationBuilder.RenameColumn(
                name: "id",
                table: "ApplicationType",
                newName: "Id");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Name",
                table: "ApplicationType",
                newName: "name");

            migrationBuilder.RenameColumn(
                name: "Id",
                table: "ApplicationType",
                newName: "id");
        }
    }
}

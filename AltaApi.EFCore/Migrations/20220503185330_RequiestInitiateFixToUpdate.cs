using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace AltaApi.EFCore.Migrations
{
    public partial class RequiestInitiateFixToUpdate : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "Apointed",
                table: "RequestInitiates",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "LotNum",
                table: "RequestInitiates",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "MessageReceived",
                table: "RequestInitiates",
                type: "nvarchar(max)",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Apointed",
                table: "RequestInitiates");

            migrationBuilder.DropColumn(
                name: "LotNum",
                table: "RequestInitiates");

            migrationBuilder.DropColumn(
                name: "MessageReceived",
                table: "RequestInitiates");
        }
    }
}

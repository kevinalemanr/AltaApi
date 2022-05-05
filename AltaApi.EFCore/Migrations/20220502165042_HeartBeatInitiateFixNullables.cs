using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace AltaApi.EFCore.Migrations
{
    public partial class HeartBeatInitiateFixNullables : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "MessageReciced",
                table: "HeartBeatInitiates");

            migrationBuilder.AddColumn<string>(
                name: "MessageRecived",
                table: "HeartBeatInitiates",
                type: "nvarchar(50)",
                maxLength: 50,
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "MessageRecived",
                table: "HeartBeatInitiates");

            migrationBuilder.AddColumn<string>(
                name: "MessageReciced",
                table: "HeartBeatInitiates",
                type: "nvarchar(50)",
                maxLength: 50,
                nullable: false,
                defaultValue: "");
        }
    }
}

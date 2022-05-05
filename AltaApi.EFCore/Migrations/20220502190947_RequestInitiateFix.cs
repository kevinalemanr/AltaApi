using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace AltaApi.EFCore.Migrations
{
    public partial class RequestInitiateFix : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Appointed",
                table: "RequestInitiates");

            migrationBuilder.DropColumn(
                name: "Concluded",
                table: "RequestInitiates");

            migrationBuilder.DropColumn(
                name: "Line",
                table: "RequestInitiates");

            migrationBuilder.DropColumn(
                name: "MessageRecived",
                table: "RequestInitiates");

            migrationBuilder.DropColumn(
                name: "MessageSent",
                table: "RequestInitiates");

            migrationBuilder.DropColumn(
                name: "ResponseTime",
                table: "RequestInitiates");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<bool>(
                name: "Appointed",
                table: "RequestInitiates",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<bool>(
                name: "Concluded",
                table: "RequestInitiates",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<string>(
                name: "Line",
                table: "RequestInitiates",
                type: "nvarchar(50)",
                maxLength: 50,
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "MessageRecived",
                table: "RequestInitiates",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "MessageSent",
                table: "RequestInitiates",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "ResponseTime",
                table: "RequestInitiates",
                type: "date",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));
        }
    }
}

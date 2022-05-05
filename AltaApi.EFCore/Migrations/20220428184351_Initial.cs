using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace AltaApi.EFCore.Migrations
{
    public partial class Initial : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "ApiKey",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    KeyValue = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    ApiName = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    ApplicationAccess = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Active = table.Column<bool>(type: "bit", nullable: false, defaultValue: false),
                    CreationDate = table.Column<DateTime>(type: "date", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ApiKey", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "HeartBeatInitiates",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    TranId = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    TranDt = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    Wcs_Id = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    Wh_Id = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    Text = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CreationDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    MessageReciced = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    ResponseTime = table.Column<DateTime>(type: "date", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_HeartBeatInitiates", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "RequestInitiates",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    TranId = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    Wh_id = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    Wcs_id = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    LodNum = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    Req_Contents_Flg = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    Req_Stoloc_flg = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    MessageSent = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ResponseTime = table.Column<DateTime>(type: "date", nullable: false),
                    MessageRecived = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Concluded = table.Column<bool>(type: "bit", nullable: false, defaultValue: false),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Appointed = table.Column<bool>(type: "bit", nullable: false, defaultValue: false),
                    Line = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_RequestInitiates", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "RequestsInbox",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    TranId = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    TranDt = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    Wh_Id = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    Wcs_Id = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    LodNum = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    Req_Contents_Flag = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    Req_Stoloc_Flag = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    Processing = table.Column<bool>(type: "bit", nullable: false, defaultValue: false),
                    Concluded = table.Column<bool>(type: "bit", nullable: false, defaultValue: false),
                    failed = table.Column<bool>(type: "bit", nullable: false, defaultValue: false),
                    Reprocess = table.Column<bool>(type: "bit", nullable: false, defaultValue: false),
                    CreationDate = table.Column<DateTime>(type: "date", nullable: false),
                    StatusCode = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_RequestsInbox", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "SaveFromPrimes",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    TranId = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    Data = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Endpoint = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    Application = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    Date = table.Column<DateTime>(type: "date", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SaveFromPrimes", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "SaveToPrimes",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    TranId = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    Data = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Endpoint = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    Application = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    Date = table.Column<DateTime>(type: "date", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SaveToPrimes", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "User",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    UserName = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    Password = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    Active = table.Column<bool>(type: "bit", nullable: false, defaultValue: false),
                    Creationdate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Comment = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_User", x => x.Id);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "ApiKey");

            migrationBuilder.DropTable(
                name: "HeartBeatInitiates");

            migrationBuilder.DropTable(
                name: "RequestInitiates");

            migrationBuilder.DropTable(
                name: "RequestsInbox");

            migrationBuilder.DropTable(
                name: "SaveFromPrimes");

            migrationBuilder.DropTable(
                name: "SaveToPrimes");

            migrationBuilder.DropTable(
                name: "User");
        }
    }
}

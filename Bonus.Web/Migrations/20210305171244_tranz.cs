using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Bonus.Web.Migrations
{
    public partial class tranz : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "ChequeNumber",
                table: "Transactions");

            migrationBuilder.DropColumn(
                name: "ChequeTime",
                table: "Transactions");

            migrationBuilder.RenameColumn(
                name: "Summ",
                table: "Transactions",
                newName: "BonusRateSoFar");

            migrationBuilder.AlterColumn<decimal>(
                name: "Bonus",
                table: "Transactions",
                type: "numeric",
                nullable: false,
                defaultValue: 0m,
                oldClrType: typeof(decimal),
                oldType: "numeric",
                oldNullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "BonusRateSoFar",
                table: "Transactions",
                newName: "Summ");

            migrationBuilder.AlterColumn<decimal>(
                name: "Bonus",
                table: "Transactions",
                type: "numeric",
                nullable: true,
                oldClrType: typeof(decimal),
                oldType: "numeric");

            migrationBuilder.AddColumn<string>(
                name: "ChequeNumber",
                table: "Transactions",
                type: "text",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "ChequeTime",
                table: "Transactions",
                type: "timestamp without time zone",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));
        }
    }
}

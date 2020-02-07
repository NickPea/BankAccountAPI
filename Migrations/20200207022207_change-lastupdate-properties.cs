using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace BankApi.Migrations
{
    public partial class changelastupdateproperties : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "LastUpdate",
                table: "Transactions");

            migrationBuilder.DropColumn(
                name: "LastUpdate",
                table: "Persons");

            migrationBuilder.DropColumn(
                name: "LastUpdate",
                table: "Accounts");

            migrationBuilder.AddColumn<byte[]>(
                name: "ConcurrencyToken",
                table: "Transactions",
                rowVersion: true,
                nullable: true);

            migrationBuilder.AddColumn<byte[]>(
                name: "ConcurrencyToken",
                table: "Persons",
                rowVersion: true,
                nullable: true);

            migrationBuilder.AddColumn<byte[]>(
                name: "ConcurrencyToken",
                table: "Accounts",
                rowVersion: true,
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "ConcurrencyToken",
                table: "Transactions");

            migrationBuilder.DropColumn(
                name: "ConcurrencyToken",
                table: "Persons");

            migrationBuilder.DropColumn(
                name: "ConcurrencyToken",
                table: "Accounts");

            migrationBuilder.AddColumn<byte[]>(
                name: "LastUpdate",
                table: "Transactions",
                type: "rowversion",
                rowVersion: true,
                nullable: true);

            migrationBuilder.AddColumn<byte[]>(
                name: "LastUpdate",
                table: "Persons",
                type: "rowversion",
                rowVersion: true,
                nullable: true);

            migrationBuilder.AddColumn<byte[]>(
                name: "LastUpdate",
                table: "Accounts",
                type: "rowversion",
                rowVersion: true,
                nullable: true);
        }
    }
}

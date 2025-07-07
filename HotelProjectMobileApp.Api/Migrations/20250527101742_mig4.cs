using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace HotelProjectMobileApp.Api.Migrations
{
    /// <inheritdoc />
    public partial class mig4 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "CheckIn",
                table: "Categories");

            migrationBuilder.DropColumn(
                name: "CheckOut",
                table: "Categories");

            migrationBuilder.DropColumn(
                name: "StatusReservation",
                table: "Categories");

            migrationBuilder.RenameColumn(
                name: "UserId",
                table: "Users",
                newName: "Id");

            migrationBuilder.RenameColumn(
                name: "ReservationId",
                table: "Reservations",
                newName: "Id");

            migrationBuilder.RenameColumn(
                name: "RegisterId",
                table: "Register",
                newName: "Id");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Id",
                table: "Users",
                newName: "UserId");

            migrationBuilder.RenameColumn(
                name: "Id",
                table: "Reservations",
                newName: "ReservationId");

            migrationBuilder.RenameColumn(
                name: "Id",
                table: "Register",
                newName: "RegisterId");

            migrationBuilder.AddColumn<DateTime>(
                name: "CheckIn",
                table: "Categories",
                type: "TEXT",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<DateTime>(
                name: "CheckOut",
                table: "Categories",
                type: "TEXT",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<bool>(
                name: "StatusReservation",
                table: "Categories",
                type: "INTEGER",
                nullable: false,
                defaultValue: false);
        }
    }
}

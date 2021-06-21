using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Template.Data.Migrations
{
    public partial class UpdatingDefaultUser : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("ea972fe2-a22e-478b-a0f7-5a9d569fbb30"),
                column: "DateCreated",
                value: new DateTime(2020, 6, 20, 0, 0, 0, 0, DateTimeKind.Unspecified));
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("ea972fe2-a22e-478b-a0f7-5a9d569fbb30"),
                column: "DateCreated",
                value: null);
        }
    }
}

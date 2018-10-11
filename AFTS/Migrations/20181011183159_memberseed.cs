using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace AFTS.Migrations
{
    public partial class memberseed : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "member",
                columns: new[] { "member_id", "Biography", "dob", "Email", "gender", "name", "Nickname", "Password", "role_id" },
                values: new object[] { 1, "admin", new DateTime(1991, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "admin@admin.com", "M", "admin", "admin", "admin", 1 });

            migrationBuilder.InsertData(
                table: "member",
                columns: new[] { "member_id", "Biography", "dob", "Email", "gender", "name", "Nickname", "Password", "role_id" },
                values: new object[] { 2, "coach", new DateTime(1991, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "coach@coach.com", "M", "coach", "coach", "Member", 2 });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "member",
                keyColumn: "member_id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "member",
                keyColumn: "member_id",
                keyValue: 2);
        }
    }
}

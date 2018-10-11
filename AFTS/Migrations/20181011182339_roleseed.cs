using Microsoft.EntityFrameworkCore.Migrations;

namespace AFTS.Migrations
{
    public partial class roleseed : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "role",
                columns: new[] { "role_id", "role_type" },
                values: new object[] { 1, "Admin" });

            migrationBuilder.InsertData(
                table: "role",
                columns: new[] { "role_id", "role_type" },
                values: new object[] { 2, "Coach" });

            migrationBuilder.InsertData(
                table: "role",
                columns: new[] { "role_id", "role_type" },
                values: new object[] { 3, "Member" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "role",
                keyColumn: "role_id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "role",
                keyColumn: "role_id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "role",
                keyColumn: "role_id",
                keyValue: 3);
        }
    }
}

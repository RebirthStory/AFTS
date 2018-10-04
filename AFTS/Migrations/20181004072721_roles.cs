using Microsoft.EntityFrameworkCore.Migrations;

namespace AFTS.Migrations
{
    public partial class roles : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "member_id",
                table: "role");

            migrationBuilder.DropColumn(
                name: "role_type",
                table: "member");

            migrationBuilder.AddColumn<int>(
                name: "RoleTypeRoleId",
                table: "member",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_member_RoleTypeRoleId",
                table: "member",
                column: "RoleTypeRoleId");

            migrationBuilder.AddForeignKey(
                name: "FK_member_role_RoleTypeRoleId",
                table: "member",
                column: "RoleTypeRoleId",
                principalTable: "role",
                principalColumn: "role_id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_member_role_RoleTypeRoleId",
                table: "member");

            migrationBuilder.DropIndex(
                name: "IX_member_RoleTypeRoleId",
                table: "member");

            migrationBuilder.DropColumn(
                name: "RoleTypeRoleId",
                table: "member");

            migrationBuilder.AddColumn<int>(
                name: "member_id",
                table: "role",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "role_type",
                table: "member",
                nullable: true);
        }
    }
}

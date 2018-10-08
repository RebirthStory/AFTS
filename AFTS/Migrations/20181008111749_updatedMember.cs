using Microsoft.EntityFrameworkCore.Migrations;

namespace AFTS.Migrations
{
    public partial class updatedMember : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_member_role_RoleId1",
                table: "member");

            migrationBuilder.DropIndex(
                name: "IX_member_RoleId1",
                table: "member");

            migrationBuilder.DropColumn(
                name: "RoleId1",
                table: "member");

            migrationBuilder.AddColumn<int>(
                name: "role_id",
                table: "member",
                nullable: false,
                defaultValue: 3);

            migrationBuilder.CreateIndex(
                name: "IX_member_role_id",
                table: "member",
                column: "role_id");

            migrationBuilder.AddForeignKey(
                name: "FK_member_role_role_id",
                table: "member",
                column: "role_id",
                principalTable: "role",
                principalColumn: "role_id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_member_role_role_id",
                table: "member");

            migrationBuilder.DropIndex(
                name: "IX_member_role_id",
                table: "member");

            migrationBuilder.DropColumn(
                name: "role_id",
                table: "member");

            migrationBuilder.AddColumn<int>(
                name: "RoleId1",
                table: "member",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_member_RoleId1",
                table: "member",
                column: "RoleId1");

            migrationBuilder.AddForeignKey(
                name: "FK_member_role_RoleId1",
                table: "member",
                column: "RoleId1",
                principalTable: "role",
                principalColumn: "role_id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}

using Microsoft.EntityFrameworkCore.Migrations;

namespace AFTS.Migrations
{
    public partial class UpdatedMembers : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_member_role_RoleTypeRoleId",
                table: "member");

            migrationBuilder.RenameColumn(
                name: "RoleTypeRoleId",
                table: "member",
                newName: "RoleId1");

            migrationBuilder.RenameIndex(
                name: "IX_member_RoleTypeRoleId",
                table: "member",
                newName: "IX_member_RoleId1");

            migrationBuilder.AddColumn<string>(
                name: "Email",
                table: "member",
                nullable: true);

            migrationBuilder.AddForeignKey(
                name: "FK_member_role_RoleId1",
                table: "member",
                column: "RoleId1",
                principalTable: "role",
                principalColumn: "role_id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_member_role_RoleId1",
                table: "member");

            migrationBuilder.DropColumn(
                name: "Email",
                table: "member");

            migrationBuilder.RenameColumn(
                name: "RoleId1",
                table: "member",
                newName: "RoleTypeRoleId");

            migrationBuilder.RenameIndex(
                name: "IX_member_RoleId1",
                table: "member",
                newName: "IX_member_RoleTypeRoleId");

            migrationBuilder.AddForeignKey(
                name: "FK_member_role_RoleTypeRoleId",
                table: "member",
                column: "RoleTypeRoleId",
                principalTable: "role",
                principalColumn: "role_id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}

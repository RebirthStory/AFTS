using Microsoft.EntityFrameworkCore.Migrations;

namespace AFTS.Migrations
{
    public partial class MemberIdFK2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_schedule_member_MemberId1",
                table: "schedule");

            migrationBuilder.DropIndex(
                name: "IX_schedule_MemberId1",
                table: "schedule");

            migrationBuilder.DropColumn(
                name: "MemberId1",
                table: "schedule");

            migrationBuilder.AlterColumn<int>(
                name: "member_id",
                table: "schedule",
                nullable: false,
                oldClrType: typeof(string),
                oldNullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_schedule_member_id",
                table: "schedule",
                column: "member_id");

            migrationBuilder.AddForeignKey(
                name: "FK_schedule_member_member_id",
                table: "schedule",
                column: "member_id",
                principalTable: "member",
                principalColumn: "member_id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_schedule_member_member_id",
                table: "schedule");

            migrationBuilder.DropIndex(
                name: "IX_schedule_member_id",
                table: "schedule");

            migrationBuilder.AlterColumn<string>(
                name: "member_id",
                table: "schedule",
                nullable: true,
                oldClrType: typeof(int));

            migrationBuilder.AddColumn<int>(
                name: "MemberId1",
                table: "schedule",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_schedule_MemberId1",
                table: "schedule",
                column: "MemberId1");

            migrationBuilder.AddForeignKey(
                name: "FK_schedule_member_MemberId1",
                table: "schedule",
                column: "MemberId1",
                principalTable: "member",
                principalColumn: "member_id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}

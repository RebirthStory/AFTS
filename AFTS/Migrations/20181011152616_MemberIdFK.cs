using Microsoft.EntityFrameworkCore.Migrations;

namespace AFTS.Migrations
{
    public partial class MemberIdFK : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_event_member_MemberId",
                table: "event");

            migrationBuilder.DropForeignKey(
                name: "FK_schedule_member_MemberId",
                table: "schedule");

            migrationBuilder.DropIndex(
                name: "IX_schedule_MemberId",
                table: "schedule");

            migrationBuilder.RenameColumn(
                name: "MemberId",
                table: "schedule",
                newName: "member_id");

            migrationBuilder.RenameColumn(
                name: "MemberId",
                table: "event",
                newName: "member_id");

            migrationBuilder.RenameIndex(
                name: "IX_event_MemberId",
                table: "event",
                newName: "IX_event_member_id");

            migrationBuilder.AlterColumn<string>(
                name: "member_id",
                table: "schedule",
                nullable: true,
                oldClrType: typeof(int),
                oldNullable: true);

            migrationBuilder.AddColumn<int>(
                name: "MemberId1",
                table: "schedule",
                nullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "member_id",
                table: "event",
                nullable: false,
                oldClrType: typeof(int),
                oldNullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_schedule_MemberId1",
                table: "schedule",
                column: "MemberId1");

            migrationBuilder.AddForeignKey(
                name: "FK_event_member_member_id",
                table: "event",
                column: "member_id",
                principalTable: "member",
                principalColumn: "member_id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_schedule_member_MemberId1",
                table: "schedule",
                column: "MemberId1",
                principalTable: "member",
                principalColumn: "member_id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_event_member_member_id",
                table: "event");

            migrationBuilder.DropForeignKey(
                name: "FK_schedule_member_MemberId1",
                table: "schedule");

            migrationBuilder.DropIndex(
                name: "IX_schedule_MemberId1",
                table: "schedule");

            migrationBuilder.DropColumn(
                name: "MemberId1",
                table: "schedule");

            migrationBuilder.RenameColumn(
                name: "member_id",
                table: "schedule",
                newName: "MemberId");

            migrationBuilder.RenameColumn(
                name: "member_id",
                table: "event",
                newName: "MemberId");

            migrationBuilder.RenameIndex(
                name: "IX_event_member_id",
                table: "event",
                newName: "IX_event_MemberId");

            migrationBuilder.AlterColumn<int>(
                name: "MemberId",
                table: "schedule",
                nullable: true,
                oldClrType: typeof(string),
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "MemberId",
                table: "event",
                nullable: true,
                oldClrType: typeof(int));

            migrationBuilder.CreateIndex(
                name: "IX_schedule_MemberId",
                table: "schedule",
                column: "MemberId");

            migrationBuilder.AddForeignKey(
                name: "FK_event_member_MemberId",
                table: "event",
                column: "MemberId",
                principalTable: "member",
                principalColumn: "member_id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_schedule_member_MemberId",
                table: "schedule",
                column: "MemberId",
                principalTable: "member",
                principalColumn: "member_id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}

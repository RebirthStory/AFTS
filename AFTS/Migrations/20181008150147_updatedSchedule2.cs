using Microsoft.EntityFrameworkCore.Migrations;

namespace AFTS.Migrations
{
    public partial class updatedSchedule2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_event_member_MemberId1",
                table: "event");

            migrationBuilder.DropForeignKey(
                name: "FK_schedule_event_event_id",
                table: "schedule");

            migrationBuilder.DropForeignKey(
                name: "FK_schedule_member_member_id",
                table: "schedule");

            migrationBuilder.RenameColumn(
                name: "member_id",
                table: "schedule",
                newName: "MemberId");

            migrationBuilder.RenameColumn(
                name: "event_id",
                table: "schedule",
                newName: "EventId");

            migrationBuilder.RenameIndex(
                name: "IX_schedule_member_id",
                table: "schedule",
                newName: "IX_schedule_MemberId");

            migrationBuilder.RenameIndex(
                name: "IX_schedule_event_id",
                table: "schedule",
                newName: "IX_schedule_EventId");

            migrationBuilder.RenameColumn(
                name: "MemberId1",
                table: "event",
                newName: "MemberId");

            migrationBuilder.RenameIndex(
                name: "IX_event_MemberId1",
                table: "event",
                newName: "IX_event_MemberId");

            migrationBuilder.AlterColumn<int>(
                name: "MemberId",
                table: "schedule",
                nullable: true,
                oldClrType: typeof(int));

            migrationBuilder.AlterColumn<int>(
                name: "EventId",
                table: "schedule",
                nullable: true,
                oldClrType: typeof(int));

            migrationBuilder.AddForeignKey(
                name: "FK_event_member_MemberId",
                table: "event",
                column: "MemberId",
                principalTable: "member",
                principalColumn: "member_id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_schedule_event_EventId",
                table: "schedule",
                column: "EventId",
                principalTable: "event",
                principalColumn: "event_id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_schedule_member_MemberId",
                table: "schedule",
                column: "MemberId",
                principalTable: "member",
                principalColumn: "member_id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_event_member_MemberId",
                table: "event");

            migrationBuilder.DropForeignKey(
                name: "FK_schedule_event_EventId",
                table: "schedule");

            migrationBuilder.DropForeignKey(
                name: "FK_schedule_member_MemberId",
                table: "schedule");

            migrationBuilder.RenameColumn(
                name: "MemberId",
                table: "schedule",
                newName: "member_id");

            migrationBuilder.RenameColumn(
                name: "EventId",
                table: "schedule",
                newName: "event_id");

            migrationBuilder.RenameIndex(
                name: "IX_schedule_MemberId",
                table: "schedule",
                newName: "IX_schedule_member_id");

            migrationBuilder.RenameIndex(
                name: "IX_schedule_EventId",
                table: "schedule",
                newName: "IX_schedule_event_id");

            migrationBuilder.RenameColumn(
                name: "MemberId",
                table: "event",
                newName: "MemberId1");

            migrationBuilder.RenameIndex(
                name: "IX_event_MemberId",
                table: "event",
                newName: "IX_event_MemberId1");

            migrationBuilder.AlterColumn<int>(
                name: "member_id",
                table: "schedule",
                nullable: false,
                oldClrType: typeof(int),
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "event_id",
                table: "schedule",
                nullable: false,
                oldClrType: typeof(int),
                oldNullable: true);

            migrationBuilder.AddForeignKey(
                name: "FK_event_member_MemberId1",
                table: "event",
                column: "MemberId1",
                principalTable: "member",
                principalColumn: "member_id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_schedule_event_event_id",
                table: "schedule",
                column: "event_id",
                principalTable: "event",
                principalColumn: "event_id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_schedule_member_member_id",
                table: "schedule",
                column: "member_id",
                principalTable: "member",
                principalColumn: "member_id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}

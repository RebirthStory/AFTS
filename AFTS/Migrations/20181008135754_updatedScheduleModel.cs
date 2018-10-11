using Microsoft.EntityFrameworkCore.Migrations;

namespace AFTS.Migrations
{
    public partial class updatedScheduleModel : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_schedule_event_EventId1",
                table: "schedule");

            migrationBuilder.DropForeignKey(
                name: "FK_schedule_member_MemberId1",
                table: "schedule");

            migrationBuilder.DropIndex(
                name: "IX_schedule_EventId1",
                table: "schedule");

            migrationBuilder.DropIndex(
                name: "IX_schedule_MemberId1",
                table: "schedule");

            migrationBuilder.DropColumn(
                name: "EventId1",
                table: "schedule");

            migrationBuilder.DropColumn(
                name: "MemberId1",
                table: "schedule");

            migrationBuilder.AddColumn<int>(
                name: "event_id",
                table: "schedule",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "member_id",
                table: "schedule",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_schedule_event_id",
                table: "schedule",
                column: "event_id");

            migrationBuilder.CreateIndex(
                name: "IX_schedule_member_id",
                table: "schedule",
                column: "member_id");

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

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_schedule_event_event_id",
                table: "schedule");

            migrationBuilder.DropForeignKey(
                name: "FK_schedule_member_member_id",
                table: "schedule");

            migrationBuilder.DropIndex(
                name: "IX_schedule_event_id",
                table: "schedule");

            migrationBuilder.DropIndex(
                name: "IX_schedule_member_id",
                table: "schedule");

            migrationBuilder.DropColumn(
                name: "event_id",
                table: "schedule");

            migrationBuilder.DropColumn(
                name: "member_id",
                table: "schedule");

            migrationBuilder.AddColumn<int>(
                name: "EventId1",
                table: "schedule",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "MemberId1",
                table: "schedule",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_schedule_EventId1",
                table: "schedule",
                column: "EventId1");

            migrationBuilder.CreateIndex(
                name: "IX_schedule_MemberId1",
                table: "schedule",
                column: "MemberId1");

            migrationBuilder.AddForeignKey(
                name: "FK_schedule_event_EventId1",
                table: "schedule",
                column: "EventId1",
                principalTable: "event",
                principalColumn: "event_id",
                onDelete: ReferentialAction.Restrict);

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

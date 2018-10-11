using Microsoft.EntityFrameworkCore.Migrations;

namespace AFTS.Migrations
{
    public partial class manyMembers : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_schedule_member_MemberId",
                table: "schedule");

            migrationBuilder.DropIndex(
                name: "IX_schedule_MemberId",
                table: "schedule");

            migrationBuilder.DropColumn(
                name: "MemberId",
                table: "schedule");

            migrationBuilder.AddColumn<int>(
                name: "ScheduleId",
                table: "member",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_member_ScheduleId",
                table: "member",
                column: "ScheduleId");

            migrationBuilder.AddForeignKey(
                name: "FK_member_schedule_ScheduleId",
                table: "member",
                column: "ScheduleId",
                principalTable: "schedule",
                principalColumn: "schedule_id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_member_schedule_ScheduleId",
                table: "member");

            migrationBuilder.DropIndex(
                name: "IX_member_ScheduleId",
                table: "member");

            migrationBuilder.DropColumn(
                name: "ScheduleId",
                table: "member");

            migrationBuilder.AddColumn<int>(
                name: "MemberId",
                table: "schedule",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_schedule_MemberId",
                table: "schedule",
                column: "MemberId");

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

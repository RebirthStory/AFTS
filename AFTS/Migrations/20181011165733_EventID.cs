using Microsoft.EntityFrameworkCore.Migrations;

namespace AFTS.Migrations
{
    public partial class EventID : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_schedule_event_EventId",
                table: "schedule");

            migrationBuilder.RenameColumn(
                name: "EventId",
                table: "schedule",
                newName: "event_id");

            migrationBuilder.RenameIndex(
                name: "IX_schedule_EventId",
                table: "schedule",
                newName: "IX_schedule_event_id");

            migrationBuilder.AlterColumn<int>(
                name: "event_id",
                table: "schedule",
                nullable: false,
                oldClrType: typeof(int),
                oldNullable: true);

            migrationBuilder.AddForeignKey(
                name: "FK_schedule_event_event_id",
                table: "schedule",
                column: "event_id",
                principalTable: "event",
                principalColumn: "event_id",
                onDelete: ReferentialAction.NoAction);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_schedule_event_event_id",
                table: "schedule");

            migrationBuilder.RenameColumn(
                name: "event_id",
                table: "schedule",
                newName: "EventId");

            migrationBuilder.RenameIndex(
                name: "IX_schedule_event_id",
                table: "schedule",
                newName: "IX_schedule_EventId");

            migrationBuilder.AlterColumn<int>(
                name: "EventId",
                table: "schedule",
                nullable: true,
                oldClrType: typeof(int));

            migrationBuilder.AddForeignKey(
                name: "FK_schedule_event_EventId",
                table: "schedule",
                column: "EventId",
                principalTable: "event",
                principalColumn: "event_id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}

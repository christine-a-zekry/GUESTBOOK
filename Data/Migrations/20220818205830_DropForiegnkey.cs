using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Guest_book.Data.Migrations
{
    public partial class DropForiegnkey : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Guest_Messages_MessageId",
                schema: "GuestBook",
                table: "Guest");

            migrationBuilder.DropIndex(
                name: "IX_Guest_MessageId",
                schema: "GuestBook",
                table: "Guest");

            migrationBuilder.DropColumn(
                name: "MessageId",
                schema: "GuestBook",
                table: "Guest");

            migrationBuilder.AddColumn<string>(
                name: "Messages",
                schema: "GuestBook",
                table: "Guest",
                type: "varchar(50)",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Messages",
                schema: "GuestBook",
                table: "Guest");

            migrationBuilder.AddColumn<int>(
                name: "MessageId",
                schema: "GuestBook",
                table: "Guest",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_Guest_MessageId",
                schema: "GuestBook",
                table: "Guest",
                column: "MessageId");

            migrationBuilder.AddForeignKey(
                name: "FK_Guest_Messages_MessageId",
                schema: "GuestBook",
                table: "Guest",
                column: "MessageId",
                principalSchema: "GuestBook",
                principalTable: "Messages",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}

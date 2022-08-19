using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Guest_book.Data.Migrations
{
    public partial class InitilizeData : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.EnsureSchema(
                name: "GuestBook");

            migrationBuilder.CreateTable(
                name: "Messages",
                schema: "GuestBook",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Message = table.Column<string>(type: "varchar(200)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Messages", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Guest",
                schema: "GuestBook",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Guest_Name = table.Column<string>(type: "varchar(200)", nullable: false),
                    Guest_Address = table.Column<string>(type: "varchar(200)", nullable: false),
                    Guest_Email = table.Column<string>(type: "varchar(50)", nullable: false),
                    MessageId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Guest", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Guest_Messages_MessageId",
                        column: x => x.MessageId,
                        principalSchema: "GuestBook",
                        principalTable: "Messages",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Guest_MessageId",
                schema: "GuestBook",
                table: "Guest",
                column: "MessageId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Guest",
                schema: "GuestBook");

            migrationBuilder.DropTable(
                name: "Messages",
                schema: "GuestBook");
        }
    }
}

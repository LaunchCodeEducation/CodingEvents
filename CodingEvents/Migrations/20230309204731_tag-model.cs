using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace CodingEvents.Migrations
{
    /// <inheritdoc />
    public partial class tagmodel : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "TagId",
                table: "Events",
                type: "int",
                nullable: true);

            migrationBuilder.CreateTable(
                name: "Tags",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    Name = table.Column<string>(type: "varchar(50)", maxLength: 50, nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Tags", x => x.Id);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateIndex(
                name: "IX_Events_TagId",
                table: "Events",
                column: "TagId");

            migrationBuilder.AddForeignKey(
                name: "FK_Events_Tags_TagId",
                table: "Events",
                column: "TagId",
                principalTable: "Tags",
                principalColumn: "Id");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Events_Tags_TagId",
                table: "Events");

            migrationBuilder.DropTable(
                name: "Tags");

            migrationBuilder.DropIndex(
                name: "IX_Events_TagId",
                table: "Events");

            migrationBuilder.DropColumn(
                name: "TagId",
                table: "Events");
        }
    }
}

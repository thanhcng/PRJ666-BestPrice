using Microsoft.EntityFrameworkCore.Migrations;

namespace BestPrice.Migrations
{
    public partial class AddSubjectColumnToReviews : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Subject",
                schema: "prj666_192a03",
                table: "Reviews",
                nullable: false);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Subject",
                schema: "prj666_192a03",
                table: "Reviews");
        }
    }
}

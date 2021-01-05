using Microsoft.EntityFrameworkCore.Migrations;

namespace JournalShop.Migrations
{
    public partial class SecondCreate : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<int>(
                name: "PageNumber",
                table: "Journal",
                nullable: false,
                oldClrType: typeof(string),
                oldNullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "PageNumber",
                table: "Journal",
                nullable: true,
                oldClrType: typeof(int));
        }
    }
}

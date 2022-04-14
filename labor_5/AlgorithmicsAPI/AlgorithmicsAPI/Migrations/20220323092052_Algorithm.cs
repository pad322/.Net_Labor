using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace AlgorithmicsAPI.Migrations
{
    public partial class Algorithm : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "AlgorithmNickName",
                table: "Algorithms",
                type: "nvarchar(max)",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AddColumn<int>(
                name: "Type",
                table: "Algorithms",
                type: "int",
                nullable: false,
                defaultValue: 0);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Type",
                table: "Algorithms");

            migrationBuilder.AlterColumn<int>(
                name: "AlgorithmNickName",
                table: "Algorithms",
                type: "int",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");
        }
    }
}

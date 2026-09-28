using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace WorksManagerMini.Migrations
{
    /// <inheritdoc />
    public partial class FixJobModel : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "CustomerName",
                table: "Jobs",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "Phone",
                table: "Jobs",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "ProofImage",
                table: "Jobs",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "WorkType",
                table: "Jobs",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "CustomerName",
                table: "Jobs");

            migrationBuilder.DropColumn(
                name: "Phone",
                table: "Jobs");

            migrationBuilder.DropColumn(
                name: "ProofImage",
                table: "Jobs");

            migrationBuilder.DropColumn(
                name: "WorkType",
                table: "Jobs");
        }
    }
}

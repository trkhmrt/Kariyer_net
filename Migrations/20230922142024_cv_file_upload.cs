using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Kariyer_net.Migrations
{
    /// <inheritdoc />
    public partial class cv_file_upload : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Cv",
                table: "AspNetUsers",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Cv",
                table: "AspNetUsers");
        }
    }
}

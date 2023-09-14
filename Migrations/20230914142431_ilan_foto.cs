using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Kariyer_net.Migrations
{
    /// <inheritdoc />
    public partial class ilan_foto : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "IlanFotoUrl",
                table: "Ilans",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "IlanFotoUrl",
                table: "Ilans");
        }
    }
}

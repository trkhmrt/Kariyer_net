using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Kariyer_net.Migrations
{
    /// <inheritdoc />
    public partial class ılan_maas_eklendi : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "Maas",
                table: "Ilans",
                type: "int",
                nullable: false,
                defaultValue: 0);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Maas",
                table: "Ilans");
        }
    }
}

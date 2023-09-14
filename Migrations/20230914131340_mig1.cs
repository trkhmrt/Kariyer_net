using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Kariyer_net.Migrations
{
    /// <inheritdoc />
    public partial class mig1 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Carousels",
                columns: table => new
                {
                    CaroueselID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CarouselBaslik = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CarouselAciklama = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CarouselFotoUrl = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Carousels", x => x.CaroueselID);
                });

            migrationBuilder.CreateTable(
                name: "Contacts",
                columns: table => new
                {
                    ContactID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Lokasyon = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Telefon = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Mail = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Contacts", x => x.ContactID);
                });

            migrationBuilder.CreateTable(
                name: "Firmas",
                columns: table => new
                {
                    FirmaID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    FirmaAdi = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    FirmaAciklama = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Firmas", x => x.FirmaID);
                });

            migrationBuilder.CreateTable(
                name: "Kategoris",
                columns: table => new
                {
                    KategoriID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    KategoriIsmi = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    KategoriFoto = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    KategoriBasvuranSayisi = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Kategoris", x => x.KategoriID);
                });

            migrationBuilder.CreateTable(
                name: "Referances",
                columns: table => new
                {
                    ReferansID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ReferansAd = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ReferansResimUrl = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ReferansMeslek = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ReferansYazisi = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Referances", x => x.ReferansID);
                });

            migrationBuilder.CreateTable(
                name: "Ilans",
                columns: table => new
                {
                    IlanID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    IlanBaslik = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Ulke = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Sehir = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CalismaTuru = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    IlanAciklama = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    IlanSorumluluklar = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    IlanYetenekler = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    YayimlanmaTarihi = table.Column<DateTime>(type: "datetime2", nullable: false),
                    BasvuruSayisi = table.Column<int>(type: "int", nullable: false),
                    Firma = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    KategoriID = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Ilans", x => x.IlanID);
                    table.ForeignKey(
                        name: "FK_Ilans_Kategoris_KategoriID",
                        column: x => x.KategoriID,
                        principalTable: "Kategoris",
                        principalColumn: "KategoriID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Ilans_KategoriID",
                table: "Ilans",
                column: "KategoriID");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Carousels");

            migrationBuilder.DropTable(
                name: "Contacts");

            migrationBuilder.DropTable(
                name: "Firmas");

            migrationBuilder.DropTable(
                name: "Ilans");

            migrationBuilder.DropTable(
                name: "Referances");

            migrationBuilder.DropTable(
                name: "Kategoris");
        }
    }
}

﻿// <auto-generated />
using System;
using Kariyer_net.Concrete;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace Kariyer_net.Migrations
{
    [DbContext(typeof(Context))]
    [Migration("20230914131340_mig1")]
    partial class mig1
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.11")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("Kariyer_net.Models.Carousel", b =>
                {
                    b.Property<int>("CaroueselID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("CaroueselID"));

                    b.Property<string>("CarouselAciklama")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("CarouselBaslik")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("CarouselFotoUrl")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("CaroueselID");

                    b.ToTable("Carousels");
                });

            modelBuilder.Entity("Kariyer_net.Models.Contact", b =>
                {
                    b.Property<int>("ContactID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("ContactID"));

                    b.Property<string>("Lokasyon")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Mail")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Telefon")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("ContactID");

                    b.ToTable("Contacts");
                });

            modelBuilder.Entity("Kariyer_net.Models.Firma", b =>
                {
                    b.Property<int>("FirmaID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("FirmaID"));

                    b.Property<string>("FirmaAciklama")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("FirmaAdi")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("FirmaID");

                    b.ToTable("Firmas");
                });

            modelBuilder.Entity("Kariyer_net.Models.Ilan", b =>
                {
                    b.Property<int>("IlanID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("IlanID"));

                    b.Property<int>("BasvuruSayisi")
                        .HasColumnType("int");

                    b.Property<string>("CalismaTuru")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Firma")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("IlanAciklama")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("IlanBaslik")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("IlanSorumluluklar")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("IlanYetenekler")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("KategoriID")
                        .HasColumnType("int");

                    b.Property<string>("Sehir")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Ulke")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("YayimlanmaTarihi")
                        .HasColumnType("datetime2");

                    b.HasKey("IlanID");

                    b.HasIndex("KategoriID");

                    b.ToTable("Ilans");
                });

            modelBuilder.Entity("Kariyer_net.Models.Kategori", b =>
                {
                    b.Property<int>("KategoriID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("KategoriID"));

                    b.Property<int>("KategoriBasvuranSayisi")
                        .HasColumnType("int");

                    b.Property<string>("KategoriFoto")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("KategoriIsmi")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("KategoriID");

                    b.ToTable("Kategoris");
                });

            modelBuilder.Entity("Kariyer_net.Models.Referance", b =>
                {
                    b.Property<int>("ReferansID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("ReferansID"));

                    b.Property<string>("ReferansAd")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ReferansMeslek")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ReferansResimUrl")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ReferansYazisi")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("ReferansID");

                    b.ToTable("Referances");
                });

            modelBuilder.Entity("Kariyer_net.Models.Ilan", b =>
                {
                    b.HasOne("Kariyer_net.Models.Kategori", "Kategori")
                        .WithMany("Ilans")
                        .HasForeignKey("KategoriID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Kategori");
                });

            modelBuilder.Entity("Kariyer_net.Models.Kategori", b =>
                {
                    b.Navigation("Ilans");
                });
#pragma warning restore 612, 618
        }
    }
}

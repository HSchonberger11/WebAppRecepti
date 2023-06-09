﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using WebAppRecepti.Models;

#nullable disable

namespace WebAppRecepti.Migrations
{
    [DbContext(typeof(AppDbContext))]
    [Migration("20230525064434_KreiranjeBazeSPodatcima")]
    partial class KreiranjeBazeSPodatcima
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.13")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder, 1L, 1);

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRole", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.Property<string>("NormalizedName")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.HasKey("Id");

                    b.HasIndex("NormalizedName")
                        .IsUnique()
                        .HasDatabaseName("RoleNameIndex")
                        .HasFilter("[NormalizedName] IS NOT NULL");

                    b.ToTable("AspNetRoles", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRoleClaim<string>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("ClaimType")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ClaimValue")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("RoleId")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("Id");

                    b.HasIndex("RoleId");

                    b.ToTable("AspNetRoleClaims", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUser", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("nvarchar(450)");

                    b.Property<int>("AccessFailedCount")
                        .HasColumnType("int");

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Email")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.Property<bool>("EmailConfirmed")
                        .HasColumnType("bit");

                    b.Property<bool>("LockoutEnabled")
                        .HasColumnType("bit");

                    b.Property<DateTimeOffset?>("LockoutEnd")
                        .HasColumnType("datetimeoffset");

                    b.Property<string>("NormalizedEmail")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.Property<string>("NormalizedUserName")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.Property<string>("PasswordHash")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("PhoneNumber")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("PhoneNumberConfirmed")
                        .HasColumnType("bit");

                    b.Property<string>("SecurityStamp")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("TwoFactorEnabled")
                        .HasColumnType("bit");

                    b.Property<string>("UserName")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.HasKey("Id");

                    b.HasIndex("NormalizedEmail")
                        .HasDatabaseName("EmailIndex");

                    b.HasIndex("NormalizedUserName")
                        .IsUnique()
                        .HasDatabaseName("UserNameIndex")
                        .HasFilter("[NormalizedUserName] IS NOT NULL");

                    b.ToTable("AspNetUsers", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserClaim<string>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("ClaimType")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ClaimValue")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("UserId")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("Id");

                    b.HasIndex("UserId");

                    b.ToTable("AspNetUserClaims", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserLogin<string>", b =>
                {
                    b.Property<string>("LoginProvider")
                        .HasMaxLength(128)
                        .HasColumnType("nvarchar(128)");

                    b.Property<string>("ProviderKey")
                        .HasMaxLength(128)
                        .HasColumnType("nvarchar(128)");

                    b.Property<string>("ProviderDisplayName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("UserId")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("LoginProvider", "ProviderKey");

                    b.HasIndex("UserId");

                    b.ToTable("AspNetUserLogins", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserRole<string>", b =>
                {
                    b.Property<string>("UserId")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("RoleId")
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("UserId", "RoleId");

                    b.HasIndex("RoleId");

                    b.ToTable("AspNetUserRoles", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserToken<string>", b =>
                {
                    b.Property<string>("UserId")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("LoginProvider")
                        .HasMaxLength(128)
                        .HasColumnType("nvarchar(128)");

                    b.Property<string>("Name")
                        .HasMaxLength(128)
                        .HasColumnType("nvarchar(128)");

                    b.Property<string>("Value")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("UserId", "LoginProvider", "Name");

                    b.ToTable("AspNetUserTokens", (string)null);
                });

            modelBuilder.Entity("WebAppRecepti.Models.Kategorija", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("Naziv")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Kategorija");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Naziv = "Dorucak"
                        },
                        new
                        {
                            Id = 2,
                            Naziv = "Rucak"
                        },
                        new
                        {
                            Id = 3,
                            Naziv = "Vecera"
                        },
                        new
                        {
                            Id = 4,
                            Naziv = "Desert"
                        },
                        new
                        {
                            Id = 5,
                            Naziv = "Vegansko"
                        });
                });

            modelBuilder.Entity("WebAppRecepti.Models.Recept", b =>
                {
                    b.Property<int>("Id")
                        .HasColumnType("int");

                    b.Property<int>("BrojOsoba")
                        .HasColumnType("int");

                    b.Property<int>("KategorijaId")
                        .HasColumnType("int");

                    b.Property<string>("Naziv")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Priprema")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Sastojci")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("SlikaUrl")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("VrijemePripreme")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("KategorijaId");

                    b.ToTable("Recept");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            BrojOsoba = 1,
                            KategorijaId = 1,
                            Naziv = "Energetski dorucak",
                            Priprema = "1. Zobenim pahuljicama dodajte bademe, suho voće, vocni namaz borovnica i prelijte toplim ili hladnim biljnim napitkom., 2.Promijesajte, dodajte narezanu bananu i borovnice.",
                            Sastojci = "35 g zobenih pahuljica, 2 zlice badema, 2 zlice suhog voća,150 ml biljnog napitka, 1 zlica namaza borovnica 100% iz voća,1 banana, 1 zlica svjezih borovnica, 1 zlicica cimeta",
                            SlikaUrl = "https://podravkaiovariations.blob.core.windows.net/a016b5a8-ae85-11ec-87f1-ae48ed498d44/v/f2b1f6a6-64bc-11eb-b6c2-0242ac130010/1600x1200-f2b21938-64bc-11eb-9498-0242ac130010.webp",
                            VrijemePripreme = 5
                        },
                        new
                        {
                            Id = 2,
                            BrojOsoba = 1,
                            KategorijaId = 2,
                            Naziv = "Tjestenina s lososom",
                            Priprema = "1.Skuhati tjesteninu., 2.Na maslacu prziti cešsnjak i dodati kiselo vrhnje i vrhnje za kuhanje., 3.Dodati dimljeni losos, sol, papar i vlasac.",
                            Sastojci = "300 g tjestenine, 200 g dimljenog lososa, cesnjak, maslac, kiselo vrhnje, vrhnje za kuhanje, sol, papar, vlasac, persin, limunov sok",
                            SlikaUrl = "https://www.sprinklesandsprouts.com/wp-content/uploads/2019/04/Creamy-Lemon-and-Salmon-Pasta-SQ.jpg",
                            VrijemePripreme = 15
                        },
                        new
                        {
                            Id = 3,
                            BrojOsoba = 1,
                            KategorijaId = 3,
                            Naziv = "Heljda i jagoda",
                            Priprema = "1.Heljdu sirovu ili kratko kuhanu izmiksati i dodati jagode 2. Nekoliko zlica namocenih ( preko noci) chia sjemenki dodati na smjesu",
                            Sastojci = "50 g svijetle heljde, 200 g jagoda, 3-4 zlice chia sjemenki",
                            SlikaUrl = "https://podravkaiovariations.blob.core.windows.net/4a9dff42-6402-11eb-8920-0242ac12002a/v/f2b1f6a6-64bc-11eb-b6c2-0242ac130010/1600x1200-f2b21938-64bc-11eb-9498-0242ac130010.webp",
                            VrijemePripreme = 5
                        },
                        new
                        {
                            Id = 4,
                            BrojOsoba = 1,
                            KategorijaId = 4,
                            Naziv = "Ice coffe tiramisu",
                            Priprema = "1. Mlijeko, shake, bananu i kavu pomijesati u blenderu. 2.Izliti u visoku casu i posluzite uz kuglu sladoleda.",
                            Sastojci = "200 ml mlijeka, 1 Dolcela HI protein Tiramisu shake, 1 banana, 70 ml crne kave, 1 kugla sladoleda od vanilije ili cokolade",
                            SlikaUrl = "https://podravkaiovariations.blob.core.windows.net/3b7f4dce-c30d-11ed-9cd1-c631db9ba15e/v/f2b1f6a6-64bc-11eb-b6c2-0242ac130010/1600x1200-f2b21938-64bc-11eb-9498-0242ac130010.webp",
                            VrijemePripreme = 15
                        },
                        new
                        {
                            Id = 5,
                            BrojOsoba = 1,
                            KategorijaId = 5,
                            Naziv = "Zeleni smoothie",
                            Priprema = "1. Povrce oprati i narezati na manje komade, bananu narezati, naribati korijen đumbira. 2.Povrce, bananu, djumbir, kurkumu, kikiriki maslac i jogurt ubaciti u blender te izmiksati.",
                            Sastojci = "1 salica zelenog povrća,1 zrela banana, 1 zlicica kikiriki maslaca,1 zlicica kokosovog ulja, 1 zlicice Vegeta Maestro kurkuma, 2 dcl vode ili jogurta, svjez djumbir",
                            SlikaUrl = "https://fraicheliving.com/wp-content/uploads/2021/01/fraiche-living-tropical-green-smoothie.jpg",
                            VrijemePripreme = 10
                        });
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRoleClaim<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityRole", null)
                        .WithMany()
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserClaim<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserLogin<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserRole<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityRole", null)
                        .WithMany()
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserToken<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("WebAppRecepti.Models.Recept", b =>
                {
                    b.HasOne("WebAppRecepti.Models.Kategorija", "Kategorija")
                        .WithMany("Recepti")
                        .HasForeignKey("KategorijaId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Kategorija");
                });

            modelBuilder.Entity("WebAppRecepti.Models.Kategorija", b =>
                {
                    b.Navigation("Recepti");
                });
#pragma warning restore 612, 618
        }
    }
}

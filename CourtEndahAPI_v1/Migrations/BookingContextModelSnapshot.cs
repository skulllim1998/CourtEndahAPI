﻿// <auto-generated />
using CourtEndahAPI_v1.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace CourtEndahAPI_v1.Migrations
{
    [DbContext(typeof(BookingContext))]
    partial class BookingContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("ProductVersion", "5.0.9")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("CourtEndahAPI_v1.DomainClasses.ADMIN_T", b =>
                {
                    b.Property<int>("admin_id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("admin_password")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("admin_username")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("admin_id");

                    b.ToTable("ADMIN_Ts");

                    b.HasData(
                        new
                        {
                            admin_id = 1,
                            admin_password = "12345",
                            admin_username = "admin"
                        });
                });

            modelBuilder.Entity("CourtEndahAPI_v1.DomainClasses.BOOKING_T", b =>
                {
                    b.Property<int>("book_id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("book_active")
                        .HasColumnType("int");

                    b.Property<string>("book_createdate")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("book_date")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("book_time")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("court_id")
                        .HasColumnType("int");

                    b.Property<int>("play_id")
                        .HasColumnType("int");

                    b.HasKey("book_id");

                    b.ToTable("BOOKING_Ts");
                });

            modelBuilder.Entity("CourtEndahAPI_v1.DomainClasses.COURT_T", b =>
                {
                    b.Property<int>("court_id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("court_active")
                        .HasColumnType("int");

                    b.Property<string>("court_type")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("court_id");

                    b.ToTable("COURT_Ts");

                    b.HasData(
                        new
                        {
                            court_id = 1,
                            court_active = 1,
                            court_type = "Court A"
                        },
                        new
                        {
                            court_id = 2,
                            court_active = 1,
                            court_type = "Court B"
                        });
                });

            modelBuilder.Entity("CourtEndahAPI_v1.DomainClasses.PLAYER_T", b =>
                {
                    b.Property<int>("play_id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("play_active")
                        .HasColumnType("int");

                    b.Property<string>("play_cardno")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("play_createdate")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("play_fullname")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("play_password")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("play_unitno")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("play_username")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("play_id");

                    b.ToTable("PLAYER_Ts");

                    b.HasData(
                        new
                        {
                            play_id = 1,
                            play_active = 1,
                            play_cardno = "D3517",
                            play_createdate = "4/4/2023 11:54:41 PM",
                            play_fullname = "lim",
                            play_password = "12345",
                            play_unitno = "D1006",
                            play_username = "lim@gmail.com"
                        },
                        new
                        {
                            play_id = 2,
                            play_active = 1,
                            play_cardno = "D4059",
                            play_createdate = "4/4/2023 11:54:41 PM",
                            play_fullname = "choong",
                            play_password = "12345",
                            play_unitno = "C163A",
                            play_username = "choong@gmail.com"
                        });
                });
#pragma warning restore 612, 618
        }
    }
}

﻿// <auto-generated />
using System;
using TropicSun.DAL;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace TropicSun.Migrations
{
    [DbContext(typeof(ApplicationDBContext))]
    partial class ApplicationDBContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.0")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("TropicSun.Models.Location", b =>
                {
                    b.Property<int>("LocationId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("LocationId"));

                    b.HasKey("LocationId");

                    b.ToTable("Location");
                });

            modelBuilder.Entity("TropicSun.Models.Reservation", b =>
                {
                    b.Property<int>("ReservationId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("ReservationId"));

                    b.Property<DateTime>("EndDate")
                        .HasColumnType("datetime2");

                    b.Property<int?>("EndLocationLocationId")
                        .HasColumnType("int");

                    b.Property<DateTime>("ReservationDate")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("StartDate")
                        .HasColumnType("datetime2");

                    b.Property<int?>("StartLocationLocationId")
                        .HasColumnType("int");

                    b.Property<int?>("YachtId")
                        .HasColumnType("int");

                    b.HasKey("ReservationId");

                    b.HasIndex("EndLocationLocationId");

                    b.HasIndex("StartLocationLocationId");

                    b.HasIndex("YachtId");

                    b.ToTable("Reservation", (string)null);

                    b.HasData(
                        new
                        {
                            ReservationId = 1,
                            EndDate = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            ReservationDate = new DateTime(2024, 2, 8, 17, 14, 51, 109, DateTimeKind.Local).AddTicks(248),
                            StartDate = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            YachtId = 1
                        });
                });

            modelBuilder.Entity("TropicSun.Models.Yacht", b =>
                {
                    b.Property<int>("YachtId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("YachtId"));

                    b.HasKey("YachtId");

                    b.ToTable("Yacht", (string)null);

                    b.HasData(
                        new
                        {
                            YachtId = 1
                        });
                });

            modelBuilder.Entity("TropicSun.Models.Reservation", b =>
                {
                    b.HasOne("TropicSun.Models.Location", "EndLocation")
                        .WithMany()
                        .HasForeignKey("EndLocationLocationId");

                    b.HasOne("TropicSun.Models.Location", "StartLocation")
                        .WithMany()
                        .HasForeignKey("StartLocationLocationId");

                    b.HasOne("TropicSun.Models.Yacht", "Yacht")
                        .WithMany()
                        .HasForeignKey("YachtId");

                    b.Navigation("EndLocation");

                    b.Navigation("StartLocation");

                    b.Navigation("Yacht");
                });
#pragma warning restore 612, 618
        }
    }
}

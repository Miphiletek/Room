// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage;
using Microsoft.EntityFrameworkCore.Storage.Internal;
using System;
using TheRooms.Data;

namespace TheRooms.Migrations
{
    [DbContext(typeof(DataContext))]
    [Migration("20170829182559_CompletedRoomsAndPlayers")]
    partial class CompletedRoomsAndPlayers
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.0.0-rtm-26452")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("TheRooms.Models.CompletedRoom", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("PlayerId");

                    b.Property<int>("RoomId");

                    b.HasKey("Id");

                    b.HasIndex("PlayerId");

                    b.HasIndex("RoomId");

                    b.ToTable("CompletedRooms");
                });

            modelBuilder.Entity("TheRooms.Models.Door", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<int>("RoomFromId");

                    b.Property<int>("RoomToId");

                    b.HasKey("Id");

                    b.HasIndex("RoomFromId");

                    b.HasIndex("RoomToId");

                    b.ToTable("Doors");
                });

            modelBuilder.Entity("TheRooms.Models.Player", b =>
                {
                    b.Property<string>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Name");

                    b.HasKey("Id");

                    b.ToTable("Players");
                });

            modelBuilder.Entity("TheRooms.Models.Room", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Answer");

                    b.Property<string>("Name");

                    b.Property<string>("Task");

                    b.HasKey("Id");

                    b.ToTable("Rooms");
                });

            modelBuilder.Entity("TheRooms.Models.CompletedRoom", b =>
                {
                    b.HasOne("TheRooms.Models.Player", "Player")
                        .WithMany("CompletedRooms")
                        .HasForeignKey("PlayerId")
                        .OnDelete(DeleteBehavior.Restrict);

                    b.HasOne("TheRooms.Models.Room", "Room")
                        .WithMany("CompletedRooms")
                        .HasForeignKey("RoomId")
                        .OnDelete(DeleteBehavior.Restrict);
                });

            modelBuilder.Entity("TheRooms.Models.Door", b =>
                {
                    b.HasOne("TheRooms.Models.Room", "RoomFrom")
                        .WithMany("DoorsOut")
                        .HasForeignKey("RoomFromId")
                        .OnDelete(DeleteBehavior.Restrict);

                    b.HasOne("TheRooms.Models.Room", "RoomTo")
                        .WithMany("DoorsIn")
                        .HasForeignKey("RoomToId")
                        .OnDelete(DeleteBehavior.Restrict);
                });
#pragma warning restore 612, 618
        }
    }
}

﻿// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using SkyDrive.Models;

namespace SkyDrive.Migrations
{
    [DbContext(typeof(SkyDriveContext))]
    partial class SkyDriveContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.1.4-rtm-31024")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("SkyDrive.Models.Account", b =>
                {
                    b.Property<string>("UserId")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Email")
                        .IsRequired();

                    b.Property<string>("FullName");

                    b.Property<string>("Password")
                        .IsRequired();

                    b.HasKey("UserId");

                    b.ToTable("Account");
                });

            modelBuilder.Entity("SkyDrive.Models.FileMapping", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("File")
                        .IsRequired();

                    b.Property<string>("UserId");

                    b.HasKey("ID");

                    b.HasIndex("UserId");

                    b.ToTable("FileMapping");
                });

            modelBuilder.Entity("SkyDrive.Models.Note", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Body");

                    b.Property<string>("Title")
                        .IsRequired();

                    b.Property<string>("UserId");

                    b.HasKey("ID");

                    b.HasIndex("UserId");

                    b.ToTable("Note");
                });

            modelBuilder.Entity("SkyDrive.Models.FileMapping", b =>
                {
                    b.HasOne("SkyDrive.Models.Account", "Auth")
                        .WithMany()
                        .HasForeignKey("UserId");
                });

            modelBuilder.Entity("SkyDrive.Models.Note", b =>
                {
                    b.HasOne("SkyDrive.Models.Account", "Auth")
                        .WithMany()
                        .HasForeignKey("UserId");
                });
#pragma warning restore 612, 618
        }
    }
}
﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using ReviewManagement.Infrastructure.EFCore;

namespace ReviewManagement.Infrastructure.EFCore.Migrations
{
    [DbContext(typeof(ReviewContext))]
    [Migration("20220612010037_ChangeToEditVideoReview")]
    partial class ChangeToEditVideoReview
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("ProductVersion", "5.0.9")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("ReviewManagement.Domain.ReviewAgg.Review", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<DateTime>("CreationDate")
                        .HasColumnType("datetime2");

                    b.Property<int>("EditSoundQuality")
                        .HasMaxLength(2)
                        .HasColumnType("int");

                    b.Property<int>("EditVideoQuality")
                        .HasMaxLength(2)
                        .HasColumnType("int");

                    b.Property<bool>("IsConfirmed")
                        .HasColumnType("bit");

                    b.Property<int>("IsHarmful")
                        .HasMaxLength(4)
                        .HasColumnType("int");

                    b.Property<int>("IsHelpful")
                        .HasMaxLength(4)
                        .HasColumnType("int");

                    b.Property<string>("Message")
                        .IsRequired()
                        .HasMaxLength(200)
                        .HasColumnType("nvarchar(200)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.Property<long>("OwnerRecordId")
                        .HasColumnType("bigint");

                    b.Property<int>("Rate")
                        .HasMaxLength(2)
                        .HasColumnType("int");

                    b.Property<string>("Strength")
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.Property<int>("UseProperFontAndColors")
                        .HasMaxLength(2)
                        .HasColumnType("int");

                    b.Property<int>("UseProperMemes")
                        .HasMaxLength(2)
                        .HasColumnType("int");

                    b.Property<int>("UseProperSoundEffects")
                        .HasMaxLength(2)
                        .HasColumnType("int");

                    b.Property<int>("UseProperVideoEffects")
                        .HasMaxLength(2)
                        .HasColumnType("int");

                    b.Property<string>("Weakness")
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.HasKey("Id");

                    b.ToTable("Reviews");
                });
#pragma warning restore 612, 618
        }
    }
}

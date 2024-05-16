﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using PlanManagement.Infrastructure.EFCore;

namespace PlanManagement.Infrastructure.EFCore.Migrations
{
    [DbContext(typeof(PlanContext))]
    [Migration("20220629105406_Init")]
    partial class Init
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("ProductVersion", "5.0.9")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("PlanManagement.Domain.EditorPlanAgg.EditorPlan", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<short>("ChatUploadSizeLimit")
                        .HasColumnType("smallint");

                    b.Property<DateTime>("CreationDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("Description")
                        .HasMaxLength(550)
                        .HasColumnType("nvarchar(550)");

                    b.Property<short>("ExpireDays")
                        .HasColumnType("smallint");

                    b.Property<bool>("IsRemoved")
                        .HasColumnType("bit");

                    b.Property<short>("PortfolioUploadSizeLimit")
                        .HasColumnType("smallint");

                    b.Property<double>("Price")
                        .HasColumnType("float");

                    b.Property<string>("Title")
                        .IsRequired()
                        .HasMaxLength(250)
                        .HasColumnType("nvarchar(250)");

                    b.Property<short>("VipProjectOfferCount")
                        .HasColumnType("smallint");

                    b.HasKey("Id");

                    b.ToTable("EditorPlans");
                });

            modelBuilder.Entity("PlanManagement.Domain.EditorPlanOrderAgg.EditorPlanOrder", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<DateTime>("CreationDate")
                        .HasColumnType("datetime2");

                    b.Property<long>("EditorPageId")
                        .HasColumnType("bigint");

                    b.Property<long>("EditorPlanId")
                        .HasColumnType("bigint");

                    b.Property<bool>("IsCanceled")
                        .HasColumnType("bit");

                    b.Property<bool>("IsPaid")
                        .HasColumnType("bit");

                    b.Property<double>("PayAmount")
                        .HasColumnType("float");

                    b.Property<long>("RefId")
                        .HasColumnType("bigint");

                    b.HasKey("Id");

                    b.ToTable("EditorPlanOrders");
                });
#pragma warning restore 612, 618
        }
    }
}

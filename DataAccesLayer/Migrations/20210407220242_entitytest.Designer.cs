﻿// <auto-generated />
using System;
using DataAccesLayer;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace DataAccesLayer.Migrations
{
    [DbContext(typeof(MachineContext))]
    [Migration("20210407220242_entitytest")]
    partial class entitytest
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "3.1.12")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("DataAccesLayer.Entity.Comment", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("PostedDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("Text")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("Toxic")
                        .HasColumnType("bit");

                    b.HasKey("ID");

                    b.ToTable("Comments");

                    b.HasData(
                        new
                        {
                            ID = 1,
                            Name = "Allf3",
                            PostedDate = new DateTime(2021, 4, 8, 0, 2, 42, 570, DateTimeKind.Local).AddTicks(2884),
                            Text = "You are just a degenerate retard",
                            Toxic = true
                        });
                });

            modelBuilder.Entity("DataAccesLayer.Entity.House", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<float>("Bathrooms")
                        .HasColumnType("real");

                    b.Property<float>("Bedrooms")
                        .HasColumnType("real");

                    b.Property<string>("City")
                        .HasColumnType("nvarchar(max)");

                    b.Property<float>("Condition")
                        .HasColumnType("real");

                    b.Property<string>("Country")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Date")
                        .HasColumnType("nvarchar(max)");

                    b.Property<float>("Floors")
                        .HasColumnType("real");

                    b.Property<float>("PredictedScore")
                        .HasColumnType("real");

                    b.Property<float>("Price")
                        .HasColumnType("real");

                    b.Property<float>("Sqft_above")
                        .HasColumnType("real");

                    b.Property<float>("Sqft_basement")
                        .HasColumnType("real");

                    b.Property<float>("Sqft_living")
                        .HasColumnType("real");

                    b.Property<float>("Sqft_lot")
                        .HasColumnType("real");

                    b.Property<string>("Statezip")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Street")
                        .HasColumnType("nvarchar(max)");

                    b.Property<float>("View")
                        .HasColumnType("real");

                    b.Property<float>("Waterfront")
                        .HasColumnType("real");

                    b.Property<DateTime>("Yr_built")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("Yr_renovated")
                        .HasColumnType("datetime2");

                    b.HasKey("ID");

                    b.ToTable("Houses");
                });
#pragma warning restore 612, 618
        }
    }
}
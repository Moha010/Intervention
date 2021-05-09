﻿// <auto-generated />
using System;
using Interventions.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace Intervention.Migrations
{
    [DbContext(typeof(InterventionsContext))]
    [Migration("20210504223943_VersionInitiale")]
    partial class VersionInitiale
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("ProductVersion", "5.0.5")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("Intervention.Data.Entities.Probleme", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("courriel")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("dateProbleme")
                        .HasColumnType("datetime2");

                    b.Property<string>("descriptionProbleme")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("noProbleme")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("noUnite")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("nomProbleme")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("notifications")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("prenom")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<string>("telephone")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Problemes", "dbo");
                });

            modelBuilder.Entity("Intervention.Data.Entities.TypeProbleme", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("descriptionProbleme")
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.HasKey("Id");

                    b.ToTable("TypeProbleme", "dbo");
                });
#pragma warning restore 612, 618
        }
    }
}

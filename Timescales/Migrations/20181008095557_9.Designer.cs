﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;
using Timescales.Models;

namespace Timescales.Migrations
{
    [DbContext(typeof(Context))]
    [Migration("20181008095557_9")]
    partial class _9
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.SerialColumn)
                .HasAnnotation("ProductVersion", "2.1.3-rtm-32065")
                .HasAnnotation("Relational:MaxIdentifierLength", 63);

            modelBuilder.Entity("Timescales.Models.Audit", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Action")
                        .IsRequired()
                        .HasMaxLength(7);

                    b.Property<DateTime>("DateTime");

                    b.Property<int>("Days");

                    b.Property<DateTime>("OldestWorkDate");

                    b.Property<Guid>("TimescaleId");

                    b.Property<string>("User")
                        .IsRequired()
                        .HasMaxLength(7);

                    b.HasKey("Id");

                    b.HasIndex("TimescaleId");

                    b.ToTable("Audits");
                });

            modelBuilder.Entity("Timescales.Models.Timescale", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Basis")
                        .IsRequired()
                        .HasMaxLength(10);

                    b.Property<int>("Days");

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasMaxLength(256);

                    b.Property<string>("LineOfBusiness")
                        .IsRequired()
                        .HasMaxLength(3);

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(256);

                    b.Property<DateTime>("OldestWorkDate");

                    b.Property<string>("Owners")
                        .IsRequired();

                    b.Property<string>("Placeholder")
                        .IsRequired()
                        .HasMaxLength(60);

                    b.Property<DateTime>("UpdatedDate");

                    b.HasKey("Id");

                    b.HasIndex("Placeholder")
                        .IsUnique();

                    b.ToTable("Timescales");
                });

            modelBuilder.Entity("Timescales.Models.Audit", b =>
                {
                    b.HasOne("Timescales.Models.Timescale", "Timescale")
                        .WithMany("Audit")
                        .HasForeignKey("TimescaleId")
                        .OnDelete(DeleteBehavior.Cascade);
                });
#pragma warning restore 612, 618
        }
    }
}

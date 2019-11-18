﻿// <auto-generated />
using ETR2.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace ETR2.Migrations
{
    [DbContext(typeof(AppDbContext))]
    [Migration("20191015030705_01_InitialMigration")]
    partial class _01_InitialMigration
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.2.6-servicing-10079")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("ETR2.Models.Technology", b =>
                {
                    b.Property<int>("TechID")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("LandingZone");

                    b.Property<string>("TechnologyDescription");

                    b.Property<string>("TechnologyName")
                        .IsRequired();

                    b.HasKey("TechID");

                    b.ToTable("TechnologyMaster");
                });
#pragma warning restore 612, 618
        }
    }
}

﻿// <auto-generated />
using System;
using Laklp.Platform.Data.Context;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace Laklp.Platform.Data.Migrations
{
    [DbContext(typeof(LaklpDbContext))]
    [Migration("20190801025815_InitialCreate")]
    partial class InitialCreate
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.2.6-servicing-10079")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("Laklp.Platform.Data.Entities.Entity", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<DateTime>("Created");

                    b.Property<string>("Description");

                    b.Property<DateTime>("Modified");

                    b.Property<string>("Name");

                    b.Property<Guid?>("ParentId");

                    b.HasKey("Id");

                    b.HasIndex("ParentId");

                    b.ToTable("Entities");
                });

            modelBuilder.Entity("Laklp.Platform.Data.Entities.Maintenance", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<DateTime>("Created");

                    b.Property<string>("Description");

                    b.Property<DateTime>("Modified");

                    b.Property<string>("Name");

                    b.HasKey("Id");

                    b.ToTable("Maintenances");
                });

            modelBuilder.Entity("Laklp.Platform.Data.Entities.Resource", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<DateTime>("Created");

                    b.Property<string>("Description");

                    b.Property<Guid?>("EntityId");

                    b.Property<Guid?>("MaintenanceId");

                    b.Property<DateTime>("Modified");

                    b.Property<string>("Name");

                    b.Property<string>("Properties");

                    b.Property<string>("Url");

                    b.HasKey("Id");

                    b.HasIndex("EntityId");

                    b.HasIndex("MaintenanceId");

                    b.ToTable("DocumentaryResources");
                });

            modelBuilder.Entity("Laklp.Platform.Data.Entities.Entity", b =>
                {
                    b.HasOne("Laklp.Platform.Data.Entities.Entity", "Parent")
                        .WithMany("Components")
                        .HasForeignKey("ParentId");
                });

            modelBuilder.Entity("Laklp.Platform.Data.Entities.Resource", b =>
                {
                    b.HasOne("Laklp.Platform.Data.Entities.Entity", "Entity")
                        .WithMany("DocumentaryResources")
                        .HasForeignKey("EntityId");

                    b.HasOne("Laklp.Platform.Data.Entities.Maintenance")
                        .WithMany("DocumentaryResources")
                        .HasForeignKey("MaintenanceId");
                });
#pragma warning restore 612, 618
        }
    }
}
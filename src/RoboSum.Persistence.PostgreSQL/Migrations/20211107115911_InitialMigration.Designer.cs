﻿// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;
using RoboSum.Persistence.PostgreSQL;

#nullable disable

namespace RoboSum.Persistence.PostgreSQL.Migrations
{
    [DbContext(typeof(RoboSumContext))]
    [Migration("20211107115911_InitialMigration")]
    partial class InitialMigration
    {
        /// <inheritdoc cref="Migration.BuildTargetModel(ModelBuilder)"/>
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.0-rc.2.21480.5")
                .HasAnnotation("Relational:MaxIdentifierLength", 63);

            NpgsqlModelBuilderExtensions.UseIdentityByDefaultColumns(modelBuilder);

            modelBuilder.Entity("RoboSum.Domain.Entities.Address", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("Id"));

                    b.Property<string>("City")
                        .IsRequired()
                        .HasMaxLength(64)
                        .HasColumnType("character varying(64)");

                    b.Property<string>("Country")
                        .IsRequired()
                        .HasMaxLength(64)
                        .HasColumnType("character varying(64)");

                    b.Property<string>("HouseNumber")
                        .IsRequired()
                        .HasMaxLength(8)
                        .HasColumnType("character varying(8)");

                    b.Property<int>("SchoolId")
                        .HasColumnType("integer");

                    b.Property<string>("Street")
                        .IsRequired()
                        .HasMaxLength(128)
                        .HasColumnType("character varying(128)");

                    b.Property<int>("ZipCode")
                        .HasMaxLength(16)
                        .HasColumnType("integer");

                    b.HasKey("Id");

                    b.HasIndex("SchoolId")
                        .IsUnique();

                    b.ToTable("Addresses");
                });

            modelBuilder.Entity("RoboSum.Domain.Entities.Competition", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("Id"));

                    b.Property<int>("RegistrationId")
                        .HasColumnType("integer");

                    b.Property<bool>("RoboCross")
                        .HasColumnType("boolean");

                    b.Property<bool>("RoboSum")
                        .HasColumnType("boolean");

                    b.HasKey("Id");

                    b.ToTable("Competitions");
                });

            modelBuilder.Entity("RoboSum.Domain.Entities.Person", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("Id"));

                    b.Property<string>("Discriminator")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("FirstName")
                        .IsRequired()
                        .HasMaxLength(128)
                        .HasColumnType("character varying(128)");

                    b.Property<string>("LastName")
                        .IsRequired()
                        .HasMaxLength(128)
                        .HasColumnType("character varying(128)");

                    b.HasKey("Id");

                    b.ToTable("Person");

                    b.HasDiscriminator<string>("Discriminator").HasValue("Person");
                });

            modelBuilder.Entity("RoboSum.Domain.Entities.Registration", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("Id"));

                    b.Property<int>("CompetitionId")
                        .HasColumnType("integer");

                    b.Property<int>("RegistrationYear")
                        .HasColumnType("integer");

                    b.Property<string>("Remarks")
                        .HasColumnType("text");

                    b.Property<int>("TeamId")
                        .HasColumnType("integer");

                    b.HasKey("Id");

                    b.HasIndex("CompetitionId")
                        .IsUnique();

                    b.ToTable("Registrations");
                });

            modelBuilder.Entity("RoboSum.Domain.Entities.School", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("Id"));

                    b.Property<int>("AddressId")
                        .HasColumnType("integer");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(128)
                        .HasColumnType("character varying(128)");

                    b.HasKey("Id");

                    b.ToTable("Schools");
                });

            modelBuilder.Entity("RoboSum.Domain.Entities.Team", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("Id"));

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasMaxLength(128)
                        .HasColumnType("character varying(128)");

                    b.Property<int>("RegistrationId")
                        .HasColumnType("integer");

                    b.Property<int>("SchoolId")
                        .HasColumnType("integer");

                    b.Property<int>("TeacherId")
                        .HasColumnType("integer");

                    b.HasKey("Id");

                    b.HasIndex("RegistrationId")
                        .IsUnique();

                    b.HasIndex("SchoolId");

                    b.HasIndex("TeacherId");

                    b.ToTable("Teams");
                });

            modelBuilder.Entity("RoboSum.Domain.Entities.Competitor", b =>
                {
                    b.HasBaseType("RoboSum.Domain.Entities.Person");

                    b.Property<int>("Grade")
                        .HasColumnType("integer");

                    b.Property<int>("TeamId")
                        .HasColumnType("integer");

                    b.HasIndex("TeamId");

                    b.HasDiscriminator().HasValue("Competitor");
                });

            modelBuilder.Entity("RoboSum.Domain.Entities.Referee", b =>
                {
                    b.HasBaseType("RoboSum.Domain.Entities.Person");

                    b.HasDiscriminator().HasValue("Referee");
                });

            modelBuilder.Entity("RoboSum.Domain.Entities.Teacher", b =>
                {
                    b.HasBaseType("RoboSum.Domain.Entities.Person");

                    b.Property<int>("SchoolId")
                        .HasColumnType("integer");

                    b.HasIndex("SchoolId");

                    b.HasDiscriminator().HasValue("Teacher");
                });

            modelBuilder.Entity("RoboSum.Domain.Entities.Address", b =>
                {
                    b.HasOne("RoboSum.Domain.Entities.School", "School")
                        .WithOne("Address")
                        .HasForeignKey("RoboSum.Domain.Entities.Address", "SchoolId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("School");
                });

            modelBuilder.Entity("RoboSum.Domain.Entities.Registration", b =>
                {
                    b.HasOne("RoboSum.Domain.Entities.Competition", "Competition")
                        .WithOne("Registration")
                        .HasForeignKey("RoboSum.Domain.Entities.Registration", "CompetitionId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Competition");
                });

            modelBuilder.Entity("RoboSum.Domain.Entities.Team", b =>
                {
                    b.HasOne("RoboSum.Domain.Entities.Registration", "Registration")
                        .WithOne("Team")
                        .HasForeignKey("RoboSum.Domain.Entities.Team", "RegistrationId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("RoboSum.Domain.Entities.School", "School")
                        .WithMany("Teams")
                        .HasForeignKey("SchoolId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("RoboSum.Domain.Entities.Teacher", "Teacher")
                        .WithMany("Teams")
                        .HasForeignKey("TeacherId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Registration");

                    b.Navigation("School");

                    b.Navigation("Teacher");
                });

            modelBuilder.Entity("RoboSum.Domain.Entities.Competitor", b =>
                {
                    b.HasOne("RoboSum.Domain.Entities.Team", "Team")
                        .WithMany("Competitors")
                        .HasForeignKey("TeamId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Team");
                });

            modelBuilder.Entity("RoboSum.Domain.Entities.Teacher", b =>
                {
                    b.HasOne("RoboSum.Domain.Entities.School", "School")
                        .WithMany("Teachers")
                        .HasForeignKey("SchoolId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("School");
                });

            modelBuilder.Entity("RoboSum.Domain.Entities.Competition", b =>
                {
                    b.Navigation("Registration");
                });

            modelBuilder.Entity("RoboSum.Domain.Entities.Registration", b =>
                {
                    b.Navigation("Team");
                });

            modelBuilder.Entity("RoboSum.Domain.Entities.School", b =>
                {
                    b.Navigation("Address");

                    b.Navigation("Teachers");

                    b.Navigation("Teams");
                });

            modelBuilder.Entity("RoboSum.Domain.Entities.Team", b =>
                {
                    b.Navigation("Competitors");
                });

            modelBuilder.Entity("RoboSum.Domain.Entities.Teacher", b =>
                {
                    b.Navigation("Teams");
                });
#pragma warning restore 612, 618
        }
    }
}

﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using SquashNiagara.Data;

namespace SquashNiagara.Data.SQUASHMigrations
{
    [DbContext(typeof(SquashNiagaraContext))]
    [Migration("20190410173843_Initial")]
    partial class Initial
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasDefaultSchema("SQUASH")
                .HasAnnotation("ProductVersion", "2.1.8-servicing-32085")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("SquashNiagara.Models.Division", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(50);

                    b.Property<short>("PositionNo");

                    b.HasKey("ID");

                    b.ToTable("Divisions");
                });

            modelBuilder.Entity("SquashNiagara.Models.Fixture", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<bool>("Approved")
                        .ValueGeneratedOnAdd()
                        .HasDefaultValue(false);

                    b.Property<double?>("AwayTeamBonus");

                    b.Property<int>("AwayTeamID");

                    b.Property<short?>("AwayTeamScore");

                    b.Property<int?>("CaptainApproveID");

                    b.Property<int?>("CaptainResultID");

                    b.Property<DateTime>("Date");

                    b.Property<int>("DivisionID");

                    b.Property<double?>("HomeTeamBonus");

                    b.Property<int>("HomeTeamID");

                    b.Property<short?>("HomeTeamScore");

                    b.Property<int>("SeasonID");

                    b.Property<DateTime>("Time");

                    b.Property<int>("VenueID");

                    b.HasKey("ID");

                    b.HasIndex("AwayTeamID");

                    b.HasIndex("CaptainApproveID");

                    b.HasIndex("CaptainResultID");

                    b.HasIndex("HomeTeamID");

                    b.HasIndex("SeasonID");

                    b.HasIndex("VenueID");

                    b.HasIndex("DivisionID", "HomeTeamID", "AwayTeamID", "Date", "Time")
                        .IsUnique();

                    b.ToTable("Fixtures");
                });

            modelBuilder.Entity("SquashNiagara.Models.Match", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("AwayPlayerID");

                    b.Property<short?>("AwayPlayerScore");

                    b.Property<bool?>("AwayPlayerViolation");

                    b.Property<int>("FixtureID");

                    b.Property<int>("HomePlayerID");

                    b.Property<short?>("HomePlayerScore");

                    b.Property<bool?>("HomePlayerViolation");

                    b.Property<int?>("PositionID");

                    b.HasKey("ID");

                    b.HasIndex("AwayPlayerID");

                    b.HasIndex("HomePlayerID");

                    b.HasIndex("PositionID");

                    b.HasIndex("FixtureID", "HomePlayerID", "AwayPlayerID")
                        .IsUnique();

                    b.ToTable("Matches");
                });

            modelBuilder.Entity("SquashNiagara.Models.Player", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<DateTime?>("DOB");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasMaxLength(255);

                    b.Property<string>("FirstName")
                        .IsRequired()
                        .HasMaxLength(50);

                    b.Property<bool>("IsEnabled")
                        .ValueGeneratedOnAdd()
                        .HasDefaultValue(true);

                    b.Property<string>("LastName")
                        .IsRequired()
                        .HasMaxLength(50);

                    b.Property<int?>("PositionID");

                    b.Property<int?>("TeamID");

                    b.Property<bool>("firstLogin")
                        .ValueGeneratedOnAdd()
                        .HasDefaultValue(true);

                    b.Property<byte[]>("imageContent");

                    b.Property<string>("imageFileName")
                        .HasMaxLength(100);

                    b.Property<string>("imageMimeType")
                        .HasMaxLength(256);

                    b.HasKey("ID");

                    b.HasIndex("Email")
                        .IsUnique();

                    b.HasIndex("PositionID");

                    b.HasIndex("TeamID");

                    b.ToTable("Players");
                });

            modelBuilder.Entity("SquashNiagara.Models.PlayerPosition", b =>
                {
                    b.Property<int>("PlayerID");

                    b.Property<int>("MatchID");

                    b.Property<int>("PositionID");

                    b.HasKey("PlayerID", "MatchID", "PositionID");

                    b.HasIndex("MatchID");

                    b.HasIndex("PositionID");

                    b.ToTable("PlayerPositions");
                });

            modelBuilder.Entity("SquashNiagara.Models.PlayerRanking", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<double>("Average");

                    b.Property<int>("DivisionID");

                    b.Property<int>("LostGames");

                    b.Property<int>("LostMatches");

                    b.Property<int>("Played");

                    b.Property<int>("PlayerID");

                    b.Property<double>("Points");

                    b.Property<int>("SeasonID");

                    b.Property<int>("TotalPositions");

                    b.Property<int>("WonGames");

                    b.Property<int>("WonMatches");

                    b.HasKey("ID");

                    b.HasIndex("DivisionID");

                    b.HasIndex("SeasonID");

                    b.HasIndex("PlayerID", "SeasonID", "DivisionID")
                        .IsUnique();

                    b.ToTable("PlayerRankings");
                });

            modelBuilder.Entity("SquashNiagara.Models.Position", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(10);

                    b.HasKey("ID");

                    b.ToTable("Positions");
                });

            modelBuilder.Entity("SquashNiagara.Models.Season", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<DateTime>("EndDate");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(50);

                    b.Property<DateTime>("StartDate");

                    b.HasKey("ID");

                    b.HasIndex("StartDate", "EndDate")
                        .IsUnique();

                    b.ToTable("Seasons");
                });

            modelBuilder.Entity("SquashNiagara.Models.SeasonDivisionTeam", b =>
                {
                    b.Property<int>("SeasonID");

                    b.Property<int>("DivisionID");

                    b.Property<int>("TeamID");

                    b.HasKey("SeasonID", "DivisionID", "TeamID");

                    b.HasIndex("DivisionID");

                    b.HasIndex("TeamID");

                    b.ToTable("SeasonDivisionTeams");
                });

            modelBuilder.Entity("SquashNiagara.Models.Team", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int?>("CaptainID");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(50);

                    b.Property<string>("Profile")
                        .HasMaxLength(1000);

                    b.Property<int?>("VenueID");

                    b.Property<byte[]>("imageContent");

                    b.Property<string>("imageFileName")
                        .HasMaxLength(100);

                    b.Property<string>("imageMimeType")
                        .HasMaxLength(256);

                    b.HasKey("ID");

                    b.HasIndex("CaptainID");

                    b.HasIndex("VenueID");

                    b.ToTable("Teams");
                });

            modelBuilder.Entity("SquashNiagara.Models.TeamRanking", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("DivisionID");

                    b.Property<int>("Lost");

                    b.Property<int>("Played");

                    b.Property<double>("Points");

                    b.Property<int>("SeasonID");

                    b.Property<int>("Strength");

                    b.Property<int>("TeamID");

                    b.Property<int>("Won");

                    b.HasKey("ID");

                    b.HasIndex("DivisionID");

                    b.HasIndex("SeasonID");

                    b.HasIndex("TeamID", "SeasonID", "DivisionID")
                        .IsUnique();

                    b.ToTable("TeamRankings");
                });

            modelBuilder.Entity("SquashNiagara.Models.Venue", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Address")
                        .HasMaxLength(256);

                    b.Property<string>("City")
                        .HasMaxLength(256);

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(50);

                    b.Property<string>("PostalCode")
                        .HasMaxLength(6);

                    b.Property<string>("Province")
                        .HasMaxLength(2);

                    b.HasKey("ID");

                    b.ToTable("Venues");
                });

            modelBuilder.Entity("SquashNiagara.Models.Fixture", b =>
                {
                    b.HasOne("SquashNiagara.Models.Team", "AwayTeam")
                        .WithMany("AwayFixtures")
                        .HasForeignKey("AwayTeamID")
                        .OnDelete(DeleteBehavior.Restrict);

                    b.HasOne("SquashNiagara.Models.Player", "CaptainApprove")
                        .WithMany("FixtureCaptainApproves")
                        .HasForeignKey("CaptainApproveID")
                        .OnDelete(DeleteBehavior.Restrict);

                    b.HasOne("SquashNiagara.Models.Player", "CaptainResult")
                        .WithMany("FixtureCaptainResults")
                        .HasForeignKey("CaptainResultID")
                        .OnDelete(DeleteBehavior.Restrict);

                    b.HasOne("SquashNiagara.Models.Division", "Division")
                        .WithMany("Fixtures")
                        .HasForeignKey("DivisionID")
                        .OnDelete(DeleteBehavior.Restrict);

                    b.HasOne("SquashNiagara.Models.Team", "HomeTeam")
                        .WithMany("HomeFixtures")
                        .HasForeignKey("HomeTeamID")
                        .OnDelete(DeleteBehavior.Restrict);

                    b.HasOne("SquashNiagara.Models.Season", "Season")
                        .WithMany("Fixtures")
                        .HasForeignKey("SeasonID")
                        .OnDelete(DeleteBehavior.Restrict);

                    b.HasOne("SquashNiagara.Models.Venue", "Venue")
                        .WithMany("Fixtures")
                        .HasForeignKey("VenueID")
                        .OnDelete(DeleteBehavior.Restrict);
                });

            modelBuilder.Entity("SquashNiagara.Models.Match", b =>
                {
                    b.HasOne("SquashNiagara.Models.Player", "AwayPlayer")
                        .WithMany("AwayMatches")
                        .HasForeignKey("AwayPlayerID")
                        .OnDelete(DeleteBehavior.Restrict);

                    b.HasOne("SquashNiagara.Models.Fixture", "Fixture")
                        .WithMany("Matches")
                        .HasForeignKey("FixtureID")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("SquashNiagara.Models.Player", "HomePlayer")
                        .WithMany("HomeMatches")
                        .HasForeignKey("HomePlayerID")
                        .OnDelete(DeleteBehavior.Restrict);

                    b.HasOne("SquashNiagara.Models.Position", "Position")
                        .WithMany("Matches")
                        .HasForeignKey("PositionID");
                });

            modelBuilder.Entity("SquashNiagara.Models.Player", b =>
                {
                    b.HasOne("SquashNiagara.Models.Position", "Position")
                        .WithMany("Players")
                        .HasForeignKey("PositionID");

                    b.HasOne("SquashNiagara.Models.Team", "Team")
                        .WithMany("Players")
                        .HasForeignKey("TeamID")
                        .OnDelete(DeleteBehavior.Restrict);
                });

            modelBuilder.Entity("SquashNiagara.Models.PlayerPosition", b =>
                {
                    b.HasOne("SquashNiagara.Models.Match", "Match")
                        .WithMany("PlayerPositions")
                        .HasForeignKey("MatchID")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("SquashNiagara.Models.Player", "Player")
                        .WithMany()
                        .HasForeignKey("PlayerID")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("SquashNiagara.Models.Position", "Position")
                        .WithMany("PlayerPositions")
                        .HasForeignKey("PositionID")
                        .OnDelete(DeleteBehavior.Restrict);
                });

            modelBuilder.Entity("SquashNiagara.Models.PlayerRanking", b =>
                {
                    b.HasOne("SquashNiagara.Models.Division", "Division")
                        .WithMany("PlayerRankings")
                        .HasForeignKey("DivisionID")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("SquashNiagara.Models.Player", "Player")
                        .WithMany("PlayerRankings")
                        .HasForeignKey("PlayerID")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("SquashNiagara.Models.Season", "Season")
                        .WithMany("PlayerRankings")
                        .HasForeignKey("SeasonID")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("SquashNiagara.Models.SeasonDivisionTeam", b =>
                {
                    b.HasOne("SquashNiagara.Models.Division", "Division")
                        .WithMany("SeasonDivisionTeams")
                        .HasForeignKey("DivisionID")
                        .OnDelete(DeleteBehavior.Restrict);

                    b.HasOne("SquashNiagara.Models.Season", "Season")
                        .WithMany("SeasonDivisionTeams")
                        .HasForeignKey("SeasonID")
                        .OnDelete(DeleteBehavior.Restrict);

                    b.HasOne("SquashNiagara.Models.Team", "Team")
                        .WithMany("SeasonDivisionTeams")
                        .HasForeignKey("TeamID")
                        .OnDelete(DeleteBehavior.Restrict);
                });

            modelBuilder.Entity("SquashNiagara.Models.Team", b =>
                {
                    b.HasOne("SquashNiagara.Models.Player", "Captain")
                        .WithMany()
                        .HasForeignKey("CaptainID");

                    b.HasOne("SquashNiagara.Models.Venue", "Venue")
                        .WithMany("Teams")
                        .HasForeignKey("VenueID")
                        .OnDelete(DeleteBehavior.Restrict);
                });

            modelBuilder.Entity("SquashNiagara.Models.TeamRanking", b =>
                {
                    b.HasOne("SquashNiagara.Models.Division", "Division")
                        .WithMany()
                        .HasForeignKey("DivisionID")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("SquashNiagara.Models.Season", "Season")
                        .WithMany()
                        .HasForeignKey("SeasonID")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("SquashNiagara.Models.Team", "Team")
                        .WithMany()
                        .HasForeignKey("TeamID")
                        .OnDelete(DeleteBehavior.Cascade);
                });
#pragma warning restore 612, 618
        }
    }
}

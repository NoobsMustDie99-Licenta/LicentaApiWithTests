﻿// <auto-generated />
using System;
using HobbyHorseApi.Entities.DBContext;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace HobbyHorseApi.Migrations
{
    [DbContext(typeof(HobbyHorseContext))]
    [Migration("20230624090804_initialMigration")]
    partial class initialMigration
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.4")
                .HasAnnotation("Relational:MaxIdentifierLength", 64);

            modelBuilder.Entity("EventSkateProfile", b =>
                {
                    b.Property<string>("EventsId")
                        .HasColumnType("varchar(255)");

                    b.Property<string>("SkateProfilesId")
                        .HasColumnType("varchar(255)");

                    b.HasKey("EventsId", "SkateProfilesId");

                    b.HasIndex("SkateProfilesId");

                    b.ToTable("EventSkateProfile");
                });

            modelBuilder.Entity("EventSkateProfile1", b =>
                {
                    b.Property<string>("RecommendedEventsId")
                        .HasColumnType("varchar(255)");

                    b.Property<string>("RecommendedSkateProfilesId")
                        .HasColumnType("varchar(255)");

                    b.HasKey("RecommendedEventsId", "RecommendedSkateProfilesId");

                    b.HasIndex("RecommendedSkateProfilesId");

                    b.ToTable("EventSkateProfile1");
                });

            modelBuilder.Entity("HobbyHorseApi.Entities.AssignedSkill", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("varchar(255)");

                    b.Property<string>("MasteringLevel")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<string>("SkateProfileId")
                        .IsRequired()
                        .HasColumnType("varchar(255)");

                    b.Property<string>("SkillId")
                        .IsRequired()
                        .HasColumnType("varchar(255)");

                    b.HasKey("Id");

                    b.HasIndex("SkateProfileId");

                    b.HasIndex("SkillId");

                    b.ToTable("AssignedSkills");
                });

            modelBuilder.Entity("HobbyHorseApi.Entities.CheckPoint", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("varchar(255)");

                    b.Property<string>("CustomTrailId")
                        .IsRequired()
                        .HasColumnType("varchar(255)");

                    b.Property<string>("LocationId")
                        .HasColumnType("varchar(255)");

                    b.Property<string>("Name")
                        .HasColumnType("longtext");

                    b.Property<int>("Order")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("CustomTrailId");

                    b.HasIndex("LocationId");

                    b.ToTable("CheckPoints");
                });

            modelBuilder.Entity("HobbyHorseApi.Entities.Day", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("varchar(255)");

                    b.Property<int>("DayOfMonth")
                        .HasColumnType("int");

                    b.Property<string>("OutingId")
                        .HasColumnType("varchar(255)");

                    b.Property<string>("ScheduleId")
                        .HasColumnType("varchar(255)");

                    b.HasKey("Id");

                    b.HasIndex("OutingId");

                    b.HasIndex("ScheduleId");

                    b.ToTable("Days");
                });

            modelBuilder.Entity("HobbyHorseApi.Entities.Event", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("varchar(255)");

                    b.Property<string>("Description")
                        .HasColumnType("longtext");

                    b.Property<string>("Gender")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<string>("ImageUrl")
                        .HasColumnType("longtext");

                    b.Property<int>("MaxParticipants")
                        .HasColumnType("int");

                    b.Property<int>("MaximumAge")
                        .HasColumnType("int");

                    b.Property<int>("MinimumAge")
                        .HasColumnType("int");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("varchar(100)");

                    b.Property<string>("Note")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<string>("SkateExperience")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.HasKey("Id");

                    b.ToTable("Events");
                });

            modelBuilder.Entity("HobbyHorseApi.Entities.Location", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("varchar(255)");

                    b.Property<string>("ImageUrl")
                        .HasColumnType("longtext");

                    b.Property<double>("Lat")
                        .HasColumnType("double");

                    b.Property<double>("Long")
                        .HasColumnType("double");

                    b.Property<string>("Name")
                        .HasColumnType("longtext");

                    b.HasKey("Id");

                    b.ToTable("Locations");
                });

            modelBuilder.Entity("HobbyHorseApi.Entities.Outing", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("varchar(255)");

                    b.Property<bool>("Booked")
                        .HasColumnType("tinyint(1)");

                    b.Property<double>("EndTime")
                        .HasColumnType("double");

                    b.Property<string>("EventId")
                        .IsRequired()
                        .HasColumnType("varchar(255)");

                    b.Property<string>("SkatePracticeStyle")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<double>("StartTime")
                        .HasColumnType("double");

                    b.Property<string>("TrailId")
                        .IsRequired()
                        .HasColumnType("varchar(255)");

                    b.Property<string>("VotedDayId")
                        .IsRequired()
                        .HasColumnType("varchar(255)");

                    b.Property<double>("VotedStartTime")
                        .HasColumnType("double");

                    b.HasKey("Id");

                    b.HasIndex("EventId")
                        .IsUnique();

                    b.HasIndex("TrailId");

                    b.HasIndex("VotedDayId");

                    b.ToTable("Outing");
                });

            modelBuilder.Entity("HobbyHorseApi.Entities.Schedule", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("varchar(255)");

                    b.Property<double>("EndTime")
                        .HasColumnType("double");

                    b.Property<string>("Gender")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<int>("MaxNumberOfPeople")
                        .HasColumnType("int");

                    b.Property<int?>("MaximumAge")
                        .HasColumnType("int");

                    b.Property<int?>("MinimumAge")
                        .HasColumnType("int");

                    b.Property<string>("SkateProfileId")
                        .IsRequired()
                        .HasColumnType("varchar(255)");

                    b.Property<double>("StartTime")
                        .HasColumnType("double");

                    b.HasKey("Id");

                    b.HasIndex("SkateProfileId");

                    b.ToTable("Schedules");
                });

            modelBuilder.Entity("HobbyHorseApi.Entities.ScheduleRefrence", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("varchar(255)");

                    b.Property<string>("EventId")
                        .HasColumnType("varchar(255)");

                    b.Property<bool>("EventOwner")
                        .HasColumnType("tinyint(1)");

                    b.Property<string>("ScheduleId")
                        .HasColumnType("longtext");

                    b.Property<string>("SkateProfileId")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<bool>("YesVote")
                        .HasColumnType("tinyint(1)");

                    b.HasKey("Id");

                    b.HasIndex("EventId");

                    b.ToTable("ScheduleRefrence");
                });

            modelBuilder.Entity("HobbyHorseApi.Entities.SkateProfile", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("varchar(255)");

                    b.Property<string>("SkateExperience")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<string>("SkatePracticeStyle")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<string>("SkateType")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<string>("UserId")
                        .IsRequired()
                        .HasColumnType("varchar(255)");

                    b.HasKey("Id");

                    b.HasIndex("UserId");

                    b.ToTable("SkateProfiles");
                });

            modelBuilder.Entity("HobbyHorseApi.Entities.Skill", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("varchar(255)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.HasKey("Id");

                    b.ToTable("Skills");
                });

            modelBuilder.Entity("HobbyHorseApi.Entities.SkillRecommendation", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("varchar(255)");

                    b.Property<string>("SkateExperience")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<string>("SkatePracticeStyle")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<string>("SkillId")
                        .IsRequired()
                        .HasColumnType("varchar(255)");

                    b.HasKey("Id");

                    b.HasIndex("SkillId");

                    b.ToTable("SkillRecommendations");
                });

            modelBuilder.Entity("HobbyHorseApi.Entities.Trail", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("varchar(255)");

                    b.Property<string>("Discriminator")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<string>("Name")
                        .HasColumnType("longtext");

                    b.HasKey("Id");

                    b.ToTable("Trails");

                    b.HasDiscriminator<string>("Discriminator").HasValue("Trail");

                    b.UseTphMappingStrategy();
                });

            modelBuilder.Entity("HobbyHorseApi.Entities.User", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("varchar(255)");

                    b.Property<int>("Age")
                        .HasColumnType("int");

                    b.Property<string>("Gender")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<string>("ProfileImageUrl")
                        .HasColumnType("longtext");

                    b.Property<string>("PushNotificationToken")
                        .HasColumnType("longtext");

                    b.Property<string>("ShortDescription")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.HasKey("Id");

                    b.ToTable("Users");
                });

            modelBuilder.Entity("HobbyHorseApi.Entities.Zone", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("varchar(255)");

                    b.Property<string>("LocationId")
                        .IsRequired()
                        .HasColumnType("varchar(255)");

                    b.Property<string>("Name")
                        .HasColumnType("longtext");

                    b.Property<double>("Range")
                        .HasColumnType("double");

                    b.Property<string>("ScheduleId")
                        .IsRequired()
                        .HasColumnType("varchar(255)");

                    b.HasKey("Id");

                    b.HasIndex("LocationId");

                    b.HasIndex("ScheduleId");

                    b.ToTable("Zones");
                });

            modelBuilder.Entity("HobbyHorseApi.Entities.CustomTrail", b =>
                {
                    b.HasBaseType("HobbyHorseApi.Entities.Trail");

                    b.HasDiscriminator().HasValue("CustomTrail");
                });

            modelBuilder.Entity("HobbyHorseApi.Entities.ParkTrail", b =>
                {
                    b.HasBaseType("HobbyHorseApi.Entities.Trail");

                    b.Property<int?>("Capacity")
                        .HasColumnType("int");

                    b.Property<int>("ClosingHour")
                        .HasColumnType("int");

                    b.Property<string>("LocationId")
                        .IsRequired()
                        .HasColumnType("varchar(255)");

                    b.Property<int>("OpeningHour")
                        .HasColumnType("int");

                    b.Property<string>("PracticeStyle")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<string>("PracticeStyle2")
                        .HasColumnType("longtext");

                    b.HasIndex("LocationId");

                    b.HasDiscriminator().HasValue("ParkTrail");
                });

            modelBuilder.Entity("EventSkateProfile", b =>
                {
                    b.HasOne("HobbyHorseApi.Entities.Event", null)
                        .WithMany()
                        .HasForeignKey("EventsId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("HobbyHorseApi.Entities.SkateProfile", null)
                        .WithMany()
                        .HasForeignKey("SkateProfilesId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("EventSkateProfile1", b =>
                {
                    b.HasOne("HobbyHorseApi.Entities.Event", null)
                        .WithMany()
                        .HasForeignKey("RecommendedEventsId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("HobbyHorseApi.Entities.SkateProfile", null)
                        .WithMany()
                        .HasForeignKey("RecommendedSkateProfilesId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("HobbyHorseApi.Entities.AssignedSkill", b =>
                {
                    b.HasOne("HobbyHorseApi.Entities.SkateProfile", "SkateProfile")
                        .WithMany("AssignedSkills")
                        .HasForeignKey("SkateProfileId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("HobbyHorseApi.Entities.Skill", "Skill")
                        .WithMany("AssignedSkills")
                        .HasForeignKey("SkillId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("SkateProfile");

                    b.Navigation("Skill");
                });

            modelBuilder.Entity("HobbyHorseApi.Entities.CheckPoint", b =>
                {
                    b.HasOne("HobbyHorseApi.Entities.CustomTrail", null)
                        .WithMany("CheckPoints")
                        .HasForeignKey("CustomTrailId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("HobbyHorseApi.Entities.Location", "Location")
                        .WithMany()
                        .HasForeignKey("LocationId");

                    b.Navigation("Location");
                });

            modelBuilder.Entity("HobbyHorseApi.Entities.Day", b =>
                {
                    b.HasOne("HobbyHorseApi.Entities.Outing", null)
                        .WithMany("Days")
                        .HasForeignKey("OutingId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("HobbyHorseApi.Entities.Schedule", null)
                        .WithMany("Days")
                        .HasForeignKey("ScheduleId");
                });

            modelBuilder.Entity("HobbyHorseApi.Entities.Outing", b =>
                {
                    b.HasOne("HobbyHorseApi.Entities.Event", null)
                        .WithOne("Outing")
                        .HasForeignKey("HobbyHorseApi.Entities.Outing", "EventId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("HobbyHorseApi.Entities.Trail", "Trail")
                        .WithMany()
                        .HasForeignKey("TrailId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("HobbyHorseApi.Entities.Day", "VotedDay")
                        .WithMany()
                        .HasForeignKey("VotedDayId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Trail");

                    b.Navigation("VotedDay");
                });

            modelBuilder.Entity("HobbyHorseApi.Entities.Schedule", b =>
                {
                    b.HasOne("HobbyHorseApi.Entities.SkateProfile", "SkateProfile")
                        .WithMany("Schedules")
                        .HasForeignKey("SkateProfileId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("SkateProfile");
                });

            modelBuilder.Entity("HobbyHorseApi.Entities.ScheduleRefrence", b =>
                {
                    b.HasOne("HobbyHorseApi.Entities.Event", null)
                        .WithMany("ScheduleRefrences")
                        .HasForeignKey("EventId");
                });

            modelBuilder.Entity("HobbyHorseApi.Entities.SkateProfile", b =>
                {
                    b.HasOne("HobbyHorseApi.Entities.User", "User")
                        .WithMany("SkateProfiles")
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("User");
                });

            modelBuilder.Entity("HobbyHorseApi.Entities.SkillRecommendation", b =>
                {
                    b.HasOne("HobbyHorseApi.Entities.Skill", "Skill")
                        .WithMany("SkillRecommendations")
                        .HasForeignKey("SkillId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Skill");
                });

            modelBuilder.Entity("HobbyHorseApi.Entities.Zone", b =>
                {
                    b.HasOne("HobbyHorseApi.Entities.Location", "Location")
                        .WithMany("Zones")
                        .HasForeignKey("LocationId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("HobbyHorseApi.Entities.Schedule", "Schedule")
                        .WithMany("Zones")
                        .HasForeignKey("ScheduleId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Location");

                    b.Navigation("Schedule");
                });

            modelBuilder.Entity("HobbyHorseApi.Entities.ParkTrail", b =>
                {
                    b.HasOne("HobbyHorseApi.Entities.Location", "Location")
                        .WithMany()
                        .HasForeignKey("LocationId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Location");
                });

            modelBuilder.Entity("HobbyHorseApi.Entities.Event", b =>
                {
                    b.Navigation("Outing")
                        .IsRequired();

                    b.Navigation("ScheduleRefrences");
                });

            modelBuilder.Entity("HobbyHorseApi.Entities.Location", b =>
                {
                    b.Navigation("Zones");
                });

            modelBuilder.Entity("HobbyHorseApi.Entities.Outing", b =>
                {
                    b.Navigation("Days");
                });

            modelBuilder.Entity("HobbyHorseApi.Entities.Schedule", b =>
                {
                    b.Navigation("Days");

                    b.Navigation("Zones");
                });

            modelBuilder.Entity("HobbyHorseApi.Entities.SkateProfile", b =>
                {
                    b.Navigation("AssignedSkills");

                    b.Navigation("Schedules");
                });

            modelBuilder.Entity("HobbyHorseApi.Entities.Skill", b =>
                {
                    b.Navigation("AssignedSkills");

                    b.Navigation("SkillRecommendations");
                });

            modelBuilder.Entity("HobbyHorseApi.Entities.User", b =>
                {
                    b.Navigation("SkateProfiles");
                });

            modelBuilder.Entity("HobbyHorseApi.Entities.CustomTrail", b =>
                {
                    b.Navigation("CheckPoints");
                });
#pragma warning restore 612, 618
        }
    }
}

﻿// <auto-generated />
using System;
using Issue.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace Issue.Migrations
{
    [DbContext(typeof(UserContext))]
    [Migration("20250217092012_IssueDummyAdd")]
    partial class IssueDummyAdd
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "9.0.2")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("Issue.Models.Attachments", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("FilePath")
                        .IsRequired()
                        .HasMaxLength(300)
                        .HasColumnType("nvarchar(300)");

                    b.Property<int>("IssueId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("IssueId");

                    b.ToTable("Attachments");
                });

            modelBuilder.Entity("Issue.Models.Comments", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Content")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("CreatedAt")
                        .HasColumnType("datetime2");

                    b.Property<int>("CreatedById")
                        .HasColumnType("int");

                    b.Property<int>("IssueId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("CreatedById");

                    b.HasIndex("IssueId");

                    b.ToTable("Comments");
                });

            modelBuilder.Entity("Issue.Models.IssueHistory", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<DateTime>("ChangedAt")
                        .HasColumnType("datetime2");

                    b.Property<int>("IssueId")
                        .HasColumnType("int");

                    b.Property<string>("StatusChange")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.HasKey("Id");

                    b.HasIndex("IssueId");

                    b.ToTable("IssueHistories");
                });

            modelBuilder.Entity("Issue.Models.Issues", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<int>("CreatedById")
                        .HasColumnType("int");

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("IsOngoing")
                        .HasColumnType("bit");

                    b.Property<int>("ProjectId")
                        .HasColumnType("int");

                    b.Property<string>("Title")
                        .IsRequired()
                        .HasMaxLength(200)
                        .HasColumnType("nvarchar(200)");

                    b.HasKey("Id");

                    b.HasIndex("CreatedById");

                    b.HasIndex("ProjectId");

                    b.ToTable("Issues");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            CreatedById = 1,
                            Description = "Users can't log in",
                            IsOngoing = true,
                            ProjectId = 1,
                            Title = "Login Bug"
                        },
                        new
                        {
                            Id = 2,
                            CreatedById = 2,
                            Description = "Alignment issue",
                            IsOngoing = true,
                            ProjectId = 2,
                            Title = "UI Glitch"
                        },
                        new
                        {
                            Id = 3,
                            CreatedById = 3,
                            Description = "Slow response",
                            IsOngoing = false,
                            ProjectId = 3,
                            Title = "Performance Issue"
                        },
                        new
                        {
                            Id = 4,
                            CreatedById = 4,
                            Description = "Data leak risk",
                            IsOngoing = true,
                            ProjectId = 4,
                            Title = "Security Vulnerability"
                        },
                        new
                        {
                            Id = 5,
                            CreatedById = 5,
                            Description = "DB service down",
                            IsOngoing = false,
                            ProjectId = 5,
                            Title = "Database Crash"
                        },
                        new
                        {
                            Id = 6,
                            CreatedById = 6,
                            Description = "API requests failing",
                            IsOngoing = true,
                            ProjectId = 6,
                            Title = "API Timeout"
                        },
                        new
                        {
                            Id = 7,
                            CreatedById = 7,
                            Description = "High RAM usage",
                            IsOngoing = false,
                            ProjectId = 7,
                            Title = "Memory Leak"
                        },
                        new
                        {
                            Id = 8,
                            CreatedById = 8,
                            Description = "404 error",
                            IsOngoing = true,
                            ProjectId = 8,
                            Title = "Broken Link"
                        },
                        new
                        {
                            Id = 9,
                            CreatedById = 9,
                            Description = "Buttons not responsive",
                            IsOngoing = false,
                            ProjectId = 9,
                            Title = "Mobile UI Issue"
                        },
                        new
                        {
                            Id = 10,
                            CreatedById = 10,
                            Description = "CI/CD error",
                            IsOngoing = true,
                            ProjectId = 10,
                            Title = "Deployment Failure"
                        });
                });

            modelBuilder.Entity("Issue.Models.Projects", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Description")
                        .HasMaxLength(500)
                        .HasColumnType("nvarchar(500)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(200)
                        .HasColumnType("nvarchar(200)");

                    b.HasKey("Id");

                    b.ToTable("Projects");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Description = "First project",
                            Name = "Project Alpha"
                        },
                        new
                        {
                            Id = 2,
                            Description = "Second project",
                            Name = "Project Beta"
                        },
                        new
                        {
                            Id = 3,
                            Description = "Third project",
                            Name = "Project Gamma"
                        },
                        new
                        {
                            Id = 4,
                            Description = "Fourth project",
                            Name = "Project Delta"
                        },
                        new
                        {
                            Id = 5,
                            Description = "Fifth project",
                            Name = "Project Epsilon"
                        },
                        new
                        {
                            Id = 6,
                            Description = "Sixth project",
                            Name = "Project Zeta"
                        },
                        new
                        {
                            Id = 7,
                            Description = "Seventh project",
                            Name = "Project Eta"
                        },
                        new
                        {
                            Id = 8,
                            Description = "Eighth project",
                            Name = "Project Theta"
                        },
                        new
                        {
                            Id = 9,
                            Description = "Ninth project",
                            Name = "Project Iota"
                        },
                        new
                        {
                            Id = 10,
                            Description = "Tenth project",
                            Name = "Project Kappa"
                        });
                });

            modelBuilder.Entity("Issue.Models.Users", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.Property<string>("PasswordHash")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("UserType")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.HasKey("Id");

                    b.ToTable("Users");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Email = "alice@example.com",
                            Name = "Alice Smith",
                            PasswordHash = "hashedpass1",
                            UserType = "Admin"
                        },
                        new
                        {
                            Id = 2,
                            Email = "bob@example.com",
                            Name = "Bob Johnson",
                            PasswordHash = "hashedpass2",
                            UserType = "Developer"
                        },
                        new
                        {
                            Id = 3,
                            Email = "charlie@example.com",
                            Name = "Charlie Brown",
                            PasswordHash = "hashedpass3",
                            UserType = "Reporter"
                        },
                        new
                        {
                            Id = 4,
                            Email = "david@example.com",
                            Name = "David Miller",
                            PasswordHash = "hashedpass4",
                            UserType = "Tester"
                        },
                        new
                        {
                            Id = 5,
                            Email = "eva@example.com",
                            Name = "Eva Green",
                            PasswordHash = "hashedpass5",
                            UserType = "Manager"
                        },
                        new
                        {
                            Id = 6,
                            Email = "frank@example.com",
                            Name = "Frank White",
                            PasswordHash = "hashedpass6",
                            UserType = "Developer"
                        },
                        new
                        {
                            Id = 7,
                            Email = "grace@example.com",
                            Name = "Grace Adams",
                            PasswordHash = "hashedpass7",
                            UserType = "Designer"
                        },
                        new
                        {
                            Id = 8,
                            Email = "hannah@example.com",
                            Name = "Hannah Lee",
                            PasswordHash = "hashedpass8",
                            UserType = "Admin"
                        },
                        new
                        {
                            Id = 9,
                            Email = "ian@example.com",
                            Name = "Ian Black",
                            PasswordHash = "hashedpass9",
                            UserType = "QA"
                        },
                        new
                        {
                            Id = 10,
                            Email = "jack@example.com",
                            Name = "Jack Taylor",
                            PasswordHash = "hashedpass10",
                            UserType = "Developer"
                        });
                });

            modelBuilder.Entity("Issue.Models.Attachments", b =>
                {
                    b.HasOne("Issue.Models.Issues", "Issue")
                        .WithMany("Attachments")
                        .HasForeignKey("IssueId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Issue");
                });

            modelBuilder.Entity("Issue.Models.Comments", b =>
                {
                    b.HasOne("Issue.Models.Users", "CreatedBy")
                        .WithMany("Comments")
                        .HasForeignKey("CreatedById")
                        .OnDelete(DeleteBehavior.NoAction)
                        .IsRequired();

                    b.HasOne("Issue.Models.Issues", "Issue")
                        .WithMany("Comments")
                        .HasForeignKey("IssueId")
                        .OnDelete(DeleteBehavior.NoAction)
                        .IsRequired();

                    b.Navigation("CreatedBy");

                    b.Navigation("Issue");
                });

            modelBuilder.Entity("Issue.Models.IssueHistory", b =>
                {
                    b.HasOne("Issue.Models.Issues", "Issue")
                        .WithMany("IssueHistories")
                        .HasForeignKey("IssueId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Issue");
                });

            modelBuilder.Entity("Issue.Models.Issues", b =>
                {
                    b.HasOne("Issue.Models.Users", "CreatedBy")
                        .WithMany("IssuesCreated")
                        .HasForeignKey("CreatedById")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Issue.Models.Projects", "Project")
                        .WithMany("Issues")
                        .HasForeignKey("ProjectId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("CreatedBy");

                    b.Navigation("Project");
                });

            modelBuilder.Entity("Issue.Models.Issues", b =>
                {
                    b.Navigation("Attachments");

                    b.Navigation("Comments");

                    b.Navigation("IssueHistories");
                });

            modelBuilder.Entity("Issue.Models.Projects", b =>
                {
                    b.Navigation("Issues");
                });

            modelBuilder.Entity("Issue.Models.Users", b =>
                {
                    b.Navigation("Comments");

                    b.Navigation("IssuesCreated");
                });
#pragma warning restore 612, 618
        }
    }
}

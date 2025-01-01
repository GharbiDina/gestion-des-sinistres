﻿// <auto-generated />
using System;
using Exam.Infrastructure;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace Exam.Infrastructure.Migrations
{
    [DbContext(typeof(ExamContext))]
    [Migration("20250101113405_firstMigration")]
    partial class firstMigration
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "8.0.10")
                .HasAnnotation("Proxies:ChangeTracking", false)
                .HasAnnotation("Proxies:CheckEquality", false)
                .HasAnnotation("Proxies:LazyLoading", true)
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("ApplicationCore.Domain.Assurance", b =>
                {
                    b.Property<int>("AssuranceId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("AssuranceId"));

                    b.Property<DateTime>("DateEcheance")
                        .HasColumnType("Date");

                    b.Property<DateTime>("DateEffet")
                        .HasColumnType("Date");

                    b.Property<int>("typeAssurance")
                        .HasColumnType("int");

                    b.HasKey("AssuranceId");

                    b.ToTable("Assurances");
                });

            modelBuilder.Entity("ApplicationCore.Domain.Expert", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("DomaineExpert")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("EmailAddress")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Nom")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Prenom")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<double>("TarifErr")
                        .HasColumnType("float");

                    b.Property<string>("tel")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Experts");
                });

            modelBuilder.Entity("ApplicationCore.Domain.Expertise", b =>
                {
                    b.Property<DateTime>("DateExpertise")
                        .HasColumnType("Date");

                    b.Property<int>("SinstreKey")
                        .HasColumnType("int");

                    b.Property<int>("ExpertKey")
                        .HasColumnType("int");

                    b.Property<string>("AvisTechnique")
                        .IsRequired()
                        .HasMaxLength(3)
                        .HasColumnType("nvarchar(3)");

                    b.Property<double>("Duree")
                        .HasColumnType("float");

                    b.Property<double>("MontantEstime")
                        .HasColumnType("float");

                    b.HasKey("DateExpertise", "SinstreKey", "ExpertKey");

                    b.HasIndex("ExpertKey");

                    b.HasIndex("SinstreKey");

                    b.ToTable("Expertises");
                });

            modelBuilder.Entity("ApplicationCore.Domain.Sinstre", b =>
                {
                    b.Property<int>("SinstreId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("SinstreId"));

                    b.Property<int>("AssuranceFk")
                        .HasColumnType("int");

                    b.Property<DateTime>("DateDeclaration")
                        .HasColumnType("Date");

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Lieu")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("SinstreId");

                    b.HasIndex("AssuranceFk");

                    b.ToTable("Sinstres");
                });

            modelBuilder.Entity("ApplicationCore.Domain.Expertise", b =>
                {
                    b.HasOne("ApplicationCore.Domain.Expert", "Expert")
                        .WithMany("Expertises")
                        .HasForeignKey("ExpertKey")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("ApplicationCore.Domain.Sinstre", "Sinstre")
                        .WithMany("Expertises")
                        .HasForeignKey("SinstreKey")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Expert");

                    b.Navigation("Sinstre");
                });

            modelBuilder.Entity("ApplicationCore.Domain.Sinstre", b =>
                {
                    b.HasOne("ApplicationCore.Domain.Assurance", "Assurance")
                        .WithMany("Sinstre")
                        .HasForeignKey("AssuranceFk")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Assurance");
                });

            modelBuilder.Entity("ApplicationCore.Domain.Assurance", b =>
                {
                    b.Navigation("Sinstre");
                });

            modelBuilder.Entity("ApplicationCore.Domain.Expert", b =>
                {
                    b.Navigation("Expertises");
                });

            modelBuilder.Entity("ApplicationCore.Domain.Sinstre", b =>
                {
                    b.Navigation("Expertises");
                });
#pragma warning restore 612, 618
        }
    }
}
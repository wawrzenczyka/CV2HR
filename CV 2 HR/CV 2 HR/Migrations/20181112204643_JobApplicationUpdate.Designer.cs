﻿// <auto-generated />
using System;
using CV_2_HR.EF_Core;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace CV_2_HR.Migrations
{
    [DbContext(typeof(ApplicationDbContext))]
    [Migration("20181112204643_JobApplicationUpdate")]
    partial class JobApplicationUpdate
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.1.3-rtm-32065")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("CV_2_HR.Models.Company", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Name");

                    b.HasKey("Id");

                    b.ToTable("Companies");
                });

            modelBuilder.Entity("CV_2_HR.Models.JobApplication", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<bool>("ContactAgreement");

                    b.Property<string>("CvUrl");

                    b.Property<string>("EmailAddress");

                    b.Property<string>("FirstName");

                    b.Property<string>("LastName");

                    b.Property<int>("OfferId");

                    b.Property<string>("PhoneNumber");

                    b.HasKey("Id");

                    b.HasIndex("OfferId");

                    b.ToTable("JobApplications");
                });

            modelBuilder.Entity("CV_2_HR.Models.JobOffer", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("CompanyId");

                    b.Property<DateTime>("Created");

                    b.Property<string>("Description")
                        .IsRequired();

                    b.Property<string>("JobTitle")
                        .IsRequired();

                    b.Property<string>("Location");

                    b.Property<decimal?>("SalaryFrom");

                    b.Property<decimal?>("SalaryTo");

                    b.Property<DateTime?>("ValidUntil");

                    b.HasKey("Id");

                    b.HasIndex("CompanyId");

                    b.ToTable("JobOffers");
                });

            modelBuilder.Entity("CV_2_HR.Models.JobApplication", b =>
                {
                    b.HasOne("CV_2_HR.Models.JobOffer", "Offer")
                        .WithMany("JobApplications")
                        .HasForeignKey("OfferId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("CV_2_HR.Models.JobOffer", b =>
                {
                    b.HasOne("CV_2_HR.Models.Company", "Company")
                        .WithMany()
                        .HasForeignKey("CompanyId")
                        .OnDelete(DeleteBehavior.Cascade);
                });
#pragma warning restore 612, 618
        }
    }
}

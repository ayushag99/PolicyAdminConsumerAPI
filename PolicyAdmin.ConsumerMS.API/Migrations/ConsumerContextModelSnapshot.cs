﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using PolicyAdmin.ConsumerMS.API.Data;

namespace PolicyAdmin.ConsumerMS.API.Migrations
{
    [DbContext(typeof(ConsumerContext))]
    partial class ConsumerContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("ProductVersion", "5.0.8")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("PolicyAdmin.ConsumerMS.API.Models.DAO.Business", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<double>("AnnualTurnOver")
                        .HasColumnType("float");

                    b.Property<DateTime>("BusinesIncorporation")
                        .HasColumnType("datetime2");

                    b.Property<string>("BusinessName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("BusinessType")
                        .HasColumnType("int");

                    b.Property<double>("CapitalInvested")
                        .HasColumnType("float");

                    b.Property<int>("TotalEmployees")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.ToTable("Businesses");
                });

            modelBuilder.Entity("PolicyAdmin.ConsumerMS.API.Models.DAO.BusinessMaster", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("BusinessType")
                        .HasColumnType("int");

                    b.Property<double>("MinimumAnnualTurnOver")
                        .HasColumnType("float");

                    b.Property<int>("MinimumBusinessAgeInYears")
                        .HasColumnType("int");

                    b.Property<double>("MinimumCapitalInvested")
                        .HasColumnType("float");

                    b.Property<int>("MinimumTotalEmployees")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.ToTable("BusinessesMaster");
                });

            modelBuilder.Entity("PolicyAdmin.ConsumerMS.API.Models.DAO.Consumer", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("AgentId")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("BusinessId")
                        .HasColumnType("int");

                    b.Property<DateTime>("ConsumerDOB")
                        .HasColumnType("datetime2");

                    b.Property<string>("ConsumerEmail")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ConsumerName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ConsumerPan")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("BusinessId");

                    b.ToTable("Consumers");
                });

            modelBuilder.Entity("PolicyAdmin.ConsumerMS.API.Models.DAO.Property", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<double>("BuildingSqFt")
                        .HasColumnType("float");

                    b.Property<int>("BusinessId")
                        .HasColumnType("int");

                    b.Property<double>("CostOfAsset")
                        .HasColumnType("float");

                    b.Property<int>("PropertyAge")
                        .HasColumnType("int");

                    b.Property<int>("PropertyType")
                        .HasColumnType("int");

                    b.Property<double>("SalvageValue")
                        .HasColumnType("float");

                    b.Property<int>("Storeys")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("BusinessId");

                    b.ToTable("Properties");
                });

            modelBuilder.Entity("PolicyAdmin.ConsumerMS.API.Models.DAO.PropertyMaster", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("EstimatedLife")
                        .HasColumnType("int");

                    b.Property<int>("MaximumArea")
                        .HasColumnType("int");

                    b.Property<int>("MaximumCostOfAsset")
                        .HasColumnType("int");

                    b.Property<int>("MinimumArea")
                        .HasColumnType("int");

                    b.Property<int>("MinimumCostOfAsset")
                        .HasColumnType("int");

                    b.Property<int>("PropertyAgeMax")
                        .HasColumnType("int");

                    b.Property<int>("PropertyAgeMin")
                        .HasColumnType("int");

                    b.Property<int>("PropertyType")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.ToTable("PropertiesMaster");
                });

            modelBuilder.Entity("PolicyAdmin.ConsumerMS.API.Models.DAO.Consumer", b =>
                {
                    b.HasOne("PolicyAdmin.ConsumerMS.API.Models.DAO.Business", "Business")
                        .WithMany()
                        .HasForeignKey("BusinessId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Business");
                });

            modelBuilder.Entity("PolicyAdmin.ConsumerMS.API.Models.DAO.Property", b =>
                {
                    b.HasOne("PolicyAdmin.ConsumerMS.API.Models.DAO.Business", "Business")
                        .WithMany()
                        .HasForeignKey("BusinessId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Business");
                });
#pragma warning restore 612, 618
        }
    }
}

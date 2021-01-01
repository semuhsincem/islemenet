﻿// <auto-generated />
using System;
using DataAccessLayer.Concrete.EntityFramework.Context;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace DataAccessLayer.Migrations
{
    [DbContext(typeof(CNCContext))]
    [Migration("20200905074653_newItems")]
    partial class newItems
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "3.1.7")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("Entities.Abstract.MiddleTables.Language", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Alias")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime?>("AtCreated")
                        .HasColumnType("datetime2");

                    b.Property<DateTime?>("AtDeleted")
                        .HasColumnType("datetime2");

                    b.Property<DateTime?>("AtModified")
                        .HasColumnType("datetime2");

                    b.Property<bool>("IsActive")
                        .HasColumnType("bit");

                    b.Property<bool>("IsDeleted")
                        .HasColumnType("bit");

                    b.Property<string>("Lang")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Languages");
                });

            modelBuilder.Entity("Entities.Abstract.MiddleTables.RFQCountry", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<DateTime?>("AtCreated")
                        .HasColumnType("datetime2");

                    b.Property<DateTime?>("AtDeleted")
                        .HasColumnType("datetime2");

                    b.Property<DateTime?>("AtModified")
                        .HasColumnType("datetime2");

                    b.Property<int>("CountryCode")
                        .HasColumnType("int");

                    b.Property<bool>("IsActive")
                        .HasColumnType("bit");

                    b.Property<bool>("IsDeleted")
                        .HasColumnType("bit");

                    b.Property<int>("RFQId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.ToTable("RfqCountries");
                });

            modelBuilder.Entity("Entities.Abstract.MiddleTables.UserCertification", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<DateTime?>("AtCreated")
                        .HasColumnType("datetime2");

                    b.Property<DateTime?>("AtDeleted")
                        .HasColumnType("datetime2");

                    b.Property<DateTime?>("AtModified")
                        .HasColumnType("datetime2");

                    b.Property<int>("CertificaId")
                        .HasColumnType("int");

                    b.Property<bool>("IsActive")
                        .HasColumnType("bit");

                    b.Property<bool>("IsDeleted")
                        .HasColumnType("bit");

                    b.Property<int>("UserId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.ToTable("UserCertifications");
                });

            modelBuilder.Entity("Entities.Abstract.MiddleTables.UserIndustry", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<DateTime?>("AtCreated")
                        .HasColumnType("datetime2");

                    b.Property<DateTime?>("AtDeleted")
                        .HasColumnType("datetime2");

                    b.Property<DateTime?>("AtModified")
                        .HasColumnType("datetime2");

                    b.Property<int>("IndustryId")
                        .HasColumnType("int");

                    b.Property<bool>("IsActive")
                        .HasColumnType("bit");

                    b.Property<bool>("IsDeleted")
                        .HasColumnType("bit");

                    b.Property<int>("UserId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.ToTable("UserIndustries");
                });

            modelBuilder.Entity("Entities.Abstract.MiddleTables.UserMaterial", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<DateTime?>("AtCreated")
                        .HasColumnType("datetime2");

                    b.Property<DateTime?>("AtDeleted")
                        .HasColumnType("datetime2");

                    b.Property<DateTime?>("AtModified")
                        .HasColumnType("datetime2");

                    b.Property<bool>("IsActive")
                        .HasColumnType("bit");

                    b.Property<bool>("IsDeleted")
                        .HasColumnType("bit");

                    b.Property<int>("MaterialId")
                        .HasColumnType("int");

                    b.Property<int>("UserId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.ToTable("UserMaterials");
                });

            modelBuilder.Entity("Entities.Abstract.MiddleTables.UserTechnology", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<DateTime?>("AtCreated")
                        .HasColumnType("datetime2");

                    b.Property<DateTime?>("AtDeleted")
                        .HasColumnType("datetime2");

                    b.Property<DateTime?>("AtModified")
                        .HasColumnType("datetime2");

                    b.Property<bool>("IsActive")
                        .HasColumnType("bit");

                    b.Property<bool>("IsDeleted")
                        .HasColumnType("bit");

                    b.Property<int>("TechnologyId")
                        .HasColumnType("int");

                    b.Property<int>("UserId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.ToTable("UserTechologies");
                });

            modelBuilder.Entity("Entities.Concrete.Advertisement", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<DateTime?>("AtCreated")
                        .HasColumnType("datetime2");

                    b.Property<DateTime?>("AtDeleted")
                        .HasColumnType("datetime2");

                    b.Property<DateTime?>("AtModified")
                        .HasColumnType("datetime2");

                    b.Property<string>("BasicInformation")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("CorrespondenceLanguage")
                        .HasColumnType("int");

                    b.Property<string>("CustomRFQId")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("DelivaryDate")
                        .HasColumnType("datetime2");

                    b.Property<int>("Diameter")
                        .HasColumnType("int");

                    b.Property<int>("Height")
                        .HasColumnType("int");

                    b.Property<bool>("IsActive")
                        .HasColumnType("bit");

                    b.Property<bool>("IsDeleted")
                        .HasColumnType("bit");

                    b.Property<int>("Length")
                        .HasColumnType("int");

                    b.Property<int>("MinTol")
                        .HasColumnType("int");

                    b.Property<int>("Need")
                        .HasColumnType("int");

                    b.Property<string>("OfferCurrency")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("PublicationSettingsType")
                        .HasColumnType("int");

                    b.Property<int>("Quantity")
                        .HasColumnType("int");

                    b.Property<DateTime>("RFQDeadline")
                        .HasColumnType("datetime2");

                    b.Property<string>("Title")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("Width")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.ToTable("RFQ");
                });

            modelBuilder.Entity("Entities.Concrete.Certification", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<DateTime?>("AtCreated")
                        .HasColumnType("datetime2");

                    b.Property<DateTime?>("AtDeleted")
                        .HasColumnType("datetime2");

                    b.Property<DateTime?>("AtModified")
                        .HasColumnType("datetime2");

                    b.Property<string>("CertificateName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("IsActive")
                        .HasColumnType("bit");

                    b.Property<bool>("IsDeleted")
                        .HasColumnType("bit");

                    b.HasKey("Id");

                    b.ToTable("Certifications");
                });

            modelBuilder.Entity("Entities.Concrete.CompanySize", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<DateTime?>("AtCreated")
                        .HasColumnType("datetime2");

                    b.Property<DateTime?>("AtDeleted")
                        .HasColumnType("datetime2");

                    b.Property<DateTime?>("AtModified")
                        .HasColumnType("datetime2");

                    b.Property<string>("CountrySize")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("IsActive")
                        .HasColumnType("bit");

                    b.Property<bool>("IsDeleted")
                        .HasColumnType("bit");

                    b.HasKey("Id");

                    b.ToTable("CompanySizes");
                });

            modelBuilder.Entity("Entities.Concrete.Country", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<DateTime?>("AtCreated")
                        .HasColumnType("datetime2");

                    b.Property<DateTime?>("AtDeleted")
                        .HasColumnType("datetime2");

                    b.Property<DateTime?>("AtModified")
                        .HasColumnType("datetime2");

                    b.Property<string>("CODE")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("CONTINENT_CODE")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("COUNTRY_NAME")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("COUNTRY_NUMBER")
                        .HasColumnType("int");

                    b.Property<string>("FULL_NAME")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ISO3")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("IsActive")
                        .HasColumnType("bit");

                    b.Property<bool>("IsDeleted")
                        .HasColumnType("bit");

                    b.HasKey("Id");

                    b.ToTable("Countries");
                });

            modelBuilder.Entity("Entities.Concrete.Industry", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<DateTime?>("AtCreated")
                        .HasColumnType("datetime2");

                    b.Property<DateTime?>("AtDeleted")
                        .HasColumnType("datetime2");

                    b.Property<DateTime?>("AtModified")
                        .HasColumnType("datetime2");

                    b.Property<string>("IndustryName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("IsActive")
                        .HasColumnType("bit");

                    b.Property<bool>("IsDeleted")
                        .HasColumnType("bit");

                    b.HasKey("Id");

                    b.ToTable("Industries");
                });

            modelBuilder.Entity("Entities.Concrete.Material", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<DateTime?>("AtCreated")
                        .HasColumnType("datetime2");

                    b.Property<DateTime?>("AtDeleted")
                        .HasColumnType("datetime2");

                    b.Property<DateTime?>("AtModified")
                        .HasColumnType("datetime2");

                    b.Property<bool>("IsActive")
                        .HasColumnType("bit");

                    b.Property<bool>("IsDeleted")
                        .HasColumnType("bit");

                    b.Property<string>("MaterialName")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Materials");
                });

            modelBuilder.Entity("Entities.Concrete.Technology", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<DateTime?>("AtCreated")
                        .HasColumnType("datetime2");

                    b.Property<DateTime?>("AtDeleted")
                        .HasColumnType("datetime2");

                    b.Property<DateTime?>("AtModified")
                        .HasColumnType("datetime2");

                    b.Property<bool>("IsActive")
                        .HasColumnType("bit");

                    b.Property<bool>("IsDeleted")
                        .HasColumnType("bit");

                    b.Property<string>("TechnologyName")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Technologies");
                });
#pragma warning restore 612, 618
        }
    }
}

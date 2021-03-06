﻿// <auto-generated />
using System;
using EC.Web.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace EC.Web.Data.Migrations
{
    [DbContext(typeof(ApplicationDbContext))]
    [Migration("20181202003630_RMARequest")]
    partial class RMARequest
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.1.4-rtm-31024")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("EC.Web.Areas.RMA.Data.Product", b =>
                {
                    b.Property<string>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("ModelNumber");

                    b.Property<string>("PartNumber");

                    b.Property<string>("ProductDescription");

                    b.Property<int>("WarrantyMonth");

                    b.HasKey("Id");

                    b.ToTable("Products");
                });

            modelBuilder.Entity("EC.Web.Areas.RMA.Data.ProductSerialNumber", b =>
                {
                    b.Property<string>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("ProductId");

                    b.Property<string>("SerialNumber");

                    b.Property<DateTime>("WarrantyStartFromDate");

                    b.HasKey("Id");

                    b.HasIndex("ProductId");

                    b.ToTable("ProductSerialNumbers");
                });

            modelBuilder.Entity("EC.Web.Areas.RMA.Data.RMARequest", b =>
                {
                    b.Property<string>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<DateTime>("CreatedDate");

                    b.Property<string>("CustomerContact");

                    b.Property<string>("CustomerContactEmail");

                    b.Property<string>("CustomerName");

                    b.Property<string>("InvoiceNumber");

                    b.Property<int>("RMALocation");

                    b.Property<string>("RMANumber");

                    b.Property<DateTime>("RMANumberIssueDate");

                    b.Property<string>("Remark");

                    b.Property<DateTime>("RequestDate");

                    b.Property<string>("SalesPerson");

                    b.Property<int>("Status");

                    b.HasKey("Id");

                    b.ToTable("RMARequests");
                });

            modelBuilder.Entity("EC.Web.Areas.RMA.Data.RMARequestDetail", b =>
                {
                    b.Property<string>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("CustomerApproval");

                    b.Property<string>("CustomerApprovedDate");

                    b.Property<string>("CustomerPartNumber");

                    b.Property<string>("DefectPhenomenon");

                    b.Property<string>("EightDReport");

                    b.Property<string>("EightDReportBy");

                    b.Property<DateTime>("EightDReportDate");

                    b.Property<string>("FA8DApplication");

                    b.Property<string>("FA8DApplicationBy");

                    b.Property<DateTime>("FA8DApplicationDate");

                    b.Property<string>("FailureAnalysis");

                    b.Property<string>("FailureAnalysisBy");

                    b.Property<DateTime>("FailureAnalysisDate");

                    b.Property<string>("InvoiceNumber");

                    b.Property<string>("PHAStatus");

                    b.Property<DateTime>("PHAStatusDate");

                    b.Property<string>("PHAStatusMadeBy");

                    b.Property<string>("PHCStatus");

                    b.Property<DateTime>("PHCStatusDate");

                    b.Property<string>("PHCStatusMadeBy");

                    b.Property<string>("PHNYStatus");

                    b.Property<DateTime>("PHNYStatusDate");

                    b.Property<string>("PHNYStatusMadeBy");

                    b.Property<string>("ProductId");

                    b.Property<string>("RMACompletedBy");

                    b.Property<DateTime>("RMACompletedDate");

                    b.Property<string>("RMAFinalRemark");

                    b.Property<string>("RMARequestId")
                        .IsRequired();

                    b.Property<string>("Remark");

                    b.Property<DateTime>("RepairWorkOrderIssueDate");

                    b.Property<string>("ReturnDescription");

                    b.Property<string>("ReturnReceivedBy");

                    b.Property<string>("SalesPerson");

                    b.Property<int>("SequenceNo");

                    b.Property<string>("SerialNumber");

                    b.Property<int>("UnitReturnLocation");

                    b.Property<DateTime>("UnitReturnReceivedDate");

                    b.Property<string>("WarrantyRemark");

                    b.Property<int>("WarrantyStatus");

                    b.HasKey("Id");

                    b.HasIndex("ProductId");

                    b.HasIndex("RMARequestId");

                    b.ToTable("RMARequestDetails");
                });

            modelBuilder.Entity("EC.Web.Data.ApplicationMenu", b =>
                {
                    b.Property<string>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("AreaName")
                        .HasMaxLength(30);

                    b.Property<string>("Description")
                        .IsRequired();

                    b.Property<string>("FolderName")
                        .HasMaxLength(30);

                    b.Property<string>("Icon");

                    b.Property<bool>("IsDefault");

                    b.Property<string>("MenuCaption");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(30);

                    b.Property<string>("PageName")
                        .HasMaxLength(30);

                    b.Property<string>("ParentId");

                    b.Property<int>("Position");

                    b.HasKey("Id");

                    b.HasIndex("ParentId");

                    b.ToTable("ApplicationMenus");
                });

            modelBuilder.Entity("EC.Web.Data.ApplicationRole", b =>
                {
                    b.Property<string>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken();

                    b.Property<DateTime>("CreatedDateTime");

                    b.Property<string>("Description");

                    b.Property<string>("Name")
                        .HasMaxLength(256);

                    b.Property<string>("NormalizedName")
                        .HasMaxLength(256);

                    b.HasKey("Id");

                    b.HasIndex("NormalizedName")
                        .IsUnique()
                        .HasName("RoleNameIndex")
                        .HasFilter("[NormalizedName] IS NOT NULL");

                    b.ToTable("AspNetRoles");
                });

            modelBuilder.Entity("EC.Web.Data.ApplicationRoleMenu", b =>
                {
                    b.Property<string>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("MenuId")
                        .IsRequired();

                    b.Property<string>("RoleId")
                        .IsRequired();

                    b.HasKey("Id");

                    b.HasIndex("MenuId");

                    b.HasIndex("RoleId");

                    b.ToTable("ApplicationRoleMenus");
                });

            modelBuilder.Entity("EC.Web.Data.ApplicationUser", b =>
                {
                    b.Property<string>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<int>("AccessFailedCount");

                    b.Property<string>("AvatarURL");

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken();

                    b.Property<DateTime>("CreatedDateTime");

                    b.Property<string>("Email")
                        .HasMaxLength(256);

                    b.Property<bool>("EmailConfirmed");

                    b.Property<string>("FirstName");

                    b.Property<string>("LastName");

                    b.Property<bool>("LockoutEnabled");

                    b.Property<DateTimeOffset?>("LockoutEnd");

                    b.Property<string>("NormalizedEmail")
                        .HasMaxLength(256);

                    b.Property<string>("NormalizedUserName")
                        .HasMaxLength(256);

                    b.Property<string>("PasswordHash");

                    b.Property<string>("PhoneNumber");

                    b.Property<bool>("PhoneNumberConfirmed");

                    b.Property<string>("SecurityStamp");

                    b.Property<bool>("TwoFactorEnabled");

                    b.Property<string>("UserName")
                        .HasMaxLength(256);

                    b.HasKey("Id");

                    b.HasIndex("NormalizedEmail")
                        .HasName("EmailIndex");

                    b.HasIndex("NormalizedUserName")
                        .IsUnique()
                        .HasName("UserNameIndex")
                        .HasFilter("[NormalizedUserName] IS NOT NULL");

                    b.ToTable("AspNetUsers");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRoleClaim<string>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("ClaimType");

                    b.Property<string>("ClaimValue");

                    b.Property<string>("RoleId")
                        .IsRequired();

                    b.HasKey("Id");

                    b.HasIndex("RoleId");

                    b.ToTable("AspNetRoleClaims");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserClaim<string>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("ClaimType");

                    b.Property<string>("ClaimValue");

                    b.Property<string>("UserId")
                        .IsRequired();

                    b.HasKey("Id");

                    b.HasIndex("UserId");

                    b.ToTable("AspNetUserClaims");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserLogin<string>", b =>
                {
                    b.Property<string>("LoginProvider")
                        .HasMaxLength(128);

                    b.Property<string>("ProviderKey")
                        .HasMaxLength(128);

                    b.Property<string>("ProviderDisplayName");

                    b.Property<string>("UserId")
                        .IsRequired();

                    b.HasKey("LoginProvider", "ProviderKey");

                    b.HasIndex("UserId");

                    b.ToTable("AspNetUserLogins");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserRole<string>", b =>
                {
                    b.Property<string>("UserId");

                    b.Property<string>("RoleId");

                    b.HasKey("UserId", "RoleId");

                    b.HasIndex("RoleId");

                    b.ToTable("AspNetUserRoles");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserToken<string>", b =>
                {
                    b.Property<string>("UserId");

                    b.Property<string>("LoginProvider")
                        .HasMaxLength(128);

                    b.Property<string>("Name")
                        .HasMaxLength(128);

                    b.Property<string>("Value");

                    b.HasKey("UserId", "LoginProvider", "Name");

                    b.ToTable("AspNetUserTokens");
                });

            modelBuilder.Entity("EC.Web.Areas.RMA.Data.ProductSerialNumber", b =>
                {
                    b.HasOne("EC.Web.Areas.RMA.Data.Product", "Product")
                        .WithMany("ProductSerialNumbers")
                        .HasForeignKey("ProductId");
                });

            modelBuilder.Entity("EC.Web.Areas.RMA.Data.RMARequestDetail", b =>
                {
                    b.HasOne("EC.Web.Areas.RMA.Data.Product", "Product")
                        .WithMany()
                        .HasForeignKey("ProductId");

                    b.HasOne("EC.Web.Areas.RMA.Data.RMARequest", "RMARequest")
                        .WithMany("RMARequestDetails")
                        .HasForeignKey("RMARequestId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("EC.Web.Data.ApplicationMenu", b =>
                {
                    b.HasOne("EC.Web.Data.ApplicationMenu", "Parent")
                        .WithMany("Children")
                        .HasForeignKey("ParentId");
                });

            modelBuilder.Entity("EC.Web.Data.ApplicationRoleMenu", b =>
                {
                    b.HasOne("EC.Web.Data.ApplicationMenu", "Menu")
                        .WithMany()
                        .HasForeignKey("MenuId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("EC.Web.Data.ApplicationRole", "Role")
                        .WithMany()
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRoleClaim<string>", b =>
                {
                    b.HasOne("EC.Web.Data.ApplicationRole")
                        .WithMany()
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserClaim<string>", b =>
                {
                    b.HasOne("EC.Web.Data.ApplicationUser")
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserLogin<string>", b =>
                {
                    b.HasOne("EC.Web.Data.ApplicationUser")
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserRole<string>", b =>
                {
                    b.HasOne("EC.Web.Data.ApplicationRole")
                        .WithMany()
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("EC.Web.Data.ApplicationUser")
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserToken<string>", b =>
                {
                    b.HasOne("EC.Web.Data.ApplicationUser")
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade);
                });
#pragma warning restore 612, 618
        }
    }
}

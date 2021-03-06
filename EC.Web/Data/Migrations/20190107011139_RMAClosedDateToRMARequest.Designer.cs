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
    [Migration("20190107011139_RMAClosedDateToRMARequest")]
    partial class RMAClosedDateToRMARequest
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

                    b.Property<int>("BasicWarrantyMonth");

                    b.Property<string>("ModelNumber");

                    b.Property<string>("PartNumber");

                    b.Property<string>("ProductDescription");

                    b.HasKey("Id");

                    b.ToTable("Products");
                });

            modelBuilder.Entity("EC.Web.Areas.RMA.Data.ProductSerialNumber", b =>
                {
                    b.Property<string>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("ProductId");

                    b.Property<string>("SerialNumber");

                    b.Property<DateTime>("WarrantyExpireDate");

                    b.Property<DateTime>("WarrantyStartFromDate");

                    b.HasKey("Id");

                    b.HasIndex("ProductId");

                    b.ToTable("ProductSerialNumbers");
                });

            modelBuilder.Entity("EC.Web.Areas.RMA.Data.RMACase", b =>
                {
                    b.Property<string>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("CustomerPartNumber");

                    b.Property<string>("InvoiceNumber");

                    b.Property<string>("PartNumber");

                    b.Property<string>("ProcessedByUserId");

                    b.Property<DateTime>("ProcessedDate");

                    b.Property<int>("Quantity");

                    b.Property<int>("RMACaseStatus");

                    b.Property<int>("RMALocation");

                    b.Property<string>("RMARequestId")
                        .IsRequired();

                    b.Property<string>("Remark");

                    b.Property<int>("WarrantyStatus");

                    b.HasKey("Id");

                    b.HasIndex("ProcessedByUserId");

                    b.HasIndex("RMARequestId");

                    b.ToTable("RMACases");
                });

            modelBuilder.Entity("EC.Web.Areas.RMA.Data.RMANumber", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<long>("CurrentRMANumber");

                    b.HasKey("Id");

                    b.ToTable("RMANumbers");
                });

            modelBuilder.Entity("EC.Web.Areas.RMA.Data.RMARequest", b =>
                {
                    b.Property<string>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("CustomerContact");

                    b.Property<string>("CustomerContactEmail");

                    b.Property<string>("CustomerERPId");

                    b.Property<string>("CustomerName");

                    b.Property<string>("DefectPhenomenon");

                    b.Property<string>("InvoiceNumber");

                    b.Property<string>("PartSerialNumbers");

                    b.Property<DateTime?>("RMAClosedDate");

                    b.Property<DateTime?>("RMAIssueDate");

                    b.Property<long?>("RMANumber");

                    b.Property<int>("RMAReport");

                    b.Property<string>("Remark");

                    b.Property<string>("SalesPersonUserId");

                    b.Property<int>("Status");

                    b.Property<string>("SubmittedByUserId");

                    b.Property<DateTime>("SubmittedDate");

                    b.HasKey("Id");

                    b.HasIndex("SubmittedByUserId");

                    b.ToTable("RMARequests");
                });

            modelBuilder.Entity("EC.Web.Areas.RMA.Data.RMAStage", b =>
                {
                    b.Property<string>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<int>("CorrectiveAction");

                    b.Property<string>("CorrectiveActionNote");

                    b.Property<bool>("IsActionDone");

                    b.Property<string>("Note");

                    b.Property<string>("ProcessedByUserId");

                    b.Property<DateTime>("ProcessedDate");

                    b.Property<string>("RMACaseId")
                        .IsRequired();

                    b.Property<string>("SerialNumbers");

                    b.HasKey("Id");

                    b.HasIndex("ProcessedByUserId");

                    b.HasIndex("RMACaseId");

                    b.ToTable("RMAStages");
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

            modelBuilder.Entity("EC.Web.Data.FileAttachment", b =>
                {
                    b.Property<string>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("FileName");

                    b.Property<int>("ItemNo");

                    b.Property<string>("ObjectId");

                    b.Property<string>("ObjectName");

                    b.Property<string>("RMACaseId");

                    b.Property<string>("RMARequestId");

                    b.Property<string>("RMAStageId");

                    b.Property<long>("Size");

                    b.Property<string>("UploadedByUserId");

                    b.Property<DateTime>("UploadedDate");

                    b.HasKey("Id");

                    b.HasIndex("RMACaseId");

                    b.HasIndex("RMARequestId");

                    b.HasIndex("RMAStageId");

                    b.HasIndex("UploadedByUserId");

                    b.ToTable("FileAttachments");
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

            modelBuilder.Entity("EC.Web.Areas.RMA.Data.RMACase", b =>
                {
                    b.HasOne("EC.Web.Data.ApplicationUser", "ProcessedByUser")
                        .WithMany()
                        .HasForeignKey("ProcessedByUserId");

                    b.HasOne("EC.Web.Areas.RMA.Data.RMARequest", "RMARequest")
                        .WithMany("RMACases")
                        .HasForeignKey("RMARequestId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("EC.Web.Areas.RMA.Data.RMARequest", b =>
                {
                    b.HasOne("EC.Web.Data.ApplicationUser", "SubmittedByUser")
                        .WithMany()
                        .HasForeignKey("SubmittedByUserId");
                });

            modelBuilder.Entity("EC.Web.Areas.RMA.Data.RMAStage", b =>
                {
                    b.HasOne("EC.Web.Data.ApplicationUser", "ProcessedByUser")
                        .WithMany()
                        .HasForeignKey("ProcessedByUserId");

                    b.HasOne("EC.Web.Areas.RMA.Data.RMACase", "RMACase")
                        .WithMany("RMAStages")
                        .HasForeignKey("RMACaseId")
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

            modelBuilder.Entity("EC.Web.Data.FileAttachment", b =>
                {
                    b.HasOne("EC.Web.Areas.RMA.Data.RMACase")
                        .WithMany("Attachments")
                        .HasForeignKey("RMACaseId");

                    b.HasOne("EC.Web.Areas.RMA.Data.RMARequest")
                        .WithMany("Attachments")
                        .HasForeignKey("RMARequestId");

                    b.HasOne("EC.Web.Areas.RMA.Data.RMAStage")
                        .WithMany("Attachments")
                        .HasForeignKey("RMAStageId");

                    b.HasOne("EC.Web.Data.ApplicationUser", "UploadedByUser")
                        .WithMany()
                        .HasForeignKey("UploadedByUserId");
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

﻿// <auto-generated />
using System;
using ITM_Server.Persistance.Context;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace ITM_Server.Migrations
{
    [DbContext(typeof(ItmContext))]
    [Migration("20230726114216_ninethCraete")]
    partial class ninethCraete
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "8.0.0-preview.6.23329.4")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("ITM_Server.Core.Domain.Employee", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<int>("DepartmentId")
                        .HasColumnType("int");

                    b.Property<string>("IdentityNo")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("JobId")
                        .HasColumnType("int");

                    b.Property<string>("NameSurname")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Password")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("RFIDCardNo")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("RecordNo")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("TypeId")
                        .HasColumnType("int");

                    b.Property<string>("UserName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("isWork")
                        .HasColumnType("bit");

                    b.HasKey("Id");

                    b.ToTable("Employees");
                });

            modelBuilder.Entity("ITM_Server.Core.Domain.Group", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<int>("GroupCodeId")
                        .HasColumnType("int");

                    b.Property<string>("GroupDescription")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("GroupName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("GroupCodeId");

                    b.ToTable("Groups");
                });

            modelBuilder.Entity("ITM_Server.Core.Domain.GroupCode", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("GroupCodeDescription")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("GroupCodeName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("GroupCodes");
                });

            modelBuilder.Entity("ITM_Server.Core.Domain.LineTotalQuality", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<int>("GroupId")
                        .HasColumnType("int");

                    b.Property<int>("LineId")
                        .HasColumnType("int");

                    b.Property<int>("Quality")
                        .HasColumnType("int");

                    b.Property<DateTime>("createTime")
                        .HasColumnType("datetime2");

                    b.Property<int>("styleVaryantId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("GroupId");

                    b.HasIndex("styleVaryantId");

                    b.ToTable("LineTotalQualities");
                });

            modelBuilder.Entity("ITM_Server.Core.Domain.Operation", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<int>("AparatID")
                        .HasColumnType("int");

                    b.Property<int>("Code")
                        .HasColumnType("int");

                    b.Property<int>("DepartmentId")
                        .HasColumnType("int");

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("GroupId")
                        .HasColumnType("int");

                    b.Property<int>("MachineId")
                        .HasColumnType("int");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("OperationImage")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("OperationTime")
                        .HasColumnType("int");

                    b.Property<int>("OperationTimeSpeed")
                        .HasColumnType("int");

                    b.Property<string>("ReferansCode")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<decimal>("Tolerance")
                        .HasColumnType("decimal(18,2)");

                    b.Property<int>("TypeID")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.ToTable("Operations");
                });

            modelBuilder.Entity("ITM_Server.Core.Domain.OperationActivation", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<int>("ActivationCode")
                        .HasColumnType("int");

                    b.Property<int>("LineId")
                        .HasColumnType("int");

                    b.Property<int>("OperationId")
                        .HasColumnType("int");

                    b.Property<int>("styleId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("OperationId");

                    b.HasIndex("styleId");

                    b.ToTable("OperationActivations");
                });

            modelBuilder.Entity("ITM_Server.Core.Domain.Quality", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Employee")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("GroupId")
                        .HasColumnType("int");

                    b.Property<string>("GroupName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("styleVaryantId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("GroupId");

                    b.HasIndex("styleVaryantId");

                    b.ToTable("Qualities");
                });

            modelBuilder.Entity("ITM_Server.Core.Domain.Style", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Code")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("CostingPeriodId")
                        .HasColumnType("int");

                    b.Property<int>("CustomerID")
                        .HasColumnType("int");

                    b.Property<string>("Image")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("KatalogGroupId")
                        .HasColumnType("int");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<decimal>("ReferanceNo")
                        .HasColumnType("decimal(18,2)");

                    b.Property<int>("SeasonGroupId")
                        .HasColumnType("int");

                    b.Property<int>("SetGroupId")
                        .HasColumnType("int");

                    b.Property<int>("StyleRouteId")
                        .HasColumnType("int");

                    b.Property<bool>("isArchived")
                        .HasColumnType("bit");

                    b.Property<int>("modelGroupID")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.ToTable("Styles");
                });

            modelBuilder.Entity("ITM_Server.Core.Domain.StyleVaryant", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<int>("StyleId")
                        .HasColumnType("int");

                    b.Property<int>("VaryantId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("StyleId");

                    b.HasIndex("VaryantId");

                    b.ToTable("StyleVaryants");
                });

            modelBuilder.Entity("ITM_Server.Core.Domain.Varyant", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("VaryantCode")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("VaryantDescription")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("VaryantName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Varyants");
                });

            modelBuilder.Entity("ITM_Server.Core.Domain.Group", b =>
                {
                    b.HasOne("ITM_Server.Core.Domain.GroupCode", "GroupCode")
                        .WithMany("Groups")
                        .HasForeignKey("GroupCodeId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("GroupCode");
                });

            modelBuilder.Entity("ITM_Server.Core.Domain.LineTotalQuality", b =>
                {
                    b.HasOne("ITM_Server.Core.Domain.Group", "Group")
                        .WithMany("LineTotalQualities")
                        .HasForeignKey("GroupId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("ITM_Server.Core.Domain.StyleVaryant", "StyleVaryant")
                        .WithMany("LineTotalQualities")
                        .HasForeignKey("styleVaryantId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Group");

                    b.Navigation("StyleVaryant");
                });

            modelBuilder.Entity("ITM_Server.Core.Domain.OperationActivation", b =>
                {
                    b.HasOne("ITM_Server.Core.Domain.Operation", "Operation")
                        .WithMany("OperationActivations")
                        .HasForeignKey("OperationId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("ITM_Server.Core.Domain.Style", "Style")
                        .WithMany("OperationActivations")
                        .HasForeignKey("styleId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Operation");

                    b.Navigation("Style");
                });

            modelBuilder.Entity("ITM_Server.Core.Domain.Quality", b =>
                {
                    b.HasOne("ITM_Server.Core.Domain.Group", "Group")
                        .WithMany("Qualities")
                        .HasForeignKey("GroupId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("ITM_Server.Core.Domain.StyleVaryant", "StyleVaryant")
                        .WithMany("Qualities")
                        .HasForeignKey("styleVaryantId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Group");

                    b.Navigation("StyleVaryant");
                });

            modelBuilder.Entity("ITM_Server.Core.Domain.StyleVaryant", b =>
                {
                    b.HasOne("ITM_Server.Core.Domain.Style", "Style")
                        .WithMany("StyleVaryants")
                        .HasForeignKey("StyleId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("ITM_Server.Core.Domain.Varyant", "Varyant")
                        .WithMany("StyleVaryants")
                        .HasForeignKey("VaryantId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Style");

                    b.Navigation("Varyant");
                });

            modelBuilder.Entity("ITM_Server.Core.Domain.Group", b =>
                {
                    b.Navigation("LineTotalQualities");

                    b.Navigation("Qualities");
                });

            modelBuilder.Entity("ITM_Server.Core.Domain.GroupCode", b =>
                {
                    b.Navigation("Groups");
                });

            modelBuilder.Entity("ITM_Server.Core.Domain.Operation", b =>
                {
                    b.Navigation("OperationActivations");
                });

            modelBuilder.Entity("ITM_Server.Core.Domain.Style", b =>
                {
                    b.Navigation("OperationActivations");

                    b.Navigation("StyleVaryants");
                });

            modelBuilder.Entity("ITM_Server.Core.Domain.StyleVaryant", b =>
                {
                    b.Navigation("LineTotalQualities");

                    b.Navigation("Qualities");
                });

            modelBuilder.Entity("ITM_Server.Core.Domain.Varyant", b =>
                {
                    b.Navigation("StyleVaryants");
                });
#pragma warning restore 612, 618
        }
    }
}

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
    [Migration("20230724073851_secondCreate")]
    partial class secondCreate
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

                    b.Property<int>("Quantity")
                        .HasColumnType("int");

                    b.Property<DateTime>("createTime")
                        .HasColumnType("datetime2");

                    b.Property<int>("styleId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("GroupId");

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

                    b.HasIndex("GroupId");

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

                    b.HasKey("Id");

                    b.HasIndex("OperationId");

                    b.ToTable("OperationActivations");
                });

            modelBuilder.Entity("ITM_Server.Core.Domain.OrderPlan", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<int>("LineId")
                        .HasColumnType("int");

                    b.Property<int>("OrderId")
                        .HasColumnType("int");

                    b.Property<int>("OrderSequence")
                        .HasColumnType("int");

                    b.Property<int>("PlanQuantity")
                        .HasColumnType("int");

                    b.Property<DateTime>("RealEndDate")
                        .HasColumnType("datetime2");

                    b.Property<int>("RealQuantity")
                        .HasColumnType("int");

                    b.Property<DateTime>("RealStartDate")
                        .HasColumnType("datetime2");

                    b.Property<int>("StyleId")
                        .HasColumnType("int");

                    b.Property<int>("WorkerCount")
                        .HasColumnType("int");

                    b.Property<bool>("isArchived")
                        .HasColumnType("bit");

                    b.Property<bool>("isLcd")
                        .HasColumnType("bit");

                    b.HasKey("Id");

                    b.ToTable("OrderPlans");
                });

            modelBuilder.Entity("ITM_Server.Core.Domain.Varyant", b =>
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

                    b.Navigation("Group");
                });

            modelBuilder.Entity("ITM_Server.Core.Domain.Operation", b =>
                {
                    b.HasOne("ITM_Server.Core.Domain.Group", "Group")
                        .WithMany("Operations")
                        .HasForeignKey("GroupId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Group");
                });

            modelBuilder.Entity("ITM_Server.Core.Domain.OperationActivation", b =>
                {
                    b.HasOne("ITM_Server.Core.Domain.Operation", "Operation")
                        .WithMany("OperationActivations")
                        .HasForeignKey("OperationId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Operation");
                });

            modelBuilder.Entity("ITM_Server.Core.Domain.Group", b =>
                {
                    b.Navigation("LineTotalQualities");

                    b.Navigation("Operations");
                });

            modelBuilder.Entity("ITM_Server.Core.Domain.GroupCode", b =>
                {
                    b.Navigation("Groups");
                });

            modelBuilder.Entity("ITM_Server.Core.Domain.Operation", b =>
                {
                    b.Navigation("OperationActivations");
                });
#pragma warning restore 612, 618
        }
    }
}

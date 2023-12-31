﻿// <auto-generated />
using System;
using AlexCaicedoRams_Examen1P.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace AlexCaicedoRams_Examen1P.Migrations
{
    [DbContext(typeof(AlexCaicedoRams_Examen1PContext))]
    partial class AlexCaicedoRams_Examen1PContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.23")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder, 1L, 1);

            modelBuilder.Entity("AlexCaicedoRams_Examen1P.Models.AlexCaicedo_Tabla", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("AcApellido")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<int>("AcCedula")
                        .HasMaxLength(12)
                        .HasColumnType("int");

                    b.Property<DateTime?>("AcFechaNacimiento")
                        .IsRequired()
                        .HasColumnType("datetime2");

                    b.Property<decimal>("AcIngresos")
                        .HasColumnType("decimal(18,2)");

                    b.Property<bool>("AcMayordeEdad")
                        .HasColumnType("bit");

                    b.Property<string>("AcNombre")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.HasKey("Id");

                    b.ToTable("AlexCaicedo_Tabla");
                });
#pragma warning restore 612, 618
        }
    }
}

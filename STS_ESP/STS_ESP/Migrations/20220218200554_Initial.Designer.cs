﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using STS_ESP.Models;

namespace STS_ESP.Migrations
{
    [DbContext(typeof(STSDbContext))]
    [Migration("20220218200554_Initial")]
    partial class Initial
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Relational:MaxIdentifierLength", 64)
                .HasAnnotation("ProductVersion", "5.0.14");

            modelBuilder.Entity("STS_ESP.Models.Abonnement", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<DateTime>("DateDebut")
                        .HasColumnType("datetime(6)");

                    b.Property<DateTime>("DateFin")
                        .HasColumnType("datetime(6)");

                    b.Property<double>("Prix")
                        .HasColumnType("double");

                    b.Property<string>("Type")
                        .HasColumnType("longtext");

                    b.HasKey("Id");

                    b.ToTable("Abonnement");
                });

            modelBuilder.Entity("STS_ESP.Models.CarteUsager", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<int?>("AboId")
                        .HasColumnType("int");

                    b.Property<double>("Balance")
                        .HasColumnType("double");

                    b.Property<int>("NoCarte")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("AboId");

                    b.ToTable("CarteUsagers");
                });

            modelBuilder.Entity("STS_ESP.Models.Employe", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<string>("EmailAddress")
                        .HasColumnType("longtext");

                    b.Property<string>("Motdepasse")
                        .HasColumnType("longtext");

                    b.Property<string>("NoTelephone")
                        .HasColumnType("longtext");

                    b.Property<string>("NomComplet")
                        .HasColumnType("longtext");

                    b.Property<string>("Role")
                        .HasColumnType("longtext");

                    b.Property<string>("StatutCompte")
                        .HasColumnType("longtext");

                    b.HasKey("Id");

                    b.ToTable("Employes");
                });

            modelBuilder.Entity("STS_ESP.Models.Usager", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<int?>("CarteId")
                        .HasColumnType("int");

                    b.Property<string>("EmailAddress")
                        .HasColumnType("longtext");

                    b.Property<string>("NoTelephone")
                        .HasColumnType("longtext");

                    b.Property<string>("NomComplet")
                        .HasColumnType("longtext");

                    b.Property<string>("StatutCompte")
                        .HasColumnType("longtext");

                    b.HasKey("Id");

                    b.HasIndex("CarteId");

                    b.ToTable("Usager");
                });

            modelBuilder.Entity("STS_ESP.Models.CarteUsager", b =>
                {
                    b.HasOne("STS_ESP.Models.Abonnement", "Abo")
                        .WithMany()
                        .HasForeignKey("AboId");

                    b.Navigation("Abo");
                });

            modelBuilder.Entity("STS_ESP.Models.Usager", b =>
                {
                    b.HasOne("STS_ESP.Models.CarteUsager", "Carte")
                        .WithMany()
                        .HasForeignKey("CarteId");

                    b.Navigation("Carte");
                });
#pragma warning restore 612, 618
        }
    }
}

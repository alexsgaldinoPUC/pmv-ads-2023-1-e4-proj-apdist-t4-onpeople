﻿// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using OnPeople.API.Data;

#nullable disable

namespace OnPeople.API.Data.Migrations
{
    [DbContext(typeof(DataContext))]
    [Migration("20230303135203_Initial")]
    partial class Initial
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder.HasAnnotation("ProductVersion", "7.0.3");

            modelBuilder.Entity("OnPeople.API.Models.Empresas.Empresa", b =>
                {
                    b.Property<int>("EmpresaId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<bool>("Ativa")
                        .HasColumnType("INTEGER");

                    b.Property<string>("DataCadastro")
                        .HasColumnType("TEXT");

                    b.Property<string>("DataDesativacao")
                        .HasColumnType("TEXT");

                    b.Property<bool>("Filial")
                        .HasColumnType("INTEGER");

                    b.Property<int>("MatrizId")
                        .HasColumnType("INTEGER");

                    b.Property<string>("NomeEmpresa")
                        .HasColumnType("TEXT");

                    b.Property<string>("NomeFantasia")
                        .HasColumnType("TEXT");

                    b.Property<string>("SiglaEmpresa")
                        .HasColumnType("TEXT");

                    b.HasKey("EmpresaId");

                    b.ToTable("Empresas");
                });
#pragma warning restore 612, 618
        }
    }
}

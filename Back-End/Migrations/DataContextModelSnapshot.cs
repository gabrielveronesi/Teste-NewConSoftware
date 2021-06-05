﻿// <auto-generated />
using Back_End.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace Back_End.Migrations
{
    [DbContext(typeof(DataContext))]
    partial class DataContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("ProductVersion", "5.0.6")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("Back_End.Models.PontoTuristico", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Descricao")
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.Property<string>("Nome")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("PontoTuristico");
                });

            modelBuilder.Entity("Back_End.Models.PontoTuristico", b =>
                {
                    b.OwnsOne("Back_End.Models.Localizacao", "Localizacao", b1 =>
                        {
                            b1.Property<int>("PontoTuristicoId")
                                .ValueGeneratedOnAdd()
                                .HasColumnType("int")
                                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                            b1.Property<string>("Cidade")
                                .HasColumnType("nvarchar(max)");

                            b1.Property<string>("Endereco")
                                .HasColumnType("nvarchar(max)");

                            b1.Property<string>("Estado")
                                .HasColumnType("nvarchar(max)");

                            b1.HasKey("PontoTuristicoId");

                            b1.ToTable("PontoTuristico");

                            b1.WithOwner()
                                .HasForeignKey("PontoTuristicoId");
                        });

                    b.Navigation("Localizacao");
                });
#pragma warning restore 612, 618
        }
    }
}

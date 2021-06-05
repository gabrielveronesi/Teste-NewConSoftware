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

                    b.Property<string>("Cidade")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Descricao")
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.Property<string>("Estado")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Localizacao")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Nome")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("PontoTuristico");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Cidade = "Morro do Corcovado",
                            Descricao = "Este monumento na capital fluminense é uma das 7 Maravilhas do Mundo",
                            Estado = "Rio de Janeiro",
                            Localizacao = "Floresta da Tijuca",
                            Nome = "Cristo Redentor"
                        },
                        new
                        {
                            Id = 2,
                            Cidade = "Moema",
                            Descricao = "Perfeito para corridas matinais, piqueniques, descansos à sombra das árvores.",
                            Estado = "São Paulo",
                            Localizacao = "Av. Pedro Álvares Cabral - Vila Mariana",
                            Nome = "Parque do Ibirapuera"
                        },
                        new
                        {
                            Id = 3,
                            Cidade = "Foz do Iguaçu",
                            Descricao = "As cataratas formam quedas d’água lindas, mostrando toda força da natureza!",
                            Estado = "Paraná",
                            Localizacao = "Extremo Oeste Paranaense",
                            Nome = "Cataratas do Iguaçu"
                        });
                });
#pragma warning restore 612, 618
        }
    }
}

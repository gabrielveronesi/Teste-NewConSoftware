using System.Collections.Generic;
using Back_End.Models;
using Microsoft.EntityFrameworkCore;

namespace Back_End.Data.Configuration
{
    public class CargaInicialConfiguration : IEntityTypeConfiguration<PontoTuristico>
    {
        public void Configure(Microsoft.EntityFrameworkCore.Metadata.Builders.EntityTypeBuilder<PontoTuristico> builder)
        {
                builder.HasData(new PontoTuristico()
                {
                    Id = 1,
                    Nome = "Cristo Redentor",
                    Descricao = "Este monumento na capital fluminense é uma das 7 Maravilhas do Mundo",
                    Localizacao = "Floresta da Tijuca",
                    Cidade = "Morro do Corcovado",
                    Estado = "Rio de Janeiro"
                    
                    });

                builder.HasData(new PontoTuristico()
                {
                    Id = 2,
                    Nome = "Parque do Ibirapuera",
                    Descricao = "Perfeito para corridas matinais, piqueniques, descansos à sombra das árvores.",
                    Localizacao = "Av. Pedro Álvares Cabral - Vila Mariana",
                    Cidade = "Moema",
                    Estado = "São Paulo"
                });

                builder.HasData(new PontoTuristico()
                {
                    Id = 3,
                    Nome = "Cataratas do Iguaçu",
                    Descricao = "As cataratas formam quedas d’água lindas, mostrando toda força da natureza!",
                    Localizacao = "Extremo Oeste Paranaense",
                    Cidade = "Foz do Iguaçu",
                    Estado = "Paraná"
                });


            
        }
    }
}
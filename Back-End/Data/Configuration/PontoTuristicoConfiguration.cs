using Back_End.Models;
using Microsoft.EntityFrameworkCore;

namespace Back_End.Data.Configuration
{
    public class PontoTuristicoConfiguration : IEntityTypeConfiguration<PontoTuristico>
    {
        public void Configure(Microsoft.EntityFrameworkCore.Metadata.Builders.EntityTypeBuilder<PontoTuristico> builder)
        {
            builder.OwnsOne(e => e.Localizacao);
        }
    }
}
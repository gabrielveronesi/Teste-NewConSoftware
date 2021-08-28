using System.Collections.Generic;
using Back_End.Data.Configuration;
using Back_End.Models;
using Microsoft.EntityFrameworkCore;

namespace Back_End.Data
{
    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions<DataContext> options) : base(options) { }
        public DbSet<PontoTuristico> PontoTuristico { get; set; }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);

            //Carga inicial para o banco
            builder.ApplyConfiguration(new CargaInicialConfiguration());
        }

    }
}
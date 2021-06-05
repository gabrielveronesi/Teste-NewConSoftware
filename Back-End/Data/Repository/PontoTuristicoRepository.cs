using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Back_End.Data.Interfaces;
using Back_End.Models;
using Microsoft.EntityFrameworkCore;

namespace Back_End.Data.Repository
{
    public class PontoTuristicoRepository : IPontoTuristico
    {
        private readonly DataContext _context;
        public PontoTuristicoRepository(DataContext context)
        {
            _context = context;
        }
        public async Task<PontoTuristico> AddPontoTuristicoAsync(PontoTuristico pontoTuristico)
        {
            await _context.PontoTuristico.AddAsync(pontoTuristico);
            await _context.SaveChangesAsync();
            return pontoTuristico;
        }

        public async Task<List<PontoTuristico>> GetAllPontoTuristicoAsync()
        {
            var pontos = await _context.PontoTuristico.AsNoTracking().OrderBy(p => p.Id).ToListAsync();
            return pontos;
        }

        public PontoTuristico GetPontoTuristicoByIdAsync(int Id)
        {
            throw new System.NotImplementedException();
        }
    }
}
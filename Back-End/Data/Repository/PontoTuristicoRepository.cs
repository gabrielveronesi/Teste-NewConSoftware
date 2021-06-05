using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Back_End.Data.Interfaces;
using Back_End.Helpers;
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

        public async Task<List<PontoTuristico>> GetAllPontoTuristicoAsync(PaginaParametros paginaParametros)
        {
            IQueryable<PontoTuristico> query = _context.PontoTuristico;
            query = query.AsNoTracking().OrderBy(a => a.Id).IgnoreAutoIncludes<PontoTuristico>();

            if (!string.IsNullOrEmpty(paginaParametros.Busca))
                query = query.Where(ponto => ponto.Nome
                                                  .ToUpper()
                                                  .Contains(paginaParametros.Busca.ToUpper()) ||
                                             ponto.Descricao
                                                  .ToUpper()
                                                  .Contains(paginaParametros.Busca.ToUpper()) ||
                                             ponto.Localizacao
                                                  .ToUpper()
                                                  .Contains(paginaParametros.Busca.ToUpper()) ||
                                             ponto.Cidade
                                                  .ToUpper()
                                                  .Contains(paginaParametros.Busca.ToUpper()) ||
                                             ponto.Estado
                                                  .ToUpper()
                                                  .Contains(paginaParametros.Busca.ToUpper())
                                            
                                                  );

                                            

            return await query.ToListAsync();
        }

        public PontoTuristico GetPontoTuristicoByIdAsync(int id)
        {
            IQueryable<PontoTuristico> query = _context.PontoTuristico;

            query = query.AsNoTracking()
                         .OrderBy(e => e.Id)
                         .Where(e => e.Id == id);

            return query.FirstOrDefault();
        }
    }
}
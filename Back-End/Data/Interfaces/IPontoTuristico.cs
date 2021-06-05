using System.Collections.Generic;
using System.Threading.Tasks;
using Back_End.Models;

namespace Back_End.Data.Interfaces
{
    public interface IPontoTuristico
    {
        Task<PontoTuristico> AddPontoTuristicoAsync(PontoTuristico pontoTuristico);
        Task<List<PontoTuristico>> GetAllPontoTuristicoAsync();
        PontoTuristico GetPontoTuristicoByIdAsync(int Id);
    }
}
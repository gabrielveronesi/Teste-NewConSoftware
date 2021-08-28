using Back_End.Models;

namespace Back_End.Helpers
{
    public class PaginaParametros
    {

        public const int MaxPaginaTamanho = 20;
        public int PaginaNumero { get; set; } = 1;
        private int paginaTamanho = 10;
        public int PaginaTamanho
        {
            get { return paginaTamanho; }
            set { paginaTamanho = (value > MaxPaginaTamanho) ? MaxPaginaTamanho : value; }
        }   

        public string Busca { get; set; } = string.Empty;
    }
}
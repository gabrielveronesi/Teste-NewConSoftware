using System.ComponentModel.DataAnnotations;

namespace Back_End.Models
{
    public class PontoTuristico
    {
        public int Id { get; set; }
        public string Nome { get; set; }

        [MaxLength(100, ErrorMessage = "Este campo deve conter menos que 100 catacteres")]
        public string Descricao { get; set; }
        public Localizacao Localizacao { get; set; }
    }
}

using System.ComponentModel.DataAnnotations;

namespace Atividade1_MVC.Models
{
    public class Maquiagem
    {
        public int ID { get; set; }

    [Required]
       public string Nome { get; set; }

    [Required]
       public string Marca { get; set; }

       public string? Descricao { get; set; }

       public decimal? Quantidade { get; set; }

       public string? Avaliacao { get; set; }
        
    }
}
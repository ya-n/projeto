using System.ComponentModel.DataAnnotations;

namespace Model
{
    public abstract class Pessoa
    {
       
        [Required, StringLength(30)]
        public string Nome { get; set; }
        public string Nasc { get; set; }
        [Required, MinLength(11), MaxLength(11)]   
        public string CPF { get; set; }
        public string End { get; set; }
        public string UF { get; set; }
        public string Cidade { get; set; }
        
    

    }
}

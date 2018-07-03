using System.ComponentModel.DataAnnotations;

namespace Model
{
    public class Paciente : Pessoa
    {
        [Key]
        public int UsuarioID { get; set; }
        public string FichaMedica { get; set; }

        //public int FichaID { get; set; } 
        //public virtual FichaMedica _FichaMedica { get; set; }

        
    }
}


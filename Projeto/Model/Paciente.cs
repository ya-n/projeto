using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    public class Paciente : Pessoa
    {
        [Key]
        [Required, StringLength(11)]
        public int CPF { get; set; }
        
        public int FichaID { get; set; } 
        public virtual FichaMedica _FichaMedica { get; set; }


    }
}


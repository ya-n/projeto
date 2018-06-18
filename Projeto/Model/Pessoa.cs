using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    class Pessoa
    {
       
        [Required, StringLength(30)]
        private string Nome { get; set; }
        private string Nasc { get; set; }
        [Required, StringLength(11)]
        private int CPF { get; set; }
        private string End { get; set; }
        private string UF { get; set; }
        private string Cidade { get; set; }
        
    

    }
}

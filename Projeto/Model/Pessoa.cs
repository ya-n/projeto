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
        public string Nome { get; set; }
        public string Nasc { get; set; }
        [Required, StringLength(11)]
        public int CPF { get; set; }
        public string End { get; set; }
        public string UF { get; set; }
        public string Cidade { get; set; }
        
    

    }
}

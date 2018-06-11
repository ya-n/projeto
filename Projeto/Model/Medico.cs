using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    class Medico : Pessoa
    {
        [Key]
        [Required, StringLength(10)]
        private string CRM { get; set; }
    }
}

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
        [StringLength(10)]
        public string CRM { get; set; }

    }
}

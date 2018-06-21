using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    public class Medico : Pessoa
    {
        [Key]
        [StringLength(10)]
        public string CRM { get; set; }

    }
}

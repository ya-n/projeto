using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Controller.DAL
{
    class Contexto
    {
        class Contexto //: DbContext
        {
            public Contexto() : base("strConn")
            {

            }

            public DbSet<Paciente> Pacientes { get; set; }

            public DbSet<Medico> Medicos { get; set; }

           // public DbSet<Categoria> Categorias { get; set; }
        }
    }
}

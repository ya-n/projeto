
using Model;
using System.Data.Entity;

namespace Controller.DAL
{
    class Contexto : DbContext
    {
        public Contexto() : base("strConn")
        {

        }
        //public DbSet<Pessoa> Pessoas { get; set; }
        public DbSet<Paciente> Pacientes { get; set; }

        public DbSet<Medico> Medicos { get; set; }
        
    }
}

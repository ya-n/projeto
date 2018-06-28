using Controller.DAL;
using Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Controller
{
    public class MedicosController
    {
        private Contexto contexto = new Contexto();

        public void Cadastrar(Medico entity)
        {
            //entity.Ativo = true;
            contexto.Medicos.Add(entity);
            contexto.SaveChanges();
        }

        public void Atualizar(Medico entity)
        {
            contexto.Entry(entity).State = System.Data.Entity.EntityState.Modified;
            contexto.SaveChanges();
        }

        public void EditarMedico(Medico entity)
        {
            contexto.Entry(entity).State = System.Data.Entity.EntityState.Modified;
            contexto.SaveChanges();
        }

        public Medico BuscarPorID(string crm)
        {
            return contexto.Medicos.Find(crm);
        }

        public void Excluir(string crm)
        {
        Medico m = BuscarPorID(crm);

        if (m != null)
        {
            contexto.Medicos.Remove(m);
            contexto.SaveChanges();
        }
        }

        //public IList<Paciente> ListarPorNome(string nome)
        // {
        //   return contexto.Pacientes.Where(p => p.Nome.ToLower() == nome.ToLower()).ToList();
        //}

        public IList<Medico> ListarTodos()
        {
            return contexto.Medicos.ToList();
        }
    }
}
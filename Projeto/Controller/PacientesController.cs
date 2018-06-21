using Controller.DAL;
using Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Controller
{
    class PacientesController 
    {
        
            private Contexto contexto = new Contexto();

            public void Adicionar(Paciente entity)
            {
                contexto.Pacientes.Add(entity);
                contexto.SaveChanges(); 
            }

            public void Atualizar(Paciente entity)
            {
                contexto.Entry(entity).State = System.Data.Entity.EntityState.Modified;
                contexto.SaveChanges();
            }

            public Paciente BuscarPorID(int id)
            {
                return contexto.Pacientes.Find(id);
            }

           // public void Excluir(int id)
            //{
               // Pacientes p = BuscarPorID(id);

               // if (p != null)
                //{
                //    contexto.Pacientes.Remove(p);
               //     contexto.SaveChanges();
               // }
            //}

            //public IList<Paciente> ListarPorNome(string nome)
           // {
          //   return contexto.Pacientes.Where(p => p.Nome.ToLower() == nome.ToLower()).ToList();
         //}

            public IList<Paciente> ListarTodos()
            {
                return contexto.Pacientes.ToList();
            }
        }
    }

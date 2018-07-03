using Controller.DAL;
using Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Controller
{
    public class PacientesController 
    {
        
            private Contexto contexto = new Contexto();

            public void Cadastrar(Paciente entity)
            {
                contexto.Pacientes.Add(entity);
                contexto.SaveChanges(); 
            }

            public void Atualizar(Paciente entity)
            {
                contexto.Entry(entity).State = System.Data.Entity.EntityState.Modified;
                contexto.SaveChanges();
            }

        public void EditarPaciente(Paciente entity)
        {
            contexto.Entry(entity).State = System.Data.Entity.EntityState.Modified;
            contexto.SaveChanges();
        }
        public Paciente BuscarPorID(int id)
            {
                return contexto.Pacientes.Find(id);
            }

            public void Excluir(int id)
            {
                Paciente p = BuscarPorID(id);

                if (p != null)
                {
                    contexto.Pacientes.Remove(p);
                    contexto.SaveChanges();
                }
            }

            public IList<Paciente> ListarTodos()
            {
                return contexto.Pacientes.ToList();
            }
        }
    }

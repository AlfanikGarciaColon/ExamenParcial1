using ExamenParcial1.Data;
using ExamenParciall1.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Threading.Tasks;

namespace ExamenParciall1.Controllers
{
    public class InscripcionControllers
    {

        public bool Guardar(Inscripcion entity)
        {

            bool paso = false;
            if (entity.InscripcionId == 0)
                paso = Guardar(entity);
            else
                paso = Modificar(entity);

            return paso;
        }
        public bool insertar(Inscripcion entity)
        {

            bool paso = false;
            Contexto db = new Contexto();
            try
            {

                db.Inscripcion.Add(entity);
                paso = db.SaveChanges() > 0;

            }
            catch (Exception)
            {

                throw;
            }
            finally
            {

            }


            return paso;
        }
        public bool Modificar(Inscripcion entity)
        {
            bool paso = false;
            Contexto db = new Contexto();

            try
            {
                db.Entry(entity).State = EntityState.Modified;
                paso = db.SaveChanges() > 0;

            }
            catch (Exception)
            {

                throw;
            }
            finally
            {
                db.Dispose();
            }



            return paso;

        }
        public bool Eliminar(int Id)
        {
            bool paso = false;
            Contexto db = new Contexto();

            try
            {
                Inscripcion Estudiante = db.Inscripcion.Find(Id);
                db.Entry(Estudiante).State = EntityState.Deleted;
                paso = db.SaveChanges() > 0;



            }
            catch (Exception)
            {

                throw;
            }
            finally
            {
                db.Dispose();
            }

            return paso;
        }
        public Inscripcion Buscar(int Id)
        {
            Inscripcion inscripcion;
            Contexto db = new Contexto();
            try
            {
                inscripcion = db.Inscripcion.Find(Id);
            }
            catch (Exception)
            {

                throw;
            }
            finally
            {
                db.Dispose();
            }

            return inscripcion;
        }
        public List<Inscripcion> GetList(Expression<Func<Inscripcion, bool>> expresion)
        {
            List<Inscripcion> lista = new List<Inscripcion>();

            Contexto db = new Contexto();
            try
            {
                lista = db.Inscripcion.Where(expresion).ToList();
            }
            catch (Exception)
            {

                throw;
            }

            return lista;

        }

    }
}



using ExamenParcial1.Data;
using ExamenParciall1.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ExamenParciall1.Controllers
{
    public class InscripcionControllers
    {

        public bool Guardar(Inscripcion entity)
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

    }
}

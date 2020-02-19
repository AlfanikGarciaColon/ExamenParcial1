using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ExamenParciall1.Models
{
    public class Inscripcion
    {
        public int InscricionId { get; set; }
        public int Semestre { get; set; }
        public int Limite { get; set; }
        public int Tomados { get; set; }
        public int Disponibles { get; set; }
        

        public Inscripcion()
        {
            InscricionId = 0;
            Semestre = String.Empty;
            Limite = String.Empty;
            Tomados = String.Empty;
            Disponibles = 0;
        }
    }
}

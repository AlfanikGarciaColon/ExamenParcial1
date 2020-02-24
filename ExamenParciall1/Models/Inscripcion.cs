using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace ExamenParciall1.Models
{
    public class Inscripcion
    {
        [Key]

        public int InscripcionId { get; set; }
        [Required (ErrorMessage ="Falta el semenstre")]
        public int Semestre { get; set; }
        [Required]
        public int Limite { get; set; }
        [Required]
        public int Tomados { get; set; }
        [Required]
        public int Disponibles { get; set; }

        public Inscripcion()
        {
            InscripcionId = 0;
            Semestre = 0;
            Limite = 0;
            Tomados = 0;
            Disponibles = 0;
        }

    }
}

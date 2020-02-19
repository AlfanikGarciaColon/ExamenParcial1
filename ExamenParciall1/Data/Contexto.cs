using ExamenParciall1.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ExamenParcial1.Data
{
        public class Contexto : DbContext
        {
        public DbSet<Inscripcion> Inscripcion { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
            {
            optionsBuilder.UseSqlite(@"Data Source=Database/Articulos.Db");
            }
        }
}

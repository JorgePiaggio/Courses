using MVCSistemaWebAlumnos.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace MVCSistemaWebAlumnos.Data
{
    public class AlumnoDBContext : DbContext
    {
         public AlumnoDBContext() : base("keyDBAlumnos") { }

        public DbSet<Alumno> Alumnos { get; set; }
    }
}
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;
using SistemaWebClinica.Models;

namespace SistemaWebClinica.Data
{
    public class ClinicaDBContext : DbContext
    {
        public ClinicaDBContext() : base("keydbclinicas") { }

        public DbSet<Medico> Medicos { get; set; }
    }
}
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebApiSWMedicos.Models;

namespace WebApiSWMedicos.Data
{
    public class MedicosDBContext : DbContext
    {
        public MedicosDBContext(DbContextOptions<MedicosDBContext> options) : base(options) { }

        public DbSet<Medico> Medicos { get; set; }

    }
}

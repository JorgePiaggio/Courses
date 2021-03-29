using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using WebApiAutor.Models;

namespace WebApiAutor.Data
{
    public class BaseAutorContext : DbContext
    {
        public BaseAutorContext()
        {
        }

        public BaseAutorContext(DbContextOptions<BaseAutorContext> options)
            : base(options)
        {
        }

        public DbSet<Autor> Autores { get; set; }
    }
}

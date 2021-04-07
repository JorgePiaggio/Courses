using MVCTransportes.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace MVCTransportes.Data
{
    public class TransportesDBContext :DbContext
    {
        public TransportesDBContext() : base("keyDBTransportes") { }
        public DbSet<Chofer> Choferes { get; set; }
        public DbSet<Auto> Autos { get; set; }
        public DbSet<Camion> Camiones { get; set; }
        public DbSet<Camioneta> Camionetas { get; set; }
    }
}
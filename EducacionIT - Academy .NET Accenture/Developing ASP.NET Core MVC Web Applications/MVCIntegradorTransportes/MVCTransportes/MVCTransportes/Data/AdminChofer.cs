using MVCTransportes.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MVCTransportes.Data
{
    public static class AdminChofer
    {
        private static TransportesDBContext context = new TransportesDBContext();

        public static List<Chofer> GetChoferes()
        {
            return context.Choferes.ToList();
        }

        public static Chofer GetChofer(int id)
        {
            Chofer chofer = (from c in context.Choferes where c.ChoferID == id select c).Single();
            return chofer;
        }

        public static int Create(Chofer chofer)
        {
            context.Choferes.Add(chofer);
            int result = context.SaveChanges();

            return result;
        }

        public static int Update(Chofer chofer)
        {
            Chofer c = context.Choferes.Find(chofer.ChoferID);
            int result = -1;

            if (c != null)
            {
                c.Apellido = chofer.Apellido;
                c.Nombre = chofer.Nombre;
                c.DNI = chofer.DNI;
                c.Ciudad = chofer.Ciudad;
                c.Email = chofer.Email;
                c.NroRegistro = chofer.NroRegistro;
                result = context.SaveChanges();
            }
            return result;
        }

        public static int Delete(int id)
        {
            Chofer c = context.Choferes.Find(id);
            int result = -1;

            if(c != null)
            {
                context.Choferes.Remove(c);
                result = context.SaveChanges();
            }
            return result;
        }
    }
}
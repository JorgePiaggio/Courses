using MVCTransportes.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MVCTransportes.Data
{
    public static class AdminAuto
    {
        private static TransportesDBContext context = new TransportesDBContext();

        public static List<Auto> GetAutos()
        {
            return context.Autos.ToList();
        }

        public static Auto GetChofer(int id)
        {
            Auto auto = (from a in context.Autos where a.AutoID == id select a).Single();
            return auto;
        }

        public static int Create(Auto auto)
        {
            context.Autos.Add(auto);
            int result = context.SaveChanges();

            return result;
        }

        public static int Update(Auto auto)
        {
            Auto a = context.Autos.Find(auto.AutoID);
            int result = -1;

            if (a != null)
            {
                a.Chofer = auto.Chofer;
                a.Marca = auto.Marca;
                a.Matricula = auto.Matricula;
                a.Modelo = auto.Modelo;
                a.Caracteristicas = auto.Caracteristicas;
                result = context.SaveChanges();
            }
            return result;
        }

        public static int Delete(int id)
        {
            Auto auto = context.Autos.Find(id);
            int result = -1;

            if (auto != null)
            {
                context.Autos.Remove(auto);
                result = context.SaveChanges();
            }
            return result;
        }
    }
}
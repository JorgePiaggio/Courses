using MVCTransportes.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MVCTransportes.Data
{
    public static class AdminCamion
    {
        private static TransportesDBContext context = new TransportesDBContext();

        public static List<Camion> GetCamiones()
        {
            return context.Camiones.ToList();
        }

        public static Camion GetCamion(int id)
        {
            Camion camion = (from a in context.Camiones where a.CamionID == id select a).Single();
            return camion;
        }

        public static int Create(Camion camion)
        {
            context.Camiones.Add(camion);
            int result = context.SaveChanges();

            return result;
        }

        public static int Update(Camion camion)
        {
            Camion a = context.Camiones.Find(camion.CamionID);
            int result = -1;

            if (a != null)
            {
                a.Chofer = camion.Chofer;
                a.Marca = camion.Marca;
                a.Matricula = camion.Matricula;
                a.Modelo = camion.Modelo;
                a.Caracteristicas = camion.Caracteristicas;
                result = context.SaveChanges();
            }
            return result;
        }

        public static int Delete(int id)
        {
            Camion camion = context.Camiones.Find(id);
            int result = -1;

            if (camion != null)
            {
                context.Camiones.Remove(camion);
                result = context.SaveChanges();
            }
            return result;
        }
    }
}
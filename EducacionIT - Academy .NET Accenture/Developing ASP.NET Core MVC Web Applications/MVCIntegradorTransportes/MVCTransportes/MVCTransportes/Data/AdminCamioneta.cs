using MVCTransportes.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MVCTransportes.Data
{
    public static class AdminCamioneta
    {
        private static TransportesDBContext context = new TransportesDBContext();

        public static List<Camioneta> GetCamionetas()
        {
            return context.Camionetas.ToList();
        }

        public static Camioneta GetCamioneta(int id)
        {
            Camioneta camioneta = (from a in context.Camionetas where a.CamionetaID == id select a).Single();
            return camioneta;
        }

        public static int Create(Camioneta camioneta)
        {
            context.Camionetas.Add(camioneta);
            int result = context.SaveChanges();

            return result;
        }

        public static int Update(Camioneta camioneta)
        {
            Camioneta a = context.Camionetas.Find(camioneta.CamionetaID);
            int result = -1;

            if (a != null)
            {
                a.Chofer = camioneta.Chofer;
                a.Marca = camioneta.Marca;
                a.Matricula = camioneta.Matricula;
                a.Modelo = camioneta.Modelo;
                a.Caracteristicas = camioneta.Caracteristicas;
                result = context.SaveChanges();
            }
            return result;
        }

        public static int Delete(int id)
        {
            Camioneta camioneta = context.Camionetas.Find(id);
            int result = -1;

            if (camioneta != null)
            {
                context.Camionetas.Remove(camioneta);
                result = context.SaveChanges();
            }
            return result;
        }
    }
}
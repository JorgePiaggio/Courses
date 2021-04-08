using SistemaWebClinica.Data;
using SistemaWebClinica.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace SistemaWebClinica.Repositories
{
    public static class AdminMedico
    {
        private static ClinicaDBContext context = new ClinicaDBContext();

        public static List<Medico> GetMedicos()
        {
            return context.Medicos.ToList();
        }

        public static List<Medico> GetMedicos(string especialidad)
        {
            return context.Medicos.Where(m => m.Especialidad == especialidad).ToList();
        }

        public static List<Medico> GetMedicos(string especialidad, string ciudad)
        {
            return context.Medicos.Where(m => m.Especialidad == especialidad && m.Ciudad == ciudad).ToList();
        }


        public static Medico GetMedico(int id)
        {
            return context.Medicos.Where(m => m.MedicoID == id).Single();
        }


        public static int Create(Medico medico)
        {
            context.Medicos.Add(medico);
            int result = context.SaveChanges();

            return result;
        }


        public static int Delete(int id)
        {
            Medico m = context.Medicos.Find(id);
            int result = -1;

            if( m != null)
            {
                context.Medicos.Remove(m);
                result = context.SaveChanges();
            }

            return result;
        }





    }
}
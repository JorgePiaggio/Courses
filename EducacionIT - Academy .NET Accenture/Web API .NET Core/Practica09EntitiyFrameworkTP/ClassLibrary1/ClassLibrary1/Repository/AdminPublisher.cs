using ClassLibrary1.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary1.Repository
{
    public static class AdminPublisher
    {
        private static PubsContext context = new PubsContext();

        // context
        public static List<Publisher> GetList()
        {
            return context.publishers.ToList();
        }
        // Linq to Entities ( -> queries ) 
        public static List<Publisher> GetList(string city)
        {
            List<Publisher> publisher = (from p in context.publishers where p.city == city select p).ToList();
            return publisher;
        }
        // Linq
        public static Publisher GetPublisher(string publisherId)
        {
            Publisher publisher = (from p in context.publishers where p.pub_id == publisherId select p).Single();
            return publisher;
        }

        public static int Create(Publisher publisher)
        {
            context.publishers.Add(publisher); // agrega en memoria
            int result = context.SaveChanges(); // guarda en la base
            return result;
        }
        public static int Update(Publisher publisher)
        {
            Publisher p = context.publishers.Find(publisher.pub_id);
            int result = -1;

            if (p != null)
            {
                p.pub_name = publisher.pub_name;
                p.pub_id = publisher.pub_id;
                p.city = publisher.city;
                p.state = publisher.state;
                p.country = publisher.country;
                result = context.SaveChanges();
            }

            return result;
        }

        public static int Delete(Publisher publisher)
        {
            Publisher p = context.publishers.Find(publisher.pub_id);
            int result = -1;
            if (p != null)
            {
                context.publishers.Remove(p); // marcado en memoria para eliminar
                result = context.SaveChanges(); // enviar cambios a la base
            }

            return result;
        }

    }
}

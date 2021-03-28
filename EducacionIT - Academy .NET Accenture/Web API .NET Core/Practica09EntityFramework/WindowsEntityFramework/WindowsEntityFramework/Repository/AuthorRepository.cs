using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WindowsEntityFramework.Data;

namespace WindowsEntityFramework.Repository
{
    public static class AuthorRepository
    {
        private static PubsContext context = new PubsContext();


        // context
        public static List<Author> GetList()
        {
            return context.Authors.ToList();
        }
        // Linq to Entities ( -> queries ) 
        public static List<Author> GetList(string city)
        {
            List<Author> autores = (from a in context.Authors where a.city == city select a).ToList();
            return autores;
        }
        // Linq
        public static Author GetAuthor(string authorId)
        {
            Author autor = (from a in context.Authors where a.au_id==authorId select a).Single();
            return autor;
        }

        public static int Create(Author author)
        {
            context.Authors.Add(author); // agrega en memoria
            int result = context.SaveChanges(); // guarda en la base
            return result;
        }
        public static int Update(Author author)
        {
            Author a = context.Authors.Find(author.au_id);
            int result = -1;

            if ( a != null)
            {
                a.au_lname = author.au_lname;
                a.au_fname = author.au_fname;
                a.address = author.address;
                a.city=author.city;
                a.phone=author.phone;
                a.state=author.state;
                a.zip=author.zip;
                a.contract= author.contract;
                result = context.SaveChanges();
            }

            return result;
        }

        public static int Delete(Author author)
        {
            Author a = context.Authors.Find(author.au_id);
            int result = -1;
            if (a != null) { 
                context.Authors.Remove(a); // marcado en memoria para eliminar
                result = context.SaveChanges(); // enviar cambios a la base
            }

            return result;
        }

    }
}

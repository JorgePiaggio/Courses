using Accenture.Academy.IntroC.Clase2.Models;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Accenture.Academy.IntroC.Clase2
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Persona> personas = new List<Persona>()
            {
                new Persona() { Nombre = "Sofia", Apellido = "Cordoba", FechaDeNacimiento = new DateTime(1996, 9, 4) },
                new Persona() { Nombre = "Facundo", Apellido = "Ramirez", FechaDeNacimiento = new DateTime(1999, 11, 10) },
                new Persona() { Nombre = "Luz", Apellido = "Seva", FechaDeNacimiento = new DateTime(1996, 7, 8) },
                new Persona() { Nombre = "Keila", Apellido = "Rodriguez", FechaDeNacimiento = new DateTime(2000, 9, 22) },
                new Persona() { Nombre = "Zaira", Apellido = "Gamarra", FechaDeNacimiento = new DateTime(1994, 3, 26) },
                new Persona() { Nombre = "Eduardo", Apellido = "Muñoz", FechaDeNacimiento = new DateTime(1996, 9, 4) },
                new Persona() { Nombre = "Matias", Apellido = "Velazquez", FechaDeNacimiento = new DateTime(1996, 12, 17) },
                new Persona() { Nombre = "Tomás", Apellido = "Vicente", FechaDeNacimiento = new DateTime(1993, 7, 22) }
            };


            // sumatoria de todas las edades
            int sumaEdades = 0;
            foreach (var item in personas)
            {
                sumaEdades += item.Edad;
            }
            Console.WriteLine($"La sumatoria de las edades es {sumaEdades}");

            // sumatoria de todas las edades con expresion lambda
            sumaEdades = personas.Sum( p => p.Edad);
            Console.WriteLine($"#LAMBDA - La sumatoria de las edades es {sumaEdades}");
            Console.WriteLine();


            // persona de mayor edad
            Persona mayorEdad = personas[0];
            foreach (var item in personas)
            {
                if ( item.Edad > mayorEdad.Edad )
                    mayorEdad = item;
            }
            Console.WriteLine($"La persona de mayor edad es {mayorEdad}");

            //  persona de mayor edad con expresion lambda
            mayorEdad = personas.OrderByDescending(p => p.Edad).First();
            Console.WriteLine($"#LAMBDA - La persona de mayor edad es {mayorEdad}");
            Console.WriteLine();



            // listado mayores de 21 años
            Console.WriteLine("Personas mayores de 21 años: ");
            foreach (var item in personas)
            {
                if(item.Edad > 21)
                {
                    Console.WriteLine(item);
                }
            }
            Console.WriteLine();

            // listado mayores de 21 años con expresion lambda
            Console.WriteLine("#LAMBDA - Personas mayores de 21 años: ");
            personas.Where(p => p.Edad > 21).ToList().ForEach(p => Console.WriteLine(p));
            // IEnumerable<Persona> mayores21 = personas.Where(p => p.Edad > 21);    // se recorre con foreach
            Console.WriteLine();


            // promedio de todas las edades
            double avgEdades = 0;
            foreach (var item in personas)
            {
                avgEdades += item.Edad;
            }
            avgEdades /= personas.Count();
            Console.WriteLine($"El promedio de las edades es {avgEdades}");

            // promedio de todas las edades con expresion lambda
            Console.WriteLine($"#LAMBDA - El promedio de las edades es:");
            Console.WriteLine(personas.Average(p => p.Edad));
            Console.WriteLine();


            // listas personas de menor a mayor edad
            Console.WriteLine($"#LAMBDA - Personas en orden creciente de edad:");
            personas.OrderBy(p => p.Edad).ToList().ForEach(p => Console.WriteLine(p));
            Console.WriteLine();



            // Convertir Personas en Alumnos
            List<Alumno> alumnos = personas.Select(p => new Alumno()
            {
                NombreCompleto = $"{p.Apellido}, {p.Nombre}",
                Edad = p.Edad
            }).ToList();

            Console.WriteLine($"#LAMBDA - Lista de alumnos:");
            alumnos.ForEach(alu => Console.WriteLine(alu));
            Console.WriteLine();

            // Sacar solo los nombres
            List<string> nombres = personas.Select(p => p.Nombre).ToList();
            Console.WriteLine($"#LAMBDA - Lista de nombres:");
            nombres.ForEach(n => Console.WriteLine(n));
        }
    }
}

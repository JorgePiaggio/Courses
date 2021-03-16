using Accenture.Accademy.IntroC.Clase1.Models;
using Accenture.Accademy.IntroC.Clase1.Utils;
using System;
using System.Collections.Generic;

namespace Accenture.Accademy.IntroC.Clase1
{
    class Program
    {

        static void Main(string[] args)
        {

            List<Character> avengers = new List<Character>();

            Character ironMan = new Character // "constructor initializer"
            {
                Alias = "IronMan",
                Nombre = "Tony Stark",
                Edad = 49
            };

            ironMan.Poderes.Add("Ser millonario");
            ironMan.Poderes.Add("Vender entradas de cine");

            Character spiderMan = new Character // "constructor initializer"
            {
                Alias = "SpiderMan",
                Nombre = "Peter Parker",
                Edad = 16
            };

            spiderMan.Poderes.Add("No envejecer");
            spiderMan.Poderes.Add("Lanzar telarañas");

            avengers.Add(ironMan);
            avengers.Add(spiderMan);


            Character nuevoPersonaje = new Character();
            Console.WriteLine("Hola. Bienvenido a MARVEL");
            Console.WriteLine("¿Cuál es el nombre real del nuevo Avenger?");
            nuevoPersonaje.Nombre = Console.ReadLine(); 
            Console.WriteLine("¿Cuál es el alias del nuevo Avenger?");
            nuevoPersonaje.Alias = Console.ReadLine();

            /*
            bool validAge = false;
            do
            {
                Console.WriteLine("¿Cuál es su edad?");
                string entrada = Console.ReadLine();
                if (!Int32.TryParse(entrada, out int edad))
                {
                    Console.WriteLine("Por favor ingresa un numero valido");
                }
                else
                {
                    validAge = true;
                    nuevoPersonaje.Edad = edad;
                }
            } while (!validAge);
            */

            Console.WriteLine("¿Cuál es su edad?");
            nuevoPersonaje.Edad = Utilities.ReadInt();

           
            do
            {
                Console.WriteLine("¿Qué poder tiene?");
                nuevoPersonaje.Poderes.Add(Console.ReadLine());
                Console.WriteLine("¿Tiene otro poder? S/N");
            } while (Console.ReadKey(true).Key == ConsoleKey.S);

            avengers.Add(nuevoPersonaje);



            // toString
            Console.WriteLine("Lista de Avengers: ");
            foreach (var avenger in avengers)
            {
                //Console.WriteLine($"{avenger.Nombre} alias {avenger.Alias} de edad {avenger.Edad}");
                Console.WriteLine(avenger); // ToString();
                foreach (var poder in avenger.Poderes)
                {
                    Console.WriteLine($"Su poder es: {poder}");
                }
            }











            Console.WriteLine("");
            Console.WriteLine("Presione una tecla para finalizar...");
            Console.ReadKey();

        }
    }
}

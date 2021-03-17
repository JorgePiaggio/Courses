using Accenture.Academy.IntroC.Figuras.Models;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Accenture.Academy.IntroC.Figuras
{
    class Program
    {
        static void Main(string[] args)
        {

            Triangulo tri1 = new Triangulo()
            {
                BaseFig = 15,
                AlturaFig = 20
            };
            Triangulo tri2 = new Triangulo()
            {
                BaseFig = 5,
                AlturaFig = 10
            };

            //Console.WriteLine(tri1.CalcularArea());

            Rectangulo rec1 = new Rectangulo()
            {
                BaseFig = 5,
                AlturaFig = 20
            };
            Rectangulo rec2 = new Rectangulo()
            {
                BaseFig = 4,
                AlturaFig = 8
            };

            List<Figura> figuras = new List<Figura>();
            figuras.Add(tri1);
            figuras.Add(tri2);
            figuras.Add(rec1);
            figuras.Add(rec2);


            Console.WriteLine("Superficie de las figuras en Lista de Figuras:");
            figuras.ForEach(p => Console.WriteLine(p.CalcularArea()));
            Console.WriteLine();


            Console.WriteLine("Superficie total de las figuras en Lista de Figuras (suma):");
            double total = figuras.Sum(p => p.CalcularArea());
            Console.WriteLine(total);
        }
    }
}

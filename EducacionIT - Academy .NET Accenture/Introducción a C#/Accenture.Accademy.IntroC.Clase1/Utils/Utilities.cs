using System;
using System.Collections.Generic;
using System.Text;

namespace Accenture.Accademy.IntroC.Clase1.Utils
{
    public static class Utilities
    {

        public static int ReadInt()
        {
            int numero;
            string entrada = Console.ReadLine();
            while (!Int32.TryParse(entrada, out numero))
            {
                Console.WriteLine("Por favor ingrese un número válido");
                entrada = Console.ReadLine();
            }
            return numero;
        }


    }
}

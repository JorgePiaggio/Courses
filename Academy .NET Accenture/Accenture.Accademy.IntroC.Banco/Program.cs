using Accenture.Accademy.IntroC.Banco.Models;
using System;

namespace Accenture.Accademy.IntroC.Banco
{
    class Program
    {
        static void Main(string[] args)
        {

            Cliente cliente1 = new Cliente();
            cliente1.Documento = 921213414;
            cliente1.Nombre = "John Doe";

            Cliente cliente2 = new Cliente();
            cliente2.Documento = 32113414;
            cliente2.Nombre = "Jane Doe";

            CajaDeAhorro cuenta1 = new CajaDeAhorro(cliente1, "32421525215-F2414");
            CuentaCorriente cuenta2 = new CuentaCorriente(cliente2, "32421525215-F2414");

            cuenta1.Depositar(175800);
            cuenta2.Depositar(3000000);
            cuenta2.Extraer(150000);
            cuenta2.Extraer(3000000);


            Console.WriteLine(cuenta1);
            Console.WriteLine(cuenta2);
        }
    }
}

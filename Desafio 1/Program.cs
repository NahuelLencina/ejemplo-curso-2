using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Desafio_1
{
    class Program
    {
       
        static void Main(string[] args)
        {
            Telefono t1 = new Telefono();

            Console.WriteLine("Escriba su número de telefono: ");
            t1.NumeroTelefono = Console.ReadLine();

            Console.WriteLine("Ingrese el codigo de su operador: ");
            Console.WriteLine("CLARO = 1: ");
            Console.WriteLine("MOVISTAR = 2: ");
            Console.WriteLine("PERSONAL = 3: ");

            t1.CodigoOperador = int.Parse(Console.ReadLine());

            Console.WriteLine(t1.llamar());
            Console.ReadKey();  
             
        }
    }
}

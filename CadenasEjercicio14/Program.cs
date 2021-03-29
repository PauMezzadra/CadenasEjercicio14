using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CadenasEjercicio14
{
    class Program
    {
        static void Main(string[] args)
        {
            string frase = "";
            string segundaFrase = "";

            do
            {
                Console.WriteLine("Ingrese la primer frase");
                frase = Console.ReadLine();
                if (frase == "")
                {
                    Console.WriteLine("No puede ser vacío");
                }
            } while (frase == "");

            do
            {
                Console.WriteLine("Ingrese la segunda frase");
                segundaFrase = Console.ReadLine();
                if (segundaFrase == "")
                {
                    Console.WriteLine("No puede ser vacío");
                }
            } while (segundaFrase == "");

            if (string.Equals(frase, segundaFrase, StringComparison.OrdinalIgnoreCase))
            {
                Console.WriteLine("Las frases son iguales");
            }
            else
            {
                Console.WriteLine("Las frases NO son iguales");
            }

            Console.ReadKey();
        }
    }
}

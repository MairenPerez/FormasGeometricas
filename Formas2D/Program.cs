using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Formas2D
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Rectángulo 2D");

            Rectangulo rectangulo = new Rectangulo(0, 0, 4, 5, 3);
            Console.WriteLine(rectangulo.ToString());
            Console.WriteLine("Area: " + rectangulo.CalcularAra());
            Console.WriteLine();
            Console.ReadKey();
            Console.WriteLine();

            Console.WriteLine("Círculo: ");


        }
    }
}

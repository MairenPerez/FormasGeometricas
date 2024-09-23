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
            // Instanciamos la clase Diagrama, calculamos el área total de todas las formas 
            Diagrama diagrama = new Diagrama();

            Rectangulo rectangulo = new Rectangulo(4, 5, 0);
            diagrama.AgregarForma(rectangulo);

            Cuadrado cuadrado = new Cuadrado(0, 0, 4);
            diagrama.AgregarForma(cuadrado);

            Triangulo triangulo = new Triangulo(3, 4, 3, 0);
            diagrama.AgregarForma(triangulo);

            Circulo circulo = new Circulo(5);
            diagrama.AgregarForma(circulo);

            Console.WriteLine();

            Console.WriteLine("Área total: " + diagrama.CalcularAreaTotal());
            Console.ReadKey();
        }

       // Ejercicio 3 
        public void infoFormas()
        {
            Console.WriteLine("Rectángulo");

            Rectangulo rectangulo = new Rectangulo(4, 5, 0);
            Console.WriteLine(rectangulo.ToString());
            Console.WriteLine("Área: " + rectangulo.CalcularArea());
            Console.WriteLine();

            Console.WriteLine("Cuadrado: ");
            Cuadrado cuadrado = new Cuadrado(0, 0, 4);
            Console.WriteLine(cuadrado.ToString());
            Console.WriteLine("Área: " + cuadrado.CalcularArea());
            Console.WriteLine();

            Console.WriteLine("Triángulo: ");
            Triangulo triangulo = new Triangulo(3, 4, 3, 0);
            Console.WriteLine(triangulo.ToString());
            Console.WriteLine("Perímetro: " + triangulo.CalcularPerimetro());
            Console.WriteLine();

            Console.WriteLine("Octagono: ");
            Enonagono enonagono = new Enonagono(8);
            Console.WriteLine(enonagono.ToString());
            Console.WriteLine("Área: " + enonagono.CalcularArea());
            Console.WriteLine("Perímetro: " + enonagono.CalcularPerimetro());
            Console.WriteLine();

            Console.WriteLine("Círculo: ");
            Circulo circulo = new Circulo(5);
            Console.WriteLine(circulo.ToString());
            Console.WriteLine("Área: " + circulo.CalcularArea());
            Console.WriteLine();

            Console.ReadKey();
        }
    }
}

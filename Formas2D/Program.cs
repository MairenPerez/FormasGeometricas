﻿using System;
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
            Console.WriteLine("Rectángulo");

            Rectangulo rectangulo = new Rectangulo(0, 0, 4, 5, 3);
            Console.WriteLine(rectangulo.ToString());
            Console.WriteLine("Área: " + rectangulo.CalcularArea());
            Console.WriteLine();

            Console.WriteLine("Cuadrado: ");
            Cuadrado cuadrado = new Cuadrado(0, 0, 4, 2, 2);
            Console.WriteLine(cuadrado.ToString());
            Console.WriteLine("Área: " + cuadrado.CalcularArea());
            Console.WriteLine();

            Console.WriteLine("Triángulo: ");
            Triangulo triangulo = new Triangulo(0, 0, 3, 4, 3, 90);
            Console.WriteLine(triangulo.ToString());
            Console.WriteLine("Perímetro: " + triangulo.CalcularPerimetro());
            Console.WriteLine();

            Console.WriteLine("Círculo: ");
            Circulo circulo = new Circulo(0, 0, 5);
            Console.WriteLine(circulo.ToString());
            Console.WriteLine("Área: " + circulo.CalcularArea());
            Console.WriteLine();



            Console.ReadKey();
        }
    }
}

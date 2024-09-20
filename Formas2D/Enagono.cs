using System;

namespace Formas2D
{
    public class Enonagono : Poligonos
    {
        private double lado;

        public double Lado
        {
            get { return lado; }
            set { lado = value; }
        }

        public Enonagono() : base(0, 0, 9) 
        {
            lado = 0;
        }

        public Enonagono(double area, double perimetro, double lado) : base(area, perimetro, 9) // Un enonágono siempre tiene 9 lados
        {
            this.lado = lado;
        }

        public double CalcularArea()
        {
            return (9 * Math.Pow(lado, 2)) / (4 * Math.Tan(Math.PI / 9));
        }

        public override string ToString()
        {
            return base.ToString() + " Lado: " + lado;
        }
    }
}

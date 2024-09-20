using System;

namespace Formas2D
{
    public class Decagono : Poligonos
    {
        private double lado;

        public double Lado
        {
            get { return lado; }
            set { lado = value; }
        }

        public Decagono() : base(0, 0, 10) 
        {
            lado = 0;
        }

        public Decagono(double area, double perimetro, double lado) : base(area, perimetro, 10) // Un decágono siempre tiene 10 lados
        {
            this.lado = lado;
        }

        public double CalcularArea()
        {
            return (5 * Math.Pow(lado, 2) * Math.Sqrt(5 + 2 * Math.Sqrt(5))) / 2;
        }

        public override string ToString()
        {
            return base.ToString() + " Lado: " + lado;
        }
    }
}

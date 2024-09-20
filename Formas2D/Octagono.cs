using System;

namespace Formas2D
{
    public class Octagono : Poligonos
    {
        private double lado;

        public double Lado
        {
            get { return lado; }
            set { lado = value; }
        }

        public Octagono() : base(0, 0, 8) 
        {
            lado = 0;
        }

        public Octagono(double area, double perimetro, double lado) : base(area, perimetro, 8) 
        {
            this.lado = lado;
        }

        public double CalcularArea()
        {
            return 2 * (1 + Math.Sqrt(2)) * Math.Pow(lado, 2);
        }

        public override string ToString()
        {
            return base.ToString() + " Lado: " + lado;
        }
    }
}

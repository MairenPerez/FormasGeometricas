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

        public Octagono() : base(8) 
        {
            lado = 0;
        }

        public Octagono( double lado) : base(8) 
        {
            this.lado = lado;
        }

        public double CalcularArea()
        {
            return 2 * (1 + Math.Sqrt(2)) * Math.Pow(lado, 2);
        }

        public double CalcularPerimetro()
        {
            return 8 * lado;
        }

        public override string ToString()
        {
            return base.ToString() + " Lado: " + lado;
        }
    }
}

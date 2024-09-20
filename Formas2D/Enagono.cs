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

        public Enonagono() : base(9)
        {
            lado = 0;
        }

        public Enonagono(double lado) : base(9)
        {
            this.lado = lado;
        }

        public override double CalcularArea()
        {
            return (9 * Math.Pow(lado, 2)) / (4 * Math.Tan(Math.PI / 9));
        }

        public double CalcularPerimetro()
        {
            return 9 * lado;
        }

        public override string ToString()
        {
            return base.ToString() + " Lado: " + lado;
        }
    }
}

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

        public Decagono() : base(10) 
        {
            lado = 0;
        }

        public Decagono(double lado) : base(10)
        { 
            this.lado = lado;
        }

        public double CalcularArea()
        {
            return (5 * Math.Pow(lado, 2) * Math.Sqrt(5 + 2 * Math.Sqrt(5))) / 2;
        }

        public double CalcularPerimetro()
        {
            return 10 * lado;
        }
        public override string ToString()
        {
            return base.ToString() + " Lado: " + lado;
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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

        public Octagono()
        {
            lado = 0;
        }

        public Octagono(double area, double perimetro, int numLados, double lado) : base(area, perimetro, numLados)
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

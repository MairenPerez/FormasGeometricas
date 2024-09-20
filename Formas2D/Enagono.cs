using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Formas2D
{
    public class Enagono : Poligonos
    {
        private double lado;

        public double Lado
        {
            get { return lado; }
            set { lado = value; }
        }

        public Enagono()
        {
            lado = 0;
        }

        public Enagono(double area, double perimetro, int numLados, double lado) : base(area, perimetro, numLados)
        {
            this.lado = lado;
        }

        public double CalcularArea()
        {
            return 9 * Math.Pow(lado, 2) * Math.Sqrt(81 + 9 * Math.Sqrt(30)) / 4;
        }

        public override string ToString()
        {
            return base.ToString() + " Lado: " + lado;
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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

        public Decagono()
        {
            lado = 0;
        }

        public Decagono(double area, double perimetro, int numLados, double lado) : base(area, perimetro, numLados)
        {
            this.lado = lado;
        }

        public double CalcularArea()
        {
            return 5 * Math.Pow(lado, 2) * Math.Sqrt(5 * (5 + 2 * Math.Sqrt(5))) / 4;
        }

        public override string ToString()
        {
            return base.ToString() + " Lado: " + lado;
        }
    }
}

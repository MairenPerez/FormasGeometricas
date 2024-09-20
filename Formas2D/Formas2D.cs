using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Formas2D
{
    public class Formas2D
    {
        public double Area { get; set; }
        public double Perimetro { get; set; }

        public Formas2D()
        {
            Area = 0;
            Perimetro = 0;
        }

        public Formas2D(double area, double perimetro)
        {
            Area = area;
            Perimetro = perimetro;
        }

        public override string ToString()
        {
            return $"Area: {Area} Perimetro: {Perimetro}";
        }
    }
}

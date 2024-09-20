using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Formas2D
{
    public class Formas2D
    {
        private double area;
        private double perimetro;

        public double Area
        {
            get { return area; }
            set { area = value; }
        }

        public double Perimetro
        {
            get { return perimetro; }
            set { perimetro = value; }
        }

        public Formas2D()
        {
            area = 0;
            perimetro = 0;
        }

        public Formas2D(double area, double perimetro)
        {
            this.area = area;
            this.perimetro = perimetro;
        }
    }
}

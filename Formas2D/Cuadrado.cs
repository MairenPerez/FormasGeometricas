using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Formas2D
{
    public class Cuadrado : Rectangulo
    {
        public Cuadrado(double area, double perimetro, int numLados, double baseRectangulo, double alturaRectangulo) : base(area, perimetro, numLados, baseRectangulo, alturaRectangulo)
        {
            BaseRectangulo = baseRectangulo;
            AlturaRectangulo = alturaRectangulo;
        }


        public override string ToString()
        {
            return base.ToString();
        }

        public new double CalcularArea()
        {
            return BaseRectangulo * AlturaRectangulo;
        }
    }
}
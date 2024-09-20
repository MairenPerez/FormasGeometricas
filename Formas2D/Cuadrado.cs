using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Formas2D
{
    public class Cuadrado : Rectangulo
    {
        public Cuadrado(int numLados, double baseRectangulo, double alturaRectangulo) : base(4, baseRectangulo, alturaRectangulo)
        {
            BaseRectangulo = baseRectangulo;
            AlturaRectangulo = alturaRectangulo;
        }

        public override string ToString()
        {
            return base.ToString();
        }
    }
}
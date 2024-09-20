using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Formas2D
{
    public class Rectangulo : Poligonos
    {
        public double BaseRectangulo { get; set; }
        public double AlturaRectangulo { get; set; }

        public Rectangulo()
        {
            BaseRectangulo = 0;
            AlturaRectangulo = 0;
        }

        public Rectangulo(int numLados, double baseRectangulo, double alturaRectangulo) : base(4)
        {
            BaseRectangulo = baseRectangulo;
            AlturaRectangulo = alturaRectangulo;
        }

        public double CalcularArea()
        {
            return BaseRectangulo * AlturaRectangulo;
        }

        public double CalcularPerimetro()
        {
            return 2 * (BaseRectangulo + AlturaRectangulo);
        }

        public override string ToString()
        {
            return base.ToString() + $" Base: {BaseRectangulo} Altura: {AlturaRectangulo}";
        }
    }
}

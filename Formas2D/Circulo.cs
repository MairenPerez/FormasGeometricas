using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Formas2D
{
    public class Circulo : Elipse
    {
        public Circulo()
        {
            Radio1 = 0;
            Radio2 = 0;
        }

        public Circulo(double area, double perimetro, double radio) : base(area, perimetro, radio, radio)
        {
        }

        public override string ToString()
        {
            return base.ToString();
        }

        public override double CalcularArea()
        {
            return Math.PI * Radio1 * Radio2;
        }
    }
}

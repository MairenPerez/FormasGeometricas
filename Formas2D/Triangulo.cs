using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Formas2D
{
    public class Triangulo : Poligonos
    {
        public double BaseT { get; set; }
        public double AlturaT { get; set; }
        public double Angulo { get; set; }

        public Triangulo()
        {
            BaseT = 0;
            AlturaT = 0;
            Angulo = 0;
        }

        public Triangulo(int numLados, double baseT, double alturaT, double angulo) : base(3)
        {
            BaseT = baseT;
            AlturaT = alturaT;
            Angulo = angulo;
        }

        public override double CalcularArea()
        {
            return (BaseT * AlturaT) / 2;
        }

        public double CalcularPerimetro()
        {
            return BaseT + AlturaT + Angulo;
        }



        public override string ToString()
        {
            return base.ToString() + $" Base: {BaseT} Altura: {AlturaT} Angulo: {Angulo}";
        }
    }
}

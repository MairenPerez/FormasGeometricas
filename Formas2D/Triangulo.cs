using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Formas2D
{
    public class Triangulo : Poligonos
    {
        private double baseT;
        private double alturaT;
        private double angulo;

        public double BaseT
        {
            get { return baseT; }
            set { baseT = value; }
        }

        public double AlturaT
        {
            get { return alturaT; }
            set { alturaT = value; }
        }

        public double Angulo
        {
            get { return angulo; }
            set { angulo = value; }
        }

        public Triangulo()
        {
            baseT = 0;
            alturaT = 0;
            angulo = 0;
        }

        public Triangulo(double area, double perimetro, int numLados, double baseT, double alturaT, double angulo) : base(area, perimetro, numLados)
        {
            this.baseT = baseT;
            this.alturaT = alturaT;
            this.angulo = angulo;
        }

        public double CalcularArea()
        {
            return (baseT * alturaT) / 2;
        }

        public override string ToString()
        {
            return base.ToString() + " Base: " + baseT + " Altura: " + alturaT + " Angulo: " + angulo;
        }
}

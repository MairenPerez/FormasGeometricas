using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Formas2D
{
    public class Rectangulo : Poligonos
    {
        private double baseRectangulo;
        private double alturaRectangulo;

        public double BaseRectangulo
        {
            get { return baseRectangulo; }
            set { baseRectangulo = value; }
        }

        public double AlturaRectangulo
        {
            get { return alturaRectangulo; }
            set { alturaRectangulo = value; }
        }

        public Rectangulo()
        {
            baseRectangulo = 0;
            alturaRectangulo = 0;
        }

        public Rectangulo(double area, double perimetro, int numLados, double baseRectangulo, double alturaRectangulo) : base(area, perimetro, numLados)
        {
            this.baseRectangulo = baseRectangulo;
            this.alturaRectangulo = alturaRectangulo;
        }

        /// <summary>
        /// Para calcular el area del rectángulo 
        /// </summary>
        /// <returns></returns>
        public double CalcularAra()
        {
            return baseRectangulo * alturaRectangulo;
        }

        public override string ToString()
        {
            return base.ToString() + " Base: " + baseRectangulo + " Altura: " + alturaRectangulo;
        }

     
    }
}

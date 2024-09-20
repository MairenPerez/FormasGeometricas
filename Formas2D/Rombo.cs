using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Formas2D
{
    public class Rombo : Poligonos
    {
        private double diagonal1;
        private double diagonal2;

        public double Diagonal1
        {
            get { return diagonal1; }
            set { diagonal1 = value; }
        }

        public double Diagonal2
        {
            get { return diagonal2; }
            set { diagonal2 = value; }
        }

        public Rombo()
        {
            diagonal1 = 0;
            diagonal2 = 0;
        }

        public Rombo(double area, double perimetro, int numLados, double diagonal1, double diagonal2) : base(area, perimetro, numLados)
        {
            this.diagonal1 = diagonal1;
            this.diagonal2 = diagonal2;
        }

        public double CalcularArea()
        {
            return (diagonal1 * diagonal2) / 2;
        }

        public override string ToString()
        {
            return base.ToString() + " Diagonal 1: " + diagonal1 + " Diagonal 2: " + diagonal2;
        }
    }
}
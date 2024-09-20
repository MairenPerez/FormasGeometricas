using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Formas2D
{
    public class Elipse : Formas2D
    {
        private double radio1;
        private double radio2;

        public double Radio1
        {
            get { return radio1; }
            set { radio1 = value; }
        }

        public double Radio2
        {
            get { return radio2; }
            set { radio2 = value; }
        }

        public Elipse()
        {
            radio1 = 0;
            radio2 = 0;
        }

        public Elipse(double area, double perimetro, double radio1, double radio2) : base(area, perimetro)
        {
            this.radio1 = radio1;
            this.radio2 = radio2;
        }

        public double CalcularArea()
        {
            return Math.PI * radio1 * radio2;
        }

        public override string ToString()
        {
            return base.ToString() + " Radio1: " + radio1 + " Radio2: " + radio2;
        }
    }
}

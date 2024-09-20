using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Formas2D
{
    public class Poligonos : Formas2D
    {
        private int numLados;

        public int NumLados
        {
            get { return numLados; }
            set { numLados = value; }
        }

        public Poligonos()
        {
            numLados = 0;
        }

        public Poligonos(int numLados)
        {
            this.numLados = numLados;
        }

        public override string ToString()
        {
            return base.ToString();
        }
    }
}

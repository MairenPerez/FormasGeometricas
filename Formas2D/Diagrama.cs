using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Formas2D
{
    public class Diagrama 
    {
        private List<Forma2D> formas;

        public Diagrama()
        {
            formas = new List<Forma2D>();
        }

        public void AgregarForma(Forma2D forma)
        {
            formas.Add(forma);
        }

        public double CalcularAreaTotal()
        {
            double AreaTotal = 0;
            foreach(var forma in formas)
                AreaTotal += forma.CalcularArea();

            return AreaTotal;
        }
    }
}

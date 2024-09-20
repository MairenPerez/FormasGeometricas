using System;

namespace Formas2D
{
    public class Rombo : Poligonos
    {
        private double diagonalMayor;
        private double diagonalMenor;

        public double DiagonalMayor
        {
            get { return diagonalMayor; }
            set { diagonalMayor = value; }
        }

        public double DiagonalMenor
        {
            get { return diagonalMenor; }
            set { diagonalMenor = value; }
        }

        public Rombo() : base(4)
        { 
            diagonalMayor = 0;
            diagonalMenor = 0;
        }

        public Rombo(double diagonalMayor, double diagonalMenor) : base(4) 
        {
            this.diagonalMayor = diagonalMayor;
            this.diagonalMenor = diagonalMenor;
        }

        public override double CalcularArea()
        {
            return (diagonalMayor * diagonalMenor) / 2;
        }

        public override string ToString()
        {
            return base.ToString() + " Diagonal Mayor: " + diagonalMayor + " Diagonal Menor: " + diagonalMenor;
        }
    }
}

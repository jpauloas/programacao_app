using System;
using System.Collections.Generic;
using System.Text;

namespace Atv11
{
    class Retangulo
    {
        public double ladoA;
        public double ladoB;

        public double DIAGONAL ()
        {
            double D = Math.Sqrt((ladoA * ladoA) + (ladoB * ladoB));
            return D;       
        }

        public double AREA ()
        {
            double a = ladoA * ladoB;
            return a; 
        }

        public double PERIMETRO ()
        {
            double p = ladoA * 2 + ladoB * 2;
            return p;
        }


    }
}

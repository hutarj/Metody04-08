using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Metody04_08
{
    class CelaCisla
    {
        public static double Mocnina(int zaklad, int exponent)
        {
            double mocnina = 1;
            bool zapornyExponent = exponent < 0;


            if(zapornyExponent) exponent = Math.Abs(exponent);
            for (int i = 0; i < exponent; i++) mocnina *= zaklad;
            if (zapornyExponent) mocnina = 1 / mocnina;

            return mocnina;
        }
        public static long Faktorial(int parametr)
        {
            long faktorial = 1;
            for (int i = parametr; i > 0; i--)
            {
                faktorial *= i;
            }

            return faktorial;
        }

    }
}

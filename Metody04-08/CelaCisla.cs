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
            int exponentPuvodni = Math.Abs(exponent);

            for (int i = 0; i < exponentPuvodni; i++)
            {
                mocnina *= zaklad;
            }
            if (exponent < 0) mocnina = 1 / mocnina;

            return mocnina;
        }
    }
}

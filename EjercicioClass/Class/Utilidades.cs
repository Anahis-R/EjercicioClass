using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TIC
{
    class Utilidades
    {
        public static string factorial(int calcular)
        {
            int i;
            double result = 1;
            string a;
            for (i = 1; i <= calcular; i++)
            {
                result = result * i;
            }
            a = result + Environment.NewLine;
            return a;
        }
    }
}


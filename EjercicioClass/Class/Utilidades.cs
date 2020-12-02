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
            int j;
            double resultado = 1;
            string a;
            for (j = 1; j <= calcular; j++)
            {
                resultado *=  j;
            }
            a = resultado + Environment.NewLine;
            return a;
        }
    }
}


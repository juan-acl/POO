using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POO
{
    internal class csMCD
    {
        public int calcularMCD(int numero)
        {
            int mcd = 1;
            for (int i = 1; i <= numero; i++)
            {
                if (numero % i == 0)
                {
                    mcd = i;
                }
            }
            return mcd;
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POO
{
    internal class csVolumen
    {
        public double calcularVolumen(double radio, double altura)
        {
            return Math.PI * Math.Pow(radio, 2) * altura;
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POO
{
    internal class csEntero
    {
        public string calcularPositivo(int number_input)
        {
            string msj = "";
            msj = Math.Sign(number_input) == 1 ? "El numero es positivo" : (Math.Sign(number_input) == -1 ? "El numero es negativo" : "El numero es igual a cero");
            return msj;
        }
    }
}

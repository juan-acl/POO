using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POO
{
    internal class csEquipo
    {
        public string calcularMarcador(int[] scores, string[] names)
        {
            string msj = "";
            if (scores[0] > scores[1]) msj = "El equipo ganador es: " + names[0];
            else if (scores[0] < scores[1]) msj = "El equipo ganador es: " + names[1];
            else msj = "El encuentro fue un empate";
            return msj;
        }
    }
}
